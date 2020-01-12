﻿Imports Scouting_Mobile.Services

NotInheritable Partial Class App
    Inherits Application

    Private _activationService As Lazy(Of ActivationService)

    Private ReadOnly Property ActivationService As ActivationService
        Get
            Return _activationService.Value
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        ' Deferred execution until used. Check https://msdn.microsoft.com/library/dd642331(v=vs.110).aspx for further info on Lazy<T> class.
        _activationService = New Lazy(Of ActivationService)(AddressOf CreateActivationService)
    End Sub

    Protected Overrides Async Sub OnLaunched(args As LaunchActivatedEventArgs)
        If Not args.PrelaunchActivated Then
            Await ActivationService.ActivateAsync(args)
        End If
    End Sub

    Protected Overrides Async Sub OnActivated(args As IActivatedEventArgs)
        Await ActivationService.ActivateAsync(args)
    End Sub

    Private Function CreateActivationService() As ActivationService
        Return New ActivationService(Me, GetType(Views.MainPage), New Lazy(Of UIElement)(AddressOf CreateShell))
    End Function

    Private Function CreateShell() As UIElement
        Return New Views.ShellPage()
    End Function

    Protected Overrides Async Sub OnShareTargetActivated(args As ShareTargetActivatedEventArgs)
        Await ActivationService.ActivateFromShareTargetAsync(args)
    End Sub
End Class
