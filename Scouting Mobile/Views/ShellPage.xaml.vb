Imports Scouting_Mobile.Core.Helpers
Imports Scouting_Mobile.Core.Services
Imports Scouting_Mobile.Helpers
Imports Scouting_Mobile.Models
Imports Scouting_Mobile.Services

Imports Windows.System

Imports WinUI = Microsoft.UI.Xaml.Controls

Namespace Views
    ' TODO WTS: Change the icons and titles for all NavigationViewItems in ShellPage.xaml.
    Public NotInheritable Partial Class ShellPage
        Inherits Page
        Implements INotifyPropertyChanged

        Private ReadOnly _altLeftKeyboardAccelerator As KeyboardAccelerator = BuildKeyboardAccelerator(VirtualKey.Left, VirtualKeyModifiers.Menu)
        Private ReadOnly _backKeyboardAccelerator As KeyboardAccelerator = BuildKeyboardAccelerator(VirtualKey.GoBack)

        Private _isBackEnabled As Boolean
        Private _selected As WinUI.NavigationViewItem
        Private _user As UserData
        Private _isBusy As Boolean
        Private _isLoggedIn As Boolean
        Private _isAuthorized As Boolean

        Private ReadOnly Property IdentityService As IdentityService
            Get
                Return Singleton(Of IdentityService).Instance
            End Get
        End Property

        Private ReadOnly Property UserDataService As UserDataService
            Get
                Return Singleton(Of UserDataService).Instance
            End Get
        End Property


        Public Property IsBackEnabled As Boolean
            Get
                Return _isBackEnabled
            End Get

            Set(value As Boolean)
                [Set](_isBackEnabled, value)
            End Set
        End Property

        Public Property Selected As WinUI.NavigationViewItem
            Get
                Return _selected
            End Get

            Set(value As WinUI.NavigationViewItem)
                [Set](_selected, value)
            End Set
        End Property


        Public Property User As UserData
            Get
                Return _user
            End Get
            Set(value As UserData)
                [Set](_user, value)
            End Set
        End Property

        Public Property IsBusy As Boolean
            Get
                Return _isBusy
            End Get
            Set(value As Boolean)
                [Set](_isBusy, value)
            End Set
        End Property

        Public Property IsLoggedIn As Boolean
            Get
                Return _isLoggedIn
            End Get
            Set(value As Boolean)
                [Set](_isLoggedIn, value)
            End Set
        End Property

        Public Property IsAuthorized As Boolean
            Get
                Return _isAuthorized
            End Get
            Set(value As Boolean)
                [Set](_isAuthorized, value)
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            DataContext = Me
            Initialize()
        End Sub

        Private Sub Initialize()
            NavigationService.Frame = shellFrame
            AddHandler NavigationService.NavigationFailed, Function(sender, e)
                                                                Throw e.Exception
                                                            End Function
            AddHandler NavigationService.Navigated, AddressOf Frame_Navigated
            AddHandler navigationView.BackRequested, AddressOf OnBackRequested
            AddHandler IdentityService.LoggedIn, AddressOf OnLoggedIn
            AddHandler IdentityService.LoggedOut, AddressOf OnLoggedOut
            AddHandler UserDataService.UserDataUpdated, AddressOf OnUserDataUpdated
        End Sub

        Private Async Sub OnLoaded(sender As Object, e As RoutedEventArgs)
            ' Keyboard accelerators are added here to avoid showing 'Alt + left' tooltip on the page.
            ' More info on tracking issue https://github.com/Microsoft/microsoft-ui-xaml/issues/8
            keyboardAccelerators.Add(_altLeftKeyboardAccelerator)
            keyboardAccelerators.Add(_backKeyboardAccelerator)
            IsLoggedIn = IdentityService.IsLoggedIn()
            IsAuthorized = IsLoggedIn AndAlso IdentityService.IsAuthorized()
            User = Await UserDataService.GetUserAsync()
        End Sub

        Private Sub OnUserDataUpdated(sender As Object, userData As UserData)
            User = userData
        End Sub

        Private Sub OnLoggedIn(sender As Object, e As EventArgs)
            IsLoggedIn = True
            IsAuthorized = IsLoggedIn AndAlso IdentityService.IsAuthorized()
            IsBusy = False
        End Sub

        Private Sub OnLoggedOut(sender As Object, e As EventArgs)
            User = Nothing
            IsLoggedIn = False
            IsAuthorized = False
            CleanRestrictedPagesFromNavigationHistory()
            GoBackToLastUnrestrictedPage()
        End Sub

        Private Sub CleanRestrictedPagesFromNavigationHistory()
            NavigationService.Frame.BackStack.
                Where(Function(backStackEntry) Attribute.IsDefined(backStackEntry.SourcePageType, GetType(Restricted))).
                ToList().
                ForEach(Sub(restricted) NavigationService.Frame.BackStack.Remove(restricted))
        End Sub

        Private Sub GoBackToLastUnrestrictedPage()
            Dim currentPage = TryCast(NavigationService.Frame.Content, Page)
            Dim isCurrentPageRestricted = Attribute.IsDefined(currentPage.[GetType](), GetType(Restricted))

            If isCurrentPageRestricted Then
                NavigationService.GoBack()
            End If
        End Sub

        Private Async Sub OnUserProfile(sender As Object, e As RoutedEventArgs)
            If IsLoggedIn Then
                NavigationService.Navigate(Of SettingsPage)()
            Else
                IsBusy = True
                Dim loginResult = Await IdentityService.LoginAsync()

                If loginResult <> LoginResultType.Success Then
                    Await AuthenticationHelper.ShowLoginErrorAsync(loginResult)
                    IsBusy = False
                End If
            End If
        End Sub

        Private Sub OnBackRequested(sender As WinUI.NavigationView, args As WinUI.NavigationViewBackRequestedEventArgs)
            NavigationService.GoBack()
        End Sub

        Private Sub Frame_NavigationFailed(sender As Object, e As NavigationFailedEventArgs)
            Throw e.Exception
        End Sub

        Public Sub Frame_Navigated(sender As Object, e As NavigationEventArgs)
            IsBackEnabled = NavigationService.CanGoBack
            If e.SourcePageType = GetType(SettingsPage) Then
                Selected = TryCast(navigationView.SettingsItem, WinUI.NavigationViewItem)
                Return
            End If

            Selected = navigationView.MenuItems.OfType(Of WinUI.NavigationViewItem)().FirstOrDefault(Function(menuItem) IsMenuItemForPageType(menuItem, e.SourcePageType))
        End Sub

        Private Function IsMenuItemForPageType(menuItem As WinUI.NavigationViewItem, sourcePageType As Type) As Boolean
            Dim pageType = TryCast(menuItem.GetValue(NavHelper.NavigateToProperty), Type)
            Return pageType = sourcePageType
        End Function

        Private Sub OnItemInvoked(sender As WinUI.NavigationView, args As WinUI.NavigationViewItemInvokedEventArgs)
            If args.IsSettingsInvoked Then
                NavigationService.Navigate(GetType(SettingsPage))
                Return
            End If

            Dim item = navigationView.MenuItems.OfType(Of WinUI.NavigationViewItem)().First(Function(menuItem) CStr(menuItem.Content) = CStr(args.InvokedItem))
            Dim pageType = TryCast(item.GetValue(NavHelper.NavigateToProperty), Type)
            NavigationService.Navigate(pageType)
        End Sub

        Private Function BuildKeyboardAccelerator(key As VirtualKey, Optional modifiers As VirtualKeyModifiers? = Nothing) As KeyboardAccelerator
            Dim keyboardAccelerator = New KeyboardAccelerator() With {
                .Key = key
            }

            If modifiers.HasValue Then
                keyboardAccelerator.Modifiers = modifiers.Value
            End If

            AddHandler keyboardAccelerator.Invoked, AddressOf OnKeyboardAcceleratorInvoked
            Return keyboardAccelerator
        End Function

        Private Overloads Sub OnKeyboardAcceleratorInvoked(sender As KeyboardAccelerator, args As KeyboardAcceleratorInvokedEventArgs)
            Dim result = NavigationService.GoBack()
            args.Handled = result
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub [Set](Of T)(ByRef storage As T, value As T, <CallerMemberName> Optional propertyName As String = Nothing)
            If Equals(storage, value) Then
                Return
            End If

            storage = value
            OnPropertyChanged(propertyName)
        End Sub

        Private Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
