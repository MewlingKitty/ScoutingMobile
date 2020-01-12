Imports Scouting_Mobile.Core.Helpers
Imports Scouting_Mobile.Core.Services
Imports Scouting_Mobile.Helpers
Imports Scouting_Mobile.Models
Imports Scouting_Mobile.Services

Namespace Views
    ' TODO WTS: Add other settings as necessary. For help see https://github.com/Microsoft/WindowsTemplateStudio/blob/master/docs/pages/settings-codebehind.vb.md
    ' TODO WTS: Change the URL for your privacy policy in the Resource File, currently set to https://YourPrivacyUrlGoesHere
    Public NotInheritable Partial Class SettingsPage
        Inherits Page
        Implements INotifyPropertyChanged

        Private ReadOnly Property UserDataService As UserDataService
            Get
                Return Singleton(Of UserDataService).Instance
            End Get
        End Property

        Private ReadOnly Property IdentityService As IdentityService
            Get
                Return Singleton(Of IdentityService).Instance
            End Get
        End Property


        Private _elementTheme As ElementTheme = ThemeSelectorService.Theme
        Private _isLoggedIn As Boolean
        Private _isBusy As Boolean
        Private _user As UserData

        Public Property ElementTheme As ElementTheme
            Get
                Return _elementTheme
            End Get

            Set
                [Set](_elementTheme, value)
            End Set
        End Property

        Private _versionDescription As String

        Public Property VersionDescription As String
            Get
                Return _versionDescription
            End Get

            Set
                [Set](_versionDescription, value)
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

        Public Property IsBusy As Boolean
            Get
                Return _isBusy
            End Get
            Set(value As Boolean)
                [Set](_isBusy, value)
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


        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Async Sub OnNavigatedTo(e As NavigationEventArgs)
            Await InitializeAsync()
        End Sub

        Public Async Function InitializeAsync() As Task
            VersionDescription = GetVersionDescription()
            AddHandler IdentityService.LoggedIn, AddressOf OnLoggedIn
            AddHandler IdentityService.LoggedOut, AddressOf OnLoggedOut
            AddHandler UserDataService.UserDataUpdated, AddressOf OnUserDataUpdated
            IsLoggedIn = IdentityService.IsLoggedIn()
            User = Await UserDataService.GetUserAsync()
        End Function

        Private Function GetVersionDescription() As String
            Dim appName = "AppDisplayName".GetLocalized()
            Dim package = Windows.ApplicationModel.Package.Current
            Dim packageId = package.Id
            Dim version = packageId.Version

            Return $"{appName} - {version.Major}.{version.Minor}.{version.Build}.{version.Revision}"
        End Function

        Private Async Sub ThemeChanged_CheckedAsync(sender As Object, e As RoutedEventArgs)
            Dim param = TryCast(sender, RadioButton)

            If param IsNot Nothing AndAlso param.CommandParameter IsNot Nothing Then
                Await ThemeSelectorService.SetThemeAsync(DirectCast(param.CommandParameter, ElementTheme))
            End If

            If Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.IsSupported() Then
                FeedbackLink.Visibility = Visibility.Visible
            End If
        End Sub


        Private Sub OnUserDataUpdated(sender As Object, userData As UserData)
            User = userData
        End Sub

        Private Async Sub OnLogIn(sender As Object, e As RoutedEventArgs)
            IsBusy = True
            Dim loginResult = Await IdentityService.LoginAsync()

            If loginResult <> LoginResultType.Success Then
                Await AuthenticationHelper.ShowLoginErrorAsync(loginResult)
                IsBusy = False
            End If
        End Sub

        Private Async Sub OnLogOut(sender As Object, e As RoutedEventArgs)
            IsBusy = True
            Await IdentityService.LogoutAsync()
        End Sub

        Private Sub OnLoggedIn(sender As Object, e As EventArgs)
            IsLoggedIn = True
            IsBusy = False
        End Sub

        Private Sub OnLoggedOut(sender As Object, e As EventArgs)
            User = Nothing
            IsLoggedIn = False
            IsBusy = False
        End Sub

        Protected Overrides Sub OnNavigatingFrom(e As NavigatingCancelEventArgs)
            MyBase.OnNavigatingFrom(e)
            RemoveHandler IdentityService.LoggedIn, AddressOf OnLoggedIn
            RemoveHandler IdentityService.LoggedOut, AddressOf OnLoggedOut
            RemoveHandler UserDataService.UserDataUpdated, AddressOf OnUserDataUpdated
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

        Private Async Sub FeedbackLink_Click(sender As Object, e As RoutedEventArgs)
            ' This launcher is part of the Store Services SDK https://docs.microsoft.com/windows/uwp/monetize/microsoft-store-services-sdk
            Dim launcher = Microsoft.Services.Store.Engagement.StoreServicesFeedbackLauncher.GetDefault()
            Await launcher.LaunchAsync()
        End Sub
    End Class
End Namespace
