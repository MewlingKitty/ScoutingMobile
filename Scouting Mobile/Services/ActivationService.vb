Imports Scouting_Mobile.Activation
Imports Scouting_Mobile.Core.Helpers
Imports Scouting_Mobile.Core.Services

Imports Windows.System
Imports Windows.UI.Core

Namespace Services
    ' For more information on understanding and extending activation flow see
    ' https://github.com/Microsoft/WindowsTemplateStudio/blob/master/docs/activation.md
    Friend Class ActivationService
        Private ReadOnly _app As App
        Private ReadOnly _defaultNavItem As Type
        Private _shell As Lazy(Of UIElement)

        Private _lastActivationArgs As Object


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


        Public Sub New(app As App, defaultNavItem As Type, Optional shell As Lazy(Of UIElement) = Nothing)
            _app = app
            _shell = shell
            _defaultNavItem = defaultNavItem
        End Sub

        Public Async Function ActivateAsync(activationArgs As Object) As Task
            If IsInteractive(activationArgs) Then
                ' Initialize services that you need before app activation
                ' take into account that the splash screen is shown while this code runs.
                Await InitializeAsync()
                UserDataService.Initialize()
                IdentityService.InitializeWithAadAndPersonalMsAccounts()
                Await IdentityService.AcquireTokenSilentAsync()

                ' Do not repeat app initialization when the Window already has content,
                ' just ensure that the window is active
                If Window.Current.Content Is Nothing Then
                    ' Create a Shell or Frame to act as the navigation context
                    Window.Current.Content = If(_shell?.Value, New Frame())
                End If
            End If

            ' Depending on activationArgs one of ActivationHandlers or DefaultActivationHandler
            ' will navigate to the first page
            Await HandleActivationAsync(activationArgs)
            _lastActivationArgs = activationArgs

            If IsInteractive(activationArgs) Then
                ' Ensure the current window is active
                Window.Current.Activate()

                ' Tasks after activation
                Await StartupAsync()
            End If
        End Function

        Private Async Function InitializeAsync() As Task
            Await Singleton(Of LiveTileService).Instance.EnableQueueAsync().ConfigureAwait(False)
            Await ThemeSelectorService.InitializeAsync()
        End Function

        Private Async Function HandleActivationAsync(activationArgs As Object) As Task
            Dim activationHandler = GetActivationHandlers().FirstOrDefault(Function(h) h.CanHandle(activationArgs))

            If activationHandler IsNot Nothing Then
                Await activationHandler.HandleAsync(activationArgs)
            End If

            If IsInteractive(activationArgs) Then
                Dim defaultHandler = New DefaultActivationHandler(_defaultNavItem)

                If defaultHandler.CanHandle(activationArgs) Then
                    Await defaultHandler.HandleAsync(activationArgs)
                End If
            End If
        End Function

        Private Async Function StartupAsync() As Task
            Await ThemeSelectorService.SetRequestedThemeAsync()
            Singleton(Of LiveTileService).Instance.SampleUpdate()
            Await FirstRunDisplayService.ShowIfAppropriateAsync()
            Await WhatsNewDisplayService.ShowIfAppropriateAsync()
        End Function

        Private Iterator Function GetActivationHandlers() As IEnumerable(Of ActivationHandler)
            yield Singleton(Of LiveTileService).Instance
            yield Singleton(Of ToastNotificationsService).Instance
            yield Singleton(Of ShareTargetActivationHandler).Instance
        End Function

        Private Function IsInteractive(args As Object) As Boolean
            Return TypeOf args Is IActivatedEventArgs
        End Function

        Friend Async Function ActivateFromShareTargetAsync(activationArgs As ShareTargetActivatedEventArgs) As Task
            Dim shareTargetHandler = GetActivationHandlers().FirstOrDefault(Function(h) h.CanHandle(activationArgs))
            If shareTargetHandler IsNot Nothing Then
                Await shareTargetHandler.HandleAsync(activationArgs)
            End If
        End Function
    End Class
End Namespace
