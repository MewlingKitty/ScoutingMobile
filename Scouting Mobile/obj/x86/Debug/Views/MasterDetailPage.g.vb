﻿#ExternalChecksum("C:\Users\ncd39\source\repos\Scouting Mobile\Views\MasterDetailPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "F1211455476FBA96529CC52B833DAA88")
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

    Partial Class MasterDetailPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Class XamlBindingSetters
            Public Shared Sub Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(obj As Global.Windows.UI.Xaml.Controls.ItemsControl, value As Global.System.Object, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = DirectCast(Global.Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(GetType(Global.System.Object), targetNullValue), Global.System.Object)
                End If
                obj.ItemsSource = value
            End Sub
            Public Shared Sub Set_Microsoft_Toolkit_Uwp_UI_Controls_MasterDetailsView_SelectedItem(obj As Global.Microsoft.Toolkit.Uwp.UI.Controls.MasterDetailsView, value As Global.System.Object, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = DirectCast(Global.Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(GetType(Global.System.Object), targetNullValue), Global.System.Object)
                End If
                obj.SelectedItem = value
            End Sub
            Public Shared Sub Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(obj As Global.Windows.UI.Xaml.Controls.FontIcon, value As Global.System.String, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = targetNullValue
                End If
                obj.Glyph = If (value, Global.System.String.Empty)
            End Sub
            Public Shared Sub Set_Windows_UI_Xaml_Controls_TextBlock_Text(obj As Global.Windows.UI.Xaml.Controls.TextBlock, value As Global.System.String, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = targetNullValue
                End If
                obj.Text = If (value, Global.System.String.Empty)
            End Sub
        End Class


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Class MasterDetailPage_obj9_Bindings
            Implements Global.Windows.UI.Xaml.IDataTemplateExtension
            Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent
            Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics
            Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
            Implements IMasterDetailPage_Bindings

            Private dataRoot As Global.Scouting_Mobile.Core.Models.SampleOrder
            Private initialized As Boolean = False
            Private Const NOT_PHASED As Integer = 1 << 31
            Private Const DATA_CHANGED As Integer = 1 << 30
            Private removedDataContextHandler As Boolean = False

            ' Fields for each control that has bindings.
            Private obj9 As Global.System.WeakReference
            Private obj10 As Global.Windows.UI.Xaml.Controls.FontIcon
            Private obj11 As Global.Windows.UI.Xaml.Controls.TextBlock
            Private obj12 As Global.Windows.UI.Xaml.Controls.TextBlock

            ' Static fields for each binding's enabled/disabled state
            Private Shared isobj10GlyphDisabled As Boolean = False
            Private Shared isobj11TextDisabled As Boolean = False
            Private Shared isobj12TextDisabled As Boolean = False

            Public Sub New()
            End Sub
            
            Public Sub Disable(lineNumber As Integer, columnNumber As Integer) Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics.Disable
                If (lineNumber = 30 And columnNumber = 21) Then
                    isobj10GlyphDisabled = True
                ElseIf (lineNumber = 35 And columnNumber = 32) Then
                    isobj11TextDisabled = True
                ElseIf (lineNumber = 36 And columnNumber = 32) Then
                    isobj12TextDisabled = True
                End If
            End Sub

            ' IComponentConnector

            Public Sub Connect(connectionId As Integer, target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
                Select Case connectionId
                    Case 9: ' Views\MasterDetailPage.xaml line 21                        
                        Me.obj9 = New Global.System.WeakReference(DirectCast(target, Global.Windows.UI.Xaml.Controls.Grid))
                        Exit Select
                    Case 10: ' Views\MasterDetailPage.xaml line 26                        
                        Me.obj10 = DirectCast(target, Global.Windows.UI.Xaml.Controls.FontIcon)
                        Exit Select
                    Case 11: ' Views\MasterDetailPage.xaml line 35                        
                        Me.obj11 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case 12: ' Views\MasterDetailPage.xaml line 36                        
                        Me.obj12 = DirectCast(target, Global.Windows.UI.Xaml.Controls.TextBlock)
                        Exit Select
                    Case Else
                        Exit Select
                End Select
            End Sub

            Public Sub DataContextChangedHandler(sender As Global.Windows.UI.Xaml.FrameworkElement, args As Global.Windows.UI.Xaml.DataContextChangedEventArgs)
                If Me.SetDataRoot(args.NewValue) Then
                    Me.Update()
                End If
            End Sub

            ' IDataTemplateExtension

            Public Function ProcessBinding(phase As UInteger) As Boolean Implements Global.Windows.UI.Xaml.IDataTemplateExtension.ProcessBinding
                Throw New Global.System.NotImplementedException()
            End Function

            Public Function ProcessBindings(args As ContainerContentChangingEventArgs) As Integer Implements Global.Windows.UI.Xaml.IDataTemplateExtension.ProcessBindings
                Dim nextPhase As Integer = -1
                ProcessBindings(args.Item, args.ItemIndex, CInt(args.Phase), nextPhase)
                Return nextPhase
            End Function 

            Public Sub ResetTemplate() Implements Global.Windows.UI.Xaml.IDataTemplateExtension.ResetTemplate
                Recycle()
            End Sub

            ' IDataTemplateComponent

            Public Sub ProcessBindings(item As Global.System.Object, itemIndex As Integer, phase As Integer, ByRef nextPhase As Integer) Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent.ProcessBindings
                nextPhase = -1
                Select Case phase
                    Case 0:
                        nextPhase = -1
                        Me.SetDataRoot(item)
                        If Not removedDataContextHandler Then
                            removedDataContextHandler = True
                            RemoveHandler TryCast(Me.obj9.Target, Global.Windows.UI.Xaml.Controls.Grid).DataContextChanged, AddressOf Me.DataContextChangedHandler
                        End If
                        Me.initialized = True
                        Exit Select
                End Select
                Me.Update_(DirectCast(item, Global.Scouting_Mobile.Core.Models.SampleOrder) , 1 << phase)
            End Sub

            Public Sub Recycle() Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent.Recycle
            End Sub

            ' IMasterDetailPage_Bindings
            Public Sub Initialize() Implements IMasterDetailPage_Bindings.Initialize
                If Not Me.initialized Then
                    Me.Update()
                End If
            End Sub
            
            Public Sub Update() Implements IMasterDetailPage_Bindings.Update
                Me.Update_(Me.dataRoot, NOT_PHASED)
                Me.initialized = True
            End Sub

            Public Sub StopTracking() Implements IMasterDetailPage_Bindings.StopTracking
                Me.initialized = False
            End Sub

            Public Sub DisconnectUnloadedObject(connectionId As Integer) Implements IMasterDetailPage_Bindings.DisconnectUnloadedObject
                Throw New Global.System.ArgumentException("No unloadable elements to disconnect.")
            End Sub

            Public Function SetDataRoot(newDataRoot As Global.System.Object)
                If Not newDataRoot Is Nothing Then
                    Me.dataRoot = DirectCast(newDataRoot, Global.Scouting_Mobile.Core.Models.SampleOrder)
                    Return True
                End If
                Return False
            End Function

            ' Update methods for each path node used in binding steps.
            Private Sub Update_(obj As Global.Scouting_Mobile.Core.Models.SampleOrder, phase As Integer)
                If obj IsNot Nothing Then
                    If (phase And (NOT_PHASED Or (1 << 0))) <> 0 Then
                        Me.Update_Symbol(obj.Symbol, phase)
                        Me.Update_Company(obj.Company, phase)
                        Me.Update_Status(obj.Status, phase)
                    End If
                End If
            End Sub
            Private Sub Update_Symbol(obj As Global.System.Char, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED )) <> 0 Then
                    If isobj10GlyphDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(Me.obj10, obj.ToString(), Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_Company(obj As Global.System.String, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED )) <> 0 Then
                    If isobj11TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj11, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_Status(obj As Global.System.String, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED )) <> 0 Then
                    If isobj12TextDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(Me.obj12, obj, Nothing)
                    End If
                End If
            End Sub
        End Class

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Class MasterDetailPage_obj1_Bindings
            Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent
            Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics
            Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
            Implements IMasterDetailPage_Bindings

            Private dataRoot As Global.Scouting_Mobile.Views.MasterDetailPage
            Private initialized As Boolean = False
            Private Const NOT_PHASED As Integer = 1 << 31
            Private Const DATA_CHANGED As Integer = 1 << 30

            ' Fields for each control that has bindings.
            Private obj14 As Global.Microsoft.Toolkit.Uwp.UI.Controls.MasterDetailsView

            Private bindingsTracking As MasterDetailPage_obj1_BindingsTracking

            ' Static fields for each binding's enabled/disabled state
            Private Shared isobj14ItemsSourceDisabled As Boolean = False
            Private Shared isobj14SelectedItemDisabled As Boolean = False

            Public Sub New()
                Me.bindingsTracking = New MasterDetailPage_obj1_BindingsTracking(Me)
            End Sub
            
            Public Sub Disable(lineNumber As Integer, columnNumber As Integer) Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics.Disable
                If (lineNumber = 99 And columnNumber = 13) Then
                    isobj14ItemsSourceDisabled = True
                ElseIf (lineNumber = 104 And columnNumber = 13) Then
                    isobj14SelectedItemDisabled = True
                End If
            End Sub

            ' IComponentConnector

            Public Sub Connect(connectionId As Integer, target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
                Select Case connectionId
                    Case 14: ' Views\MasterDetailPage.xaml line 93                        
                        Me.obj14 = DirectCast(target, Global.Microsoft.Toolkit.Uwp.UI.Controls.MasterDetailsView)
                        Me.bindingsTracking.RegisterTwoWayListener_14(Me.obj14)
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

            ' IMasterDetailPage_Bindings
            Public Sub Initialize() Implements IMasterDetailPage_Bindings.Initialize
                If Not Me.initialized Then
                    Me.Update()
                End If
            End Sub
            
            Public Sub Update() Implements IMasterDetailPage_Bindings.Update
                Me.Update_(Me.dataRoot, NOT_PHASED)
                Me.initialized = True
            End Sub

            Public Sub StopTracking() Implements IMasterDetailPage_Bindings.StopTracking
                Me.bindingsTracking.ReleaseAllListeners()
                Me.initialized = False
            End Sub

            Public Sub DisconnectUnloadedObject(connectionId As Integer) Implements IMasterDetailPage_Bindings.DisconnectUnloadedObject
                Throw New Global.System.ArgumentException("No unloadable elements to disconnect.")
            End Sub

            Public Function SetDataRoot(newDataRoot As Global.System.Object)
                Me.bindingsTracking.ReleaseAllListeners()
                If Not newDataRoot Is Nothing Then
                    Me.dataRoot = DirectCast(newDataRoot, Global.Scouting_Mobile.Views.MasterDetailPage)
                    Return True
                End If
                Return False
            End Function

            Public Sub Loading(src As Global.Windows.UI.Xaml.FrameworkElement, data As object)
                Me.Initialize()
            End Sub

            ' Update methods for each path node used in binding steps.
            Private Sub Update_(obj As Global.Scouting_Mobile.Views.MasterDetailPage, phase As Integer)
                Me.bindingsTracking.UpdateChildListeners_(obj)
                If obj IsNot Nothing Then
                    If (phase And (NOT_PHASED Or (1 << 0))) <> 0 Then
                        Me.Update_SampleItems(obj.SampleItems, phase)
                    End If
                    If (phase And (NOT_PHASED Or DATA_CHANGED Or (1 << 0))) <> 0 Then
                        Me.Update_Selected(obj.Selected, phase)
                    End If
                End If
            End Sub
            Private Sub Update_SampleItems(obj As Global.System.Collections.ObjectModel.ObservableCollection(Of Global.Scouting_Mobile.Core.Models.SampleOrder), phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED )) <> 0 Then
                    If isobj14ItemsSourceDisabled = False Then
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(Me.obj14, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub Update_Selected(obj As Global.Scouting_Mobile.Core.Models.SampleOrder, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj14SelectedItemDisabled = False Then
                        XamlBindingSetters.Set_Microsoft_Toolkit_Uwp_UI_Controls_MasterDetailsView_SelectedItem(Me.obj14, obj, Nothing)
                    End If
                End If
            End Sub
            Private Sub UpdateTwoWay_14_SelectedItem()
                If Me.initialized Then
                    If Me.dataRoot IsNot Nothing Then
                        Me.dataRoot.Selected = CType(Me.obj14.SelectedItem, Global.Scouting_Mobile.Core.Models.SampleOrder)
                    End If
                End If
            End Sub

            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
            Private Class MasterDetailPage_obj1_BindingsTracking
                Private weakRefToBindingObj As Global.System.WeakReference(Of MasterDetailPage_obj1_Bindings) = Nothing

                Public Sub New(obj As MasterDetailPage_obj1_Bindings)
                    weakRefToBindingObj = New Global.System.WeakReference(Of MasterDetailPage_obj1_Bindings)(obj)
                End Sub

                Private Function TryGetBindingObject() As MasterDetailPage_obj1_Bindings
                    Dim bindingObject As MasterDetailPage_obj1_Bindings = Nothing
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

                Public Sub PropertyChanged_(sender As object, e As Global.System.ComponentModel.PropertyChangedEventArgs)
                    Dim bindings As MasterDetailPage_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        Dim propName As String = e.PropertyName
                        Dim obj As Global.Scouting_Mobile.Views.MasterDetailPage = TryCast(sender, Global.Scouting_Mobile.Views.MasterDetailPage)
                        If Global.System.String.IsNullOrEmpty(propName) Then
                            If obj IsNot Nothing Then
                                bindings.Update_Selected(obj.Selected, DATA_CHANGED)
                            End If
                        Else
                            Select Case propName
                                Case "Selected":
                                    If obj IsNot Nothing Then
                                        bindings.Update_Selected(obj.Selected, DATA_CHANGED)
                                    End If
                                    Exit Select
                                Case Else
                                    Exit Select
                            End Select
                        End If
                    End If
                End Sub
                Public Sub UpdateChildListeners_(obj As Global.Scouting_Mobile.Views.MasterDetailPage)
                    Dim bindings As MasterDetailPage_obj1_Bindings = TryGetBindingObject()
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
                Public Sub RegisterTwoWayListener_14(sourceObject as Global.Microsoft.Toolkit.Uwp.UI.Controls.MasterDetailsView)
                    sourceObject.RegisterPropertyChangedCallback(Global.Microsoft.Toolkit.Uwp.UI.Controls.MasterDetailsView.SelectedItemProperty, Sub(sender, prop)
                        Dim bindingObj As MasterDetailPage_obj1_Bindings = Me.TryGetBindingObject()
                        If bindingObj IsNot Nothing Then
                            bindingObj.UpdateTwoWay_14_SelectedItem()
                        End If
                    End Sub)
                End Sub
            End Class
        End Class

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionId
            Case 13 ' Views\MasterDetailPage.xaml line 79
                    Me.ContentArea = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 14 ' Views\MasterDetailPage.xaml line 93
                    Me.MasterDetailsViewControl = CType(target, Global.Microsoft.Toolkit.Uwp.UI.Controls.MasterDetailsView)
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
               Case 1: ' Views\MasterDetailPage.xaml line 1
                    Dim element1 As Global.Windows.UI.Xaml.Controls.Page = CType(target, Global.Windows.UI.Xaml.Controls.Page)
                    Dim bindings As MasterDetailPage_obj1_Bindings = New MasterDetailPage_obj1_Bindings()
                    returnValue = bindings
                    bindings.SetDataRoot(Me)
                    Me.Bindings = bindings
                    AddHandler element1.Loading, AddressOf bindings.Loading
                    Global.Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings)
                    Exit Select
               Case 9: ' Views\MasterDetailPage.xaml line 21
                    Dim element9 As Global.Windows.UI.Xaml.Controls.Grid = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Dim bindings As MasterDetailPage_obj9_Bindings = New MasterDetailPage_obj9_Bindings()
                    returnValue = bindings
                    bindings.SetDataRoot(element9.DataContext)
                    AddHandler element9.DataContextChanged, AddressOf bindings.DataContextChangedHandler
                    Global.Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element9, bindings)
                    Global.Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element9, bindings)
                    Exit Select
            End Select
            Return returnValue
        End Function
    End Class

End Namespace

