﻿#ExternalChecksum("C:\Users\ncd39\source\repos\Scouting Mobile\Views\MasterDetailDetailControl.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "4658AF03FD157B5A444265902238ED50")
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

    Partial Class MasterDetailDetailControl
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Class XamlBindingSetters
            Public Shared Sub Set_Windows_UI_Xaml_Controls_TextBlock_Text(obj As Global.Windows.UI.Xaml.Controls.TextBlock, value As Global.System.String, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = targetNullValue
                End If
                obj.Text = If (value, Global.System.String.Empty)
            End Sub
            Public Shared Sub Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(obj As Global.Windows.UI.Xaml.Controls.FontIcon, value As Global.System.String, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = targetNullValue
                End If
                obj.Glyph = If (value, Global.System.String.Empty)
            End Sub
        End Class


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Class MasterDetailDetailControl_obj1_Bindings
            Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent
            Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics
            Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
            Implements IMasterDetailDetailControl_Bindings

            Private dataRoot As Global.Scouting_Mobile.Views.MasterDetailDetailControl
            Private initialized As Boolean = False
            Private Const NOT_PHASED As Integer = 1 << 31
            Private Const DATA_CHANGED As Integer = 1 << 30

            ' Fields for each control that has bindings.
            Private obj4 As Global.Windows.UI.Xaml.Controls.TextBlock
            Private obj5 As Global.Windows.UI.Xaml.Controls.TextBlock
            Private obj6 As Global.Windows.UI.Xaml.Controls.TextBlock
            Private obj7 As Global.Windows.UI.Xaml.Controls.TextBlock
            Private obj8 As Global.Windows.UI.Xaml.Controls.TextBlock
            Private obj9 As Global.Windows.UI.Xaml.Controls.FontIcon
            Private obj10 As Global.Windows.UI.Xaml.Controls.TextBlock

            Private bindingsTracking As MasterDetailDetailControl_obj1_BindingsTracking

            ' Static fields for each binding's enabled/disabled state
            Private Shared isobj4TextDisabled As Boolean = False
            Private Shared isobj5TextDisabled As Boolean = False
            Private Shared isobj6TextDisabled As Boolean = False
            Private Shared isobj7TextDisabled As Boolean = False
            Private Shared isobj8TextDisabled As Boolean = False
            Private Shared isobj9GlyphDisabled As Boolean = False
            Private Shared isobj10TextDisabled As Boolean = False

            Public Sub New()
                Me.bindingsTracking = New MasterDetailDetailControl_obj1_BindingsTracking(Me)
            End Sub
            
            Public Sub Disable(lineNumber As Integer, columnNumber As Integer) Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics.Disable
                If (lineNumber = 31 And columnNumber = 79) Then
                    isobj4TextDisabled = True
                ElseIf (lineNumber = 36 And columnNumber = 79) Then
                    isobj5TextDisabled = True
                ElseIf (lineNumber = 41 And columnNumber = 79) Then
                    isobj6TextDisabled = True
                ElseIf (lineNumber = 46 And columnNumber = 79) Then
                    isobj7TextDisabled = True
                ElseIf (lineNumber = 51 And columnNumber = 79) Then
                    isobj8TextDisabled = True
                ElseIf (lineNumber = 22 And columnNumber = 21) Then
                    isobj9GlyphDisabled = True
                ElseIf (lineNumber = 26 And columnNumber = 21) Then
                    isobj10TextDisabled = True
                End If
            End Sub

            ' IComponentConnector

            Public Sub Connect(connectionId As Integer, target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
                Select Case connectionId
                    Case 4: ' Views\MasterDetailDetailControl.xaml line 31                        
                        Me.obj4 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case 5: ' Views\MasterDetailDetailControl.xaml line 36                        
                        Me.obj5 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case 6: ' Views\MasterDetailDetailControl.xaml line 41                        
                        Me.obj6 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case 7: ' Views\MasterDetailDetailControl.xaml line 46                        
                        Me.obj7 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case 8: ' Views\MasterDetailDetailControl.xaml line 51                        
                        Me.obj8 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case 9: ' Views\MasterDetailDetailControl.xaml line 18                        
                        Me.obj9 = DirectCast(target, Global.Windows.UI.Xaml.Controls.FontIcon)
                        Exit Select
                    Case 10: ' Views\MasterDetailDetailControl.xaml line 23                        
                        Me.obj10 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
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

            ' IMasterDetailDetailControl_Bindings
            Public Sub Initialize() Implements IMasterDetailDetailControl_Bindings.Initialize
                If Not Me.initialized Then
                    Me.Update()
                End If
            End Sub
            
            Public Sub Update() Implements IMasterDetailDetailControl_Bindings.Update
                Me.Update_(Me.dataRoot, NOT_PHASED)
                Me.initialized = True
            End Sub

            Public Sub StopTracking() Implements IMasterDetailDetailControl_Bindings.StopTracking
                Me.bindingsTracking.ReleaseAllListeners()
                Me.initialized = False
            End Sub

            Public Sub DisconnectUnloadedObject(connectionId As Integer) Implements IMasterDetailDetailControl_Bindings.DisconnectUnloadedObject
                Throw New Global.System.ArgumentException("No unloadable elements to disconnect.")
            End Sub

            Public Function SetDataRoot(newDataRoot As Global.System.Object)
                Me.bindingsTracking.ReleaseAllListeners()
                If Not newDataRoot Is Nothing Then
                    Me.dataRoot = DirectCast(newDataRoot, Global.Scouting_Mobile.Views.MasterDetailDetailControl)
                    Return True
                End If
                Return False
            End Function

            Public Sub Loading(src As Global.Windows.UI.Xaml.FrameworkElement, data As object)
                Me.Initialize()
            End Sub

            ' Update methods for each path node used in binding steps.
            Private Sub Update_(obj As Global.Scouting_Mobile.Views.MasterDetailDetailControl, phase As Integer)
                Me.bindingsTracking.UpdateChildListeners_(obj)
                If obj IsNot Nothing Then
                    If (phase And (NOT_PHASED Or DATA_CHANGED Or (1 << 0))) <> 0 Then
                        Me.Update_MasterMenuItem(obj.MasterMenuItem, phase)
                    End If
                End If
            End Sub
            Private Sub Update_MasterMenuItem(obj As Global.Scouting_Mobile.Core.Models.SampleOrder, phase As Integer)
                If obj IsNot Nothing Then
                    If (phase And (NOT_PHASED Or DATA_CHANGED Or (1 << 0))) <> 0 Then
                        Me.Update_MasterMenuItem_Status(obj.Status, phase)
                        Me.Update_MasterMenuItem_OrderDate(obj.OrderDate, phase)
                        Me.Update_MasterMenuItem_Company(obj.Company, phase)
                        Me.Update_MasterMenuItem_ShipTo(obj.ShipTo, phase)
                        Me.Update_MasterMenuItem_OrderTotal(obj.OrderTotal, phase)
                        Me.Update_MasterMenuItem_Symbol(obj.Symbol, phase)
                    End If
                End If
            End Sub
            Private Sub Update_MasterMenuItem_Status(obj As Global.System.String, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj4TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj4, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_MasterMenuItem_OrderDate(obj As Global.System.DateTime, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj5TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj5, obj.ToString(), Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_MasterMenuItem_Company(obj As Global.System.String, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj6TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj6, obj, Nothing)
                    End If
                    If isobj10TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj10, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_MasterMenuItem_ShipTo(obj As Global.System.String, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj7TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj7, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_MasterMenuItem_OrderTotal(obj As Global.System.Double, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj8TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj8, obj.ToString(), Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_MasterMenuItem_Symbol(obj As Global.System.Char, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj9GlyphDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(Me.obj9, obj.ToString(), Nothing)
                    End If
                End If
            End Sub

            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
            Private Class MasterDetailDetailControl_obj1_BindingsTracking
                Private weakRefToBindingObj As Global.System.WeakReference(Of MasterDetailDetailControl_obj1_Bindings) = Nothing

                Public Sub New(obj As MasterDetailDetailControl_obj1_Bindings)
                    weakRefToBindingObj = New Global.System.WeakReference(Of MasterDetailDetailControl_obj1_Bindings)(obj)
                End Sub

                Private Function TryGetBindingObject() As MasterDetailDetailControl_obj1_Bindings
                    Dim bindingObject As MasterDetailDetailControl_obj1_Bindings = Nothing
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
                End Sub

                Public Sub DependencyPropertyChanged_MasterMenuItem(sender As Global.Windows.UI.Xaml.DependencyObject, prop As Global.Windows.UI.Xaml.DependencyProperty)
                    Dim bindings As MasterDetailDetailControl_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        Dim obj As Global.Scouting_Mobile.Views.MasterDetailDetailControl = TryCast(sender, Global.Scouting_Mobile.Views.MasterDetailDetailControl)
                        If obj IsNot Nothing Then
                            bindings.Update_MasterMenuItem(obj.MasterMenuItem, DATA_CHANGED)
                        End If
                    End If
                End Sub
                Private tokenDPC_MasterMenuItem As Long = 0
                Public Sub UpdateChildListeners_(obj As Global.Scouting_Mobile.Views.MasterDetailDetailControl)
                    Dim bindings As MasterDetailDetailControl_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        If bindings.dataRoot IsNot Nothing Then
                            bindings.dataRoot.UnregisterPropertyChangedCallback(Global.Scouting_Mobile.Views.MasterDetailDetailControl.MasterMenuItemProperty, tokenDPC_MasterMenuItem)
                        End If
                        If obj IsNot Nothing Then
                            bindings.dataRoot = obj
                            tokenDPC_MasterMenuItem = obj.RegisterPropertyChangedCallback(Global.Scouting_Mobile.Views.MasterDetailDetailControl.MasterMenuItemProperty, AddressOf DependencyPropertyChanged_MasterMenuItem)
                        End If
                    End If
                End Sub
            End Class
        End Class

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionId
            Case 2 ' Views\MasterDetailDetailControl.xaml line 10
                    Me.ForegroundElement = CType(target, Global.Windows.UI.Xaml.Controls.ScrollViewer)
                    Exit Select
            Case 3 ' Views\MasterDetailDetailControl.xaml line 29
                    Me.block = CType(target, Global.Windows.UI.Xaml.Controls.StackPanel)
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
               Case 1: ' Views\MasterDetailDetailControl.xaml line 1
                    Dim element1 As Global.Windows.UI.Xaml.Controls.UserControl = CType(target, Global.Windows.UI.Xaml.Controls.UserControl)
                    Dim bindings As MasterDetailDetailControl_obj1_Bindings = New MasterDetailDetailControl_obj1_Bindings()
                    returnValue = bindings
                    bindings.SetDataRoot(Me)
                    Me.Bindings = bindings
                    AddHandler element1.Loading, AddressOf bindings.Loading
                    Global.Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings)
                    Exit Select
            End Select
            Return returnValue
        End Function
    End Class

End Namespace

