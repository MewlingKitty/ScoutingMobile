﻿#ExternalChecksum("C:\Users\ncd39\source\repos\Scouting Mobile\Views\ShellPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "5B08BFB6C75FCD391FD4284A265406A8")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.Scouting_Mobile.Views

    Partial Class ShellPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Class XamlBindingSetters
            Public Shared Sub Set_Microsoft_UI_Xaml_Controls_NavigationView_IsBackEnabled(obj As Global.Microsoft.UI.Xaml.Controls.NavigationView, value As Global.System.Boolean)
                obj.IsBackEnabled = value
            End Sub
            Public Shared Sub Set_Microsoft_UI_Xaml_Controls_NavigationView_SelectedItem(obj As Global.Microsoft.UI.Xaml.Controls.NavigationView, value As Global.System.Object, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = DirectCast(Global.Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(GetType(Global.System.Object), targetNullValue), Global.System.Object)
                End If
                obj.SelectedItem = value
            End Sub
            Public Shared Sub Set_Scouting_Mobile_Behaviors_NavigationViewHeaderBehavior_DefaultHeader(obj As Global.Scouting_Mobile.Behaviors.NavigationViewHeaderBehavior, value As Global.System.Object, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = DirectCast(Global.Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(GetType(Global.System.Object), targetNullValue), Global.System.Object)
                End If
                obj.DefaultHeader = value
            End Sub
            Public Shared Sub Set_Windows_UI_Xaml_Controls_Control_IsEnabled(obj As Global.Windows.UI.Xaml.Controls.Control, value As Global.System.Boolean)
                obj.IsEnabled = value
            End Sub
            Public Shared Sub Set_Windows_UI_Xaml_UIElement_Visibility(obj As Global.Windows.UI.Xaml.UIElement, value As Global.Windows.UI.Xaml.Visibility)
                obj.Visibility = value
            End Sub
            Public Shared Sub Set_Windows_UI_Xaml_Controls_TextBlock_Text(obj As Global.Windows.UI.Xaml.Controls.TextBlock, value As Global.System.String, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = targetNullValue
                End If
                obj.Text = If (value, Global.System.String.Empty)
            End Sub
            Public Shared Sub Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(obj As Global.Windows.UI.Xaml.Media.ImageBrush, value As Global.Windows.UI.Xaml.Media.ImageSource, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = DirectCast(Global.Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(GetType(Global.Windows.UI.Xaml.Media.ImageSource), targetNullValue), Global.Windows.UI.Xaml.Media.ImageSource)
                End If
                obj.ImageSource = value
            End Sub
        End Class


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Class ShellPage_obj1_Bindings
            Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent
            Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics
            Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
            Implements IShellPage_Bindings

            Private dataRoot As Global.Scouting_Mobile.Views.ShellPage
            Private initialized As Boolean = False
            Private Const NOT_PHASED As Integer = 1 << 31
            Private Const DATA_CHANGED As Integer = 1 << 30
            Private localResources As Global.Windows.UI.Xaml.ResourceDictionary
            Private converterLookupRoot As Global.System.WeakReference(Of Global.Windows.UI.Xaml.FrameworkElement)

            ' Fields for each control that has bindings.
            Private obj4 As Global.Microsoft.UI.Xaml.Controls.NavigationView
            Private obj5 As Global.Scouting_Mobile.Behaviors.NavigationViewHeaderBehavior
            Private obj7 As Global.Windows.UI.Xaml.Controls.Button
            Private obj8 As Global.Windows.UI.Xaml.Controls.Button
            Private obj9 As Global.Windows.UI.Xaml.Controls.TextBlock
            Private obj10 As Global.Windows.UI.Xaml.Controls.TextBlock
            Private obj11 As Global.Windows.UI.Xaml.Media.ImageBrush

            Private bindingsTracking As ShellPage_obj1_BindingsTracking

            ' Static fields for each binding's enabled/disabled state
            Private Shared isobj4IsBackEnabledDisabled As Boolean = False
            Private Shared isobj4SelectedItemDisabled As Boolean = False
            Private Shared isobj5DefaultHeaderDisabled As Boolean = False
            Private Shared isobj7IsEnabledDisabled As Boolean = False
            Private Shared isobj7VisibilityDisabled As Boolean = False
            Private Shared isobj8IsEnabledDisabled As Boolean = False
            Private Shared isobj8VisibilityDisabled As Boolean = False
            Private Shared isobj9VisibilityDisabled As Boolean = False
            Private Shared isobj10TextDisabled As Boolean = False
            Private Shared isobj10VisibilityDisabled As Boolean = False
            Private Shared isobj11ImageSourceDisabled As Boolean = False

            Public Sub New()
                Me.bindingsTracking = New ShellPage_obj1_BindingsTracking(Me)
            End Sub
            
            Public Sub Disable(lineNumber As Integer, columnNumber As Integer) Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics.Disable
                If (lineNumber = 24 And columnNumber = 9) Then
                    isobj4IsBackEnabledDisabled = True
                ElseIf (lineNumber = 25 And columnNumber = 9) Then
                    isobj4SelectedItemDisabled = True
                ElseIf (lineNumber = 45 And columnNumber = 17) Then
                    isobj5DefaultHeaderDisabled = True
                ElseIf (lineNumber = 64 And columnNumber = 21) Then
                    isobj7IsEnabledDisabled = True
                ElseIf (lineNumber = 65 And columnNumber = 21) Then
                    isobj7VisibilityDisabled = True
                ElseIf (lineNumber = 95 And columnNumber = 21) Then
                    isobj8IsEnabledDisabled = True
                ElseIf (lineNumber = 96 And columnNumber = 21) Then
                    isobj8VisibilityDisabled = True
                ElseIf (lineNumber = 119 And columnNumber = 29) Then
                    isobj9VisibilityDisabled = True
                ElseIf (lineNumber = 85 And columnNumber = 29) Then
                    isobj10TextDisabled = True
                ElseIf (lineNumber = 88 And columnNumber = 29) Then
                    isobj10VisibilityDisabled = True
                ElseIf (lineNumber = 80 And columnNumber = 45) Then
                    isobj11ImageSourceDisabled = True
                End If
            End Sub

            ' IComponentConnector

            Public Sub Connect(connectionId As Integer, target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
                Select Case connectionId
                    Case 4: ' Views\ShellPage.xaml line 21                        
                        Me.obj4 = DirectCast(target, Global.Microsoft.UI.Xaml.Controls.NavigationView)
                        Exit Select
                    Case 5: ' Views\ShellPage.xaml line 44                        
                        Me.obj5 = DirectCast(target, Global.Scouting_Mobile.Behaviors.NavigationViewHeaderBehavior)
                        Exit Select
                    Case 7: ' Views\ShellPage.xaml line 60                        
                        Me.obj7 = DirectCast(target, Global.Windows.UI.Xaml.Controls.Button)
                        Exit Select
                    Case 8: ' Views\ShellPage.xaml line 91                        
                        Me.obj8 = DirectCast(target, Global.Windows.UI.Xaml.Controls.Button)
                        Exit Select
                    Case 9: ' Views\ShellPage.xaml line 114                        
                        Me.obj9 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case 10: ' Views\ShellPage.xaml line 83                        
                        Me.obj10 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case 11: ' Views\ShellPage.xaml line 80                        
                        Me.obj11 = DirectCast(target, Global.Windows.UI.Xaml.Media.ImageBrush)
                        Exit Select
                    Case Else
                        Exit Select
                End Select
            End Sub

            ' IDataTemplateComponent

            Public Sub ProcessBindings(item As Global.System.Object, itemIndex As Integer, phase As Integer, ByRef nextPhase As Integer) Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent.ProcessBindings
                nextPhase = -1
            End Sub
            
            Public Sub Recycle() Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent.Recycle
                Exit Sub
            End Sub

            ' IShellPage_Bindings
            Public Sub Initialize() Implements IShellPage_Bindings.Initialize
                If Not Me.initialized Then
                    Me.Update()
                End If
            End Sub
            
            Public Sub Update() Implements IShellPage_Bindings.Update
                Me.Update_(Me.dataRoot, NOT_PHASED)
                Me.initialized = True
            End Sub

            Public Sub StopTracking() Implements IShellPage_Bindings.StopTracking
                Me.bindingsTracking.ReleaseAllListeners()
                Me.initialized = False
            End Sub

            Public Sub DisconnectUnloadedObject(connectionId As Integer) Implements IShellPage_Bindings.DisconnectUnloadedObject
                Throw New Global.System.ArgumentException("No unloadable elements to disconnect.")
            End Sub

            Public Function SetDataRoot(newDataRoot As Global.System.Object)
                Me.bindingsTracking.ReleaseAllListeners()
                If Not newDataRoot Is Nothing Then
                    Me.dataRoot = DirectCast(newDataRoot, Global.Scouting_Mobile.Views.ShellPage)
                    Return True
                End If
                Return False
            End Function

            Public Sub Loading(src As Global.Windows.UI.Xaml.FrameworkElement, data As object)
                Me.Initialize()
            End Sub
            Public Sub SetConverterLookupRoot(rootElement As Global.Windows.UI.Xaml.FrameworkElement)
                Me.converterLookupRoot = New Global.System.WeakReference(Of Global.Windows.UI.Xaml.FrameworkElement)(rootElement)
            End Sub

            Public Function LookupConverter(key As string) As Global.Windows.UI.Xaml.Data.IValueConverter
                If (Me.localResources Is Nothing)
                    Dim rootElement As Global.Windows.UI.Xaml.FrameworkElement = Nothing
                    Me.converterLookupRoot.TryGetTarget(rootElement)
                    Me.localResources = rootElement.Resources
                    Me.converterLookupRoot = Nothing
                End If
                Return DirectCast( If( Me.localResources.ContainsKey(key), Me.localResources(key), Global.Windows.UI.Xaml.Application.Current.Resources(key)), Global.Windows.UI.Xaml.Data.IValueConverter)
            End Function

            ' Update methods for each path node used in binding steps.
            Private Sub Update_(obj As Global.Scouting_Mobile.Views.ShellPage, phase As Integer)
                Me.bindingsTracking.UpdateChildListeners_(obj)
                If obj IsNot Nothing Then
                    If (phase And (NOT_PHASED Or DATA_CHANGED Or (1 << 0))) <> 0 Then
                        Me.Update_IsBackEnabled(obj.IsBackEnabled, phase)
                        Me.Update_Selected(obj.Selected, phase)
                        Me.Update_IsBusy(obj.IsBusy, phase)
                        Me.Update_IsLoggedIn(obj.IsLoggedIn, phase)
                        Me.Update_User(obj.User, phase)
                    End If
                End If
            End Sub
            Private Sub Update_IsBackEnabled(obj As Global.System.Boolean, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj4IsBackEnabledDisabled = False Then
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_NavigationView_IsBackEnabled(Me.obj4, obj)
                    End If
                End If
            End Sub
            Private Sub Update_Selected(obj As Global.Microsoft.UI.Xaml.Controls.NavigationViewItem, phase As Integer)
                Me.bindingsTracking.UpdateChildListeners_Selected(obj)
                If obj IsNot Nothing Then
                    If (phase And (NOT_PHASED Or DATA_CHANGED Or (1 << 0))) <> 0 Then
                        Me.Update_Selected_Content(obj.Content, phase)
                    End If
                End If
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj4SelectedItemDisabled = False Then
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_NavigationView_SelectedItem(Me.obj4, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_Selected_Content(obj As Global.System.Object, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj5DefaultHeaderDisabled = False Then
                        XamlBindingSetters.Set_Scouting_Mobile_Behaviors_NavigationViewHeaderBehavior_DefaultHeader(Me.obj5, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_IsBusy(obj As Global.System.Boolean, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj7IsEnabledDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(Me.obj7, DirectCast(Me.LookupConverter("BoolNegationConverter").Convert(obj, GetType(Global.System.Boolean), Nothing, Nothing),Global.System.Boolean))
                    End If
                    If isobj8IsEnabledDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(Me.obj8, DirectCast(Me.LookupConverter("BoolNegationConverter").Convert(obj, GetType(Global.System.Boolean), Nothing, Nothing),Global.System.Boolean))
                    End If
                End If
            End Sub
            Private Sub Update_IsLoggedIn(obj As Global.System.Boolean, phase As Integer)
                If (phase And (NOT_PHASED Or DATA_CHANGED Or (1 << 0))) <> 0 Then
                    Me.Update_IsLoggedIn_Cast_IsLoggedIn_To_Visibility(If(obj, Global.Windows.UI.Xaml.Visibility.Visible, Global.Windows.UI.Xaml.Visibility.Collapsed), phase)
                End If
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj8VisibilityDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(Me.obj8, DirectCast(Me.LookupConverter("ReverseBoolToVisibility").Convert(obj, GetType(Global.Windows.UI.Xaml.Visibility), Nothing, Nothing),Global.Windows.UI.Xaml.Visibility))
                    End If
                    If isobj9VisibilityDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(Me.obj9, DirectCast(Me.LookupConverter("ReverseBoolToVisibility").Convert(obj, GetType(Global.Windows.UI.Xaml.Visibility), Nothing, Nothing),Global.Windows.UI.Xaml.Visibility))
                    End If
                End If
            End Sub
            Private Sub Update_IsLoggedIn_Cast_IsLoggedIn_To_Visibility(obj As Global.Windows.UI.Xaml.Visibility, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj7VisibilityDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(Me.obj7, obj)
                    End If
                    If isobj10VisibilityDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(Me.obj10, obj)
                    End If
                End If
            End Sub
            Private Sub Update_User(obj As Global.Scouting_Mobile.Models.UserData, phase As Integer)
                If obj IsNot Nothing Then
                    If (phase And (NOT_PHASED Or DATA_CHANGED Or (1 << 0))) <> 0 Then
                        Me.Update_User_Name(obj.Name, phase)
                        Me.Update_User_Photo(obj.Photo, phase)
                    End If
                End If
            End Sub
            Private Sub Update_User_Name(obj As Global.System.String, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj10TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj10, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_User_Photo(obj As Global.Windows.UI.Xaml.Media.Imaging.BitmapImage, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj11ImageSourceDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(Me.obj11, obj, Nothing)
                    End If
                End If
            End Sub

            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
            Private Class ShellPage_obj1_BindingsTracking
                Private weakRefToBindingObj As Global.System.WeakReference(Of ShellPage_obj1_Bindings) = Nothing

                Public Sub New(obj As ShellPage_obj1_Bindings)
                    weakRefToBindingObj = New Global.System.WeakReference(Of ShellPage_obj1_Bindings)(obj)
                End Sub

                Private Function TryGetBindingObject() As ShellPage_obj1_Bindings
                    Dim bindingObject As ShellPage_obj1_Bindings = Nothing
                    if weakRefToBindingObj IsNot Nothing Then
                        weakRefToBindingObj.TryGetTarget(bindingObject)
                        If bindingObject Is Nothing Then
                            weakRefToBindingObj = Nothing
                            ReleaseAllListeners()
                        End If
                    End If
                    return bindingObject
                End Function

                Public Sub ReleaseAllListeners()
                    UpdateChildListeners_(Nothing)
                    UpdateChildListeners_Selected(Nothing)
                End Sub

                Public Sub PropertyChanged_(sender As object, e As Global.System.ComponentModel.PropertyChangedEventArgs)
                    Dim bindings As ShellPage_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        Dim propName As String = e.PropertyName
                        Dim obj As Global.Scouting_Mobile.Views.ShellPage = TryCast(sender, Global.Scouting_Mobile.Views.ShellPage)
                        If Global.System.String.IsNullOrEmpty(propName) Then
                            If obj IsNot Nothing Then
                                bindings.Update_IsBackEnabled(obj.IsBackEnabled, DATA_CHANGED)
                                bindings.Update_Selected(obj.Selected, DATA_CHANGED)
                                bindings.Update_IsBusy(obj.IsBusy, DATA_CHANGED)
                                bindings.Update_IsLoggedIn(obj.IsLoggedIn, DATA_CHANGED)
                                bindings.Update_User(obj.User, DATA_CHANGED)
                            End If
                        Else
                            Select Case propName
                                Case "IsBackEnabled":
                                    If obj IsNot Nothing Then
                                        bindings.Update_IsBackEnabled(obj.IsBackEnabled, DATA_CHANGED)
                                    End If
                                    Exit Select
                                Case "Selected":
                                    If obj IsNot Nothing Then
                                        bindings.Update_Selected(obj.Selected, DATA_CHANGED)
                                    End If
                                    Exit Select
                                Case "IsBusy":
                                    If obj IsNot Nothing Then
                                        bindings.Update_IsBusy(obj.IsBusy, DATA_CHANGED)
                                    End If
                                    Exit Select
                                Case "IsLoggedIn":
                                    If obj IsNot Nothing Then
                                        bindings.Update_IsLoggedIn(obj.IsLoggedIn, DATA_CHANGED)
                                    End If
                                    Exit Select
                                Case "User":
                                    If obj IsNot Nothing Then
                                        bindings.Update_User(obj.User, DATA_CHANGED)
                                    End If
                                    Exit Select
                                Case Else
                                    Exit Select
                            End Select
                        End If
                    End If
                End Sub
                Public Sub UpdateChildListeners_(obj As Global.Scouting_Mobile.Views.ShellPage)
                    Dim bindings As ShellPage_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        If bindings.dataRoot IsNot Nothing Then
                            RemoveHandler DirectCast(bindings.dataRoot,Global.System.ComponentModel.INotifyPropertyChanged).PropertyChanged, AddressOf PropertyChanged_
                        End If
                        If obj IsNot Nothing Then
                            bindings.dataRoot = obj
                            AddHandler DirectCast(obj, Global.System.ComponentModel.INotifyPropertyChanged).PropertyChanged, AddressOf PropertyChanged_
                        End If
                    End If
                End Sub
                Public Sub DependencyPropertyChanged_Selected_Content(sender As Global.Windows.UI.Xaml.DependencyObject, prop As Global.Windows.UI.Xaml.DependencyProperty)
                    Dim bindings As ShellPage_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        Dim obj As Global.Microsoft.UI.Xaml.Controls.NavigationViewItem = TryCast(sender, Global.Microsoft.UI.Xaml.Controls.NavigationViewItem)
                        If obj IsNot Nothing Then
                            bindings.Update_Selected_Content(obj.Content, DATA_CHANGED)
                        End If
                    End If
                End Sub
                Private cache_Selected As Global.Microsoft.UI.Xaml.Controls.NavigationViewItem = Nothing
                Private tokenDPC_Selected_Content As Long = 0
                Public Sub UpdateChildListeners_Selected(obj As Global.Microsoft.UI.Xaml.Controls.NavigationViewItem)
                    If obj IsNot cache_Selected Then
                        If cache_Selected IsNot Nothing Then
                            cache_Selected.UnregisterPropertyChangedCallback(Global.Windows.UI.Xaml.Controls.ContentControl.ContentProperty, tokenDPC_Selected_Content)
                            cache_Selected = Nothing
                        End If
                        If obj IsNot Nothing Then
                            cache_Selected = obj
                            tokenDPC_Selected_Content = obj.RegisterPropertyChangedCallback(Global.Windows.UI.Xaml.Controls.ContentControl.ContentProperty, AddressOf DependencyPropertyChanged_Selected_Content)
                        End If
                    End If
                End Sub
            End Class
        End Class

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionId
            Case 1 ' Views\ShellPage.xaml line 1
                    Dim element1 As Global.Windows.UI.Xaml.Controls.Page = CType(target, Global.Windows.UI.Xaml.Controls.Page)
                AddHandler DirectCast(element1, Global.Windows.UI.Xaml.Controls.Page).Loaded, AddressOf Me.OnLoaded
                    Exit Select
            Case 2 ' Views\ShellPage.xaml line 17
                    Me.ReverseBoolToVisibility = CType(target, Global.Microsoft.Toolkit.Uwp.UI.Converters.BoolToVisibilityConverter)
                    Exit Select
            Case 3 ' Views\ShellPage.xaml line 18
                    Me.BoolNegationConverter = CType(target, Global.Microsoft.Toolkit.Uwp.UI.Converters.BoolNegationConverter)
                    Exit Select
            Case 4 ' Views\ShellPage.xaml line 21
                    Me.navigationView = CType(target, Global.Microsoft.UI.Xaml.Controls.NavigationView)
                AddHandler DirectCast(Me.navigationView, Global.Microsoft.UI.Xaml.Controls.NavigationView).ItemInvoked, AddressOf Me.OnItemInvoked
                    Exit Select
            Case 7 ' Views\ShellPage.xaml line 60
                    Dim element7 As Global.Windows.UI.Xaml.Controls.Button = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                AddHandler DirectCast(element7, Global.Windows.UI.Xaml.Controls.Button).Click, AddressOf Me.OnUserProfile
                    Exit Select
            Case 8 ' Views\ShellPage.xaml line 91
                    Dim element8 As Global.Windows.UI.Xaml.Controls.Button = CType(target, Global.Windows.UI.Xaml.Controls.Button)
                AddHandler DirectCast(element8, Global.Windows.UI.Xaml.Controls.Button).Click, AddressOf Me.OnUserProfile
                    Exit Select
            Case 12 ' Views\ShellPage.xaml line 125
                    Me.shellFrame = CType(target, Global.Windows.UI.Xaml.Controls.Frame)
                    Exit Select
                    Case Else
                        Exit Select
            End Select
                Me._contentLoaded = true
        End Sub

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetBindingConnector(connectionId As Integer, target As Object) As Global.Windows.UI.Xaml.Markup.IComponentConnector Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2.GetBindingConnector
            Dim returnValue As Global.Windows.UI.Xaml.Markup.IComponentConnector = Nothing
            Select Case connectionId
               Case 1: ' Views\ShellPage.xaml line 1
                    Dim element1 As Global.Windows.UI.Xaml.Controls.Page = CType(target, Global.Windows.UI.Xaml.Controls.Page)
                    Dim bindings As ShellPage_obj1_Bindings = New ShellPage_obj1_Bindings()
                    returnValue = bindings
                    bindings.SetDataRoot(Me)
                    bindings.SetConverterLookupRoot(Me)
                    Me.Bindings = bindings
                    AddHandler element1.Loading, AddressOf bindings.Loading
                    Global.Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings)
                    Exit Select
            End Select
            Return returnValue
        End Function
    End Class

End Namespace

