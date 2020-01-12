Imports Scouting_Mobile.Core.Helpers
Imports Scouting_Mobile.Services

Namespace Activation
    Friend Class DefaultActivationHandler
        Inherits ActivationHandler(Of IActivatedEventArgs)

        Private ReadOnly _navElement As Type

        Public Sub New(navElement As Type)
            _navElement = navElement
        End Sub

        Protected Overrides Async Function HandleInternalAsync(args As IActivatedEventArgs) As Task
            ' When the navigation stack isn't restored, navigate to the first page and configure
            ' the new page by passing required information in the navigation parameter
            Dim arguments As Object = Nothing
            Dim launchArgs = TryCast(args, LaunchActivatedEventArgs)
            If launchArgs IsNot Nothing Then
                arguments = launchArgs.Arguments
            End If

            NavigationService.Navigate(_navElement, arguments)

            ' TODO WTS: Remove or change this sample which shows a toast notification when the app is launched.
            ' You can use this sample to create toast notifications where needed in your app.
            Singleton(Of ToastNotificationsService).Instance.ShowToastNotificationSample()
            Await Task.CompletedTask
        End Function

        Protected Overrides Function CanHandleInternal(args As IActivatedEventArgs) As Boolean
            ' None of the ActivationHandlers has handled the app activation
            Return NavigationService.Frame.Content Is Nothing
        End Function
    End Class
End Namespace
