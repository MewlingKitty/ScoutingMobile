﻿Imports Scouting_Mobile.Behaviors
Imports Scouting_Mobile.Helpers
Imports Scouting_Mobile.Services.Ink

Imports Windows.Storage
Imports Windows.UI.Xaml.Data

Namespace Views
    ' For more information regarding Windows Ink documentation and samples see https://github.com/Microsoft/WindowsTemplateStudio/blob/master/docs/pages/ink.md
    Public NotInheritable Partial Class InkDrawPicturePage
        Inherits Page
        Implements INotifyPropertyChanged

        Private _touchInkingButtonIsChecked As Boolean = True
        Private _mouseInkingButtonIsChecked As Boolean = True
        Private _saveImageButtonIsEnabled As Boolean
        Private _clearAllButtonIsEnabled As Boolean
        Private imageFile As StorageFile
        Private strokesService As InkStrokesService
        Private pointerDeviceService As InkPointerDeviceService
        Private fileService As InkFileService
        Private zoomService As InkZoomService

        Public Sub New()
            InitializeComponent()
            SetNavigationViewHeaderContext()
            SetNavigationViewHeaderTemplate()
            AddHandler Loaded, Sub(sender, eventArgs)
                                    SetCanvasSize()
                                    AddHandler image.SizeChanged, AddressOf Image_SizeChanged
                                    strokesService = New InkStrokesService(inkCanvas.InkPresenter)
                                    pointerDeviceService = New InkPointerDeviceService(inkCanvas)
                                    fileService = New InkFileService(inkCanvas, strokesService)
                                    zoomService = New InkZoomService(canvasScroll)
                                    AddHandler strokesService.StrokesCollected, Sub(s, e) RefreshEnabledButtons()
                                    AddHandler strokesService.StrokesErased, Sub(s, e) RefreshEnabledButtons()
                                    AddHandler strokesService.ClearStrokesEvent, Sub(s, e) RefreshEnabledButtons()
                                    AddHandler pointerDeviceService.DetectPenEvent, Sub(s, e) TouchInkingButtonIsChecked = False
                                End Sub
        End Sub

        Private Sub OnInkToolbarLoaded(sender As Object, e As RoutedEventArgs)
            Dim inkToolbar As InkToolbar = TryCast(sender, InkToolbar)
            If inkToolbar IsNot Nothing Then
                inkToolbar.TargetInkCanvas = inkCanvas
            End If
        End Sub

        Private Sub VisualStateGroup_CurrentStateChanged(sender As Object, e As VisualStateChangedEventArgs)
            SetNavigationViewHeaderTemplate()
        End Sub

        Private Sub SetNavigationViewHeaderTemplate()
            If visualStateGroup.CurrentState IsNot Nothing Then

                Select Case visualStateGroup.CurrentState.Name
                    Case "BigVisualState"
                        NavigationViewHeaderBehavior.SetHeaderTemplate(Me, TryCast(Resources("BigHeaderTemplate"), DataTemplate))
                        bottomCommandBar.Visibility = Visibility.Collapsed
                    Case "SmallVisualState"
                        NavigationViewHeaderBehavior.SetHeaderTemplate(Me, TryCast(Resources("SmallHeaderTemplate"), DataTemplate))
                        bottomCommandBar.Visibility = Visibility.Visible
                End Select
            End If
        End Sub

        Private Sub SetNavigationViewHeaderContext()
            Dim headerContextBinding As Binding = new Binding()
            headerContextBinding.Source = Me
            headerContextBinding.Mode = BindingMode.OneWay

            SetBinding(NavigationViewHeaderBehavior.HeaderContextProperty, headerContextBinding)
        End Sub

        Public Property TouchInkingButtonIsChecked As Boolean
            Get
                Return _touchInkingButtonIsChecked
            End Get
            Set(value As Boolean)
                [Set](_touchInkingButtonIsChecked, value)
                pointerDeviceService.EnableTouch = value
            End Set
        End Property

        Public Property MouseInkingButtonIsChecked As Boolean
            Get
                Return _mouseInkingButtonIsChecked
            End Get
            Set(value As Boolean)
                [Set](_mouseInkingButtonIsChecked, value)
                pointerDeviceService.EnableMouse = value
            End Set
        End Property

        Public Property SaveImageButtonIsEnabled As Boolean
            Get
                Return _saveImageButtonIsEnabled
            End Get
            Set(value As Boolean)
                [Set](_saveImageButtonIsEnabled, value)
            End Set
        End Property

        Public Property ClearAllButtonIsEnabled As Boolean
            Get
                Return _clearAllButtonIsEnabled
            End Get
            Set(value As Boolean)
                [Set](_clearAllButtonIsEnabled, value)
            End Set
        End Property

        Private Sub SetCanvasSize()
            inkCanvas.Width = Math.Max(canvasScroll.ViewportWidth, 1000)
            inkCanvas.Height = Math.Max(canvasScroll.ViewportHeight, 1000)
        End Sub

        Private Sub Image_SizeChanged(sender As Object, e As SizeChangedEventArgs)
            If e.NewSize.Height = 0 OrElse e.NewSize.Width = 0 Then
                SetCanvasSize()
            Else
                inkCanvas.Width = e.NewSize.Width
                inkCanvas.Height = e.NewSize.Height
            End If
        End Sub

        Private Sub ZoomIn_Click(sender As Object, e As RoutedEventArgs)
            zoomService?.ZoomIn()
        End Sub

        Private Sub ZoomOut_Click(sender As Object, e As RoutedEventArgs)
            zoomService?.ZoomOut()
        End Sub

        Private Sub ResetZoom_Click(sender As Object, e As RoutedEventArgs)
            zoomService?.ResetZoom()
        End Sub

        Private Sub FitToScreen_Click(sender As Object, e As RoutedEventArgs)
            zoomService?.FitToScreen()
        End Sub

        Private Async Sub LoadImage_Click(sender As Object, e As RoutedEventArgs)
            Dim file = Await ImageHelper.LoadImageFileAsync()
            Dim bitmapImage = Await ImageHelper.GetBitmapFromImageAsync(file)

            If file IsNot Nothing AndAlso bitmapImage IsNot Nothing Then
                ClearAll()
                imageFile = file
                image.Source = bitmapImage
                zoomService?.FitToSize(bitmapImage.PixelWidth, bitmapImage.PixelHeight)
                RefreshEnabledButtons()
            End If
        End Sub

        Private Async Sub SaveImage_Click(sender As Object, e As RoutedEventArgs)
            Await fileService?.ExportToImageAsync(imageFile)
        End Sub

        Private Sub ClearAll_Click(sender As Object, e As RoutedEventArgs)
            ClearAll()
        End Sub

        Private Sub ClearAll()
            strokesService?.ClearStrokes()
            imageFile = Nothing
            image.Source = Nothing
            RefreshEnabledButtons()
        End Sub

        Private Sub RefreshEnabledButtons()
            SaveImageButtonIsEnabled = image.Source IsNot Nothing AndAlso strokesService.GetStrokes().Any()
            ClearAllButtonIsEnabled = image.Source IsNot Nothing OrElse strokesService.GetStrokes().Any()
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
