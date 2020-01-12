Imports Microsoft.Toolkit.Uwp.Notifications

Imports Windows.UI.Notifications

Namespace Services
    Friend Partial Class ToastNotificationsService
        Public Sub ShowToastNotificationSample()
            ' Create the toast content
            Dim visual = New ToastVisual
            visual.BindingGeneric = New ToastBindingGeneric
            visual.BindingGeneric.Children.Add(New AdaptiveText() With {.Text = "Sample Notification"})
            visual.BindingGeneric.Children.Add(New AdaptiveText() With {.Text = "I'm not even sure why this exists, but might prove useful later."})

            ' More about Toast Buttons at https://docs.microsoft.com/dotnet/api/microsoft.toolkit.uwp.notifications.toastbutton
            Dim actions = New ToastActionsCustom()
            actions.Buttons.Add(New ToastButton("OK", "ToastButtonActivationArguments") With { .ActivationType = ToastActivationType.Foreground })

            ' More about the Launch property at https://docs.microsoft.com/dotnet/api/microsoft.toolkit.uwp.notifications.toastcontent
            Dim content = New ToastContent()
            content.Launch = "ToastContentActivationParams"
            content.Visual = visual
            content.Actions = actions

            ' Add the content to the toast
            ' TODO WTS: Set a unique identifier for this notification within the notification group. (optional)
            ' More details at https://docs.microsoft.com/uwp/api/windows.ui.notifications.toastnotification.tag
            Dim toast = New ToastNotification(content.GetXml()) With { .Tag = "ToastTag" }

            ' And show the toast
            ShowToastNotification(toast)
        End Sub
    End Class
End Namespace
