﻿#ExternalChecksum("C:\Users\ncd39\source\repos\ScoutingMobile\Scouting Mobile\Views\TelerikDataGridPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "EA1CF0A8BB7499BB4678C4CDAF74612C")
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

    Partial Class TelerikDataGridPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Friend Class XamlBindingSetters
            Public Shared Sub Set_Telerik_UI_Xaml_Controls_Grid_RadDataGrid_ItemsSource(obj As Global.Telerik.UI.Xaml.Controls.Grid.RadDataGrid, value As Global.System.Object, targetNullValue As String)
                If value Is Nothing AndAlso targetNullValue IsNot Nothing Then
                    value = DirectCast(Global.Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(GetType(Global.System.Object), targetNullValue), Global.System.Object)
                End If
                obj.ItemsSource = value
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
        Private Class TelerikDataGridPage_obj5_Bindings
            Implements Global.Windows.UI.Xaml.IDataTemplateExtension
            Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent
            Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics
            Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
            Implements ITelerikDataGridPage_Bindings

            Private dataRoot As Global.Scouting_Mobile.Core.Models.SampleOrder
            Private initialized As Boolean = False
            Private Const NOT_PHASED As Integer = 1 << 31
            Private Const DATA_CHANGED As Integer = 1 << 30
            Private removedDataContextHandler As Boolean = False

            ' Fields for each control that has bindings.
            Private obj5 As Global.System.WeakReference

            ' Static fields for each binding's enabled/disabled state
            Private Shared isobj5GlyphDisabled As Boolean = False

            Public Sub New()
            End Sub
            
            Public Sub Disable(lineNumber As Integer, columnNumber As Integer) Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics.Disable
                If (lineNumber = 32 And columnNumber = 39) Then
                    isobj5GlyphDisabled = True
                End If
            End Sub

            ' IComponentConnector

            Public Sub Connect(connectionId As Integer, target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
                Select Case connectionId
                    Case 5: ' Views\TelerikDataGridPage.xaml line 28                        
                        Me.obj5 = New Global.System.WeakReference(DirectCast(target, Global.Windows.UI.Xaml.Controls.FontIcon))
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
                            RemoveHandler TryCast(Me.obj5.Target, Global.Windows.UI.Xaml.Controls.FontIcon).DataContextChanged, AddressOf Me.DataContextChangedHandler
                        End If
                        Me.initialized = True
                        Exit Select
                End Select
                Me.Update_(DirectCast(item, Global.Scouting_Mobile.Core.Models.SampleOrder) , 1 << phase)
            End Sub

            Public Sub Recycle() Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent.Recycle
            End Sub

            ' ITelerikDataGridPage_Bindings
            Public Sub Initialize() Implements ITelerikDataGridPage_Bindings.Initialize
                If Not Me.initialized Then
                    Me.Update()
                End If
            End Sub
            
            Public Sub Update() Implements ITelerikDataGridPage_Bindings.Update
                Me.Update_(Me.dataRoot, NOT_PHASED)
                Me.initialized = True
            End Sub

            Public Sub StopTracking() Implements ITelerikDataGridPage_Bindings.StopTracking
                Me.initialized = False
            End Sub

            Public Sub DisconnectUnloadedObject(connectionId As Integer) Implements ITelerikDataGridPage_Bindings.DisconnectUnloadedObject
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
                    End If
                End If
            End Sub
            Private Sub Update_Symbol(obj As Global.System.Char, phase As Integer)
                If (phase And ((1 << 0) Or NOT_PHASED )) <> 0 Then
                    If isobj5GlyphDisabled = False Then
                        If TryCast(Me.obj5.Target, Global.Windows.UI.Xaml.Controls.FontIcon) IsNot Nothing Then
                            XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(TryCast(Me.obj5.Target, Global.Windows.UI.Xaml.Controls.FontIcon), obj.ToString(), Nothing)
                        End If
                    End If
                End If
            End Sub
        End Class

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Private Class TelerikDataGridPage_obj1_Bindings
            Implements Global.Windows.UI.Xaml.Markup.IDataTemplateComponent
            Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics
            Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
            Implements ITelerikDataGridPage_Bindings

            Private dataRoot As Global.Scouting_Mobile.Views.TelerikDataGridPage
            Private initialized As Boolean = False
            Private Const NOT_PHASED As Integer = 1 << 31
            Private Const DATA_CHANGED As Integer = 1 << 30

            ' Fields for each control that has bindings.
            Private obj3 As Global.Telerik.UI.Xaml.Controls.Grid.RadDataGrid

            Private bindingsTracking As TelerikDataGridPage_obj1_BindingsTracking

            ' Static fields for each binding's enabled/disabled state
            Private Shared isobj3ItemsSourceDisabled As Boolean = False

            Public Sub New()
                Me.bindingsTracking = New TelerikDataGridPage_obj1_BindingsTracking(Me)
            End Sub
            
            Public Sub Disable(lineNumber As Integer, columnNumber As Integer) Implements Global.Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics.Disable
                If (lineNumber = 14 And columnNumber = 77) Then
                    isobj3ItemsSourceDisabled = True
                End If
            End Sub

            ' IComponentConnector

            Public Sub Connect(connectionId As Integer, target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
                Select Case connectionId
                    Case 3: ' Views\TelerikDataGridPage.xaml line 14                        
                        Me.obj3 = DirectCast(target, Global.Telerik.UI.Xaml.Controls.Grid.RadDataGrid)
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

            ' ITelerikDataGridPage_Bindings
            Public Sub Initialize() Implements ITelerikDataGridPage_Bindings.Initialize
                If Not Me.initialized Then
                    Me.Update()
                End If
            End Sub
            
            Public Sub Update() Implements ITelerikDataGridPage_Bindings.Update
                Me.Update_(Me.dataRoot, NOT_PHASED)
                Me.initialized = True
            End Sub

            Public Sub StopTracking() Implements ITelerikDataGridPage_Bindings.StopTracking
                Me.bindingsTracking.ReleaseAllListeners()
                Me.initialized = False
            End Sub

            Public Sub DisconnectUnloadedObject(connectionId As Integer) Implements ITelerikDataGridPage_Bindings.DisconnectUnloadedObject
                Throw New Global.System.ArgumentException("No unloadable elements to disconnect.")
            End Sub

            Public Function SetDataRoot(newDataRoot As Global.System.Object)
                Me.bindingsTracking.ReleaseAllListeners()
                If Not newDataRoot Is Nothing Then
                    Me.dataRoot = DirectCast(newDataRoot, Global.Scouting_Mobile.Views.TelerikDataGridPage)
                    Return True
                End If
                Return False
            End Function

            Public Sub Loading(src As Global.Windows.UI.Xaml.FrameworkElement, data As object)
                Me.Initialize()
            End Sub

            ' Update methods for each path node used in binding steps.
            Private Sub Update_(obj As Global.Scouting_Mobile.Views.TelerikDataGridPage, phase As Integer)
                Me.bindingsTracking.UpdateChildListeners_(obj)
                If obj IsNot Nothing Then
                    If (phase And (NOT_PHASED Or DATA_CHANGED Or (1 << 0))) <> 0 Then
                        Me.Update_Source(obj.Source, phase)
                    End If
                End If
            End Sub
            Private Sub Update_Source(obj As Global.System.Collections.ObjectModel.ObservableCollection(Of Global.Scouting_Mobile.Core.Models.SampleOrder), phase As Integer)
                Me.bindingsTracking.UpdateChildListeners_Source(obj)
                If (phase And ((1 << 0) Or NOT_PHASED Or DATA_CHANGED)) <> 0 Then
                    If isobj3ItemsSourceDisabled = False Then
                        XamlBindingSetters.Set_Telerik_UI_Xaml_Controls_Grid_RadDataGrid_ItemsSource(Me.obj3, obj, Nothing)
                    End If
                End If
            End Sub

            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
            Private Class TelerikDataGridPage_obj1_BindingsTracking
                Private weakRefToBindingObj As Global.System.WeakReference(Of TelerikDataGridPage_obj1_Bindings) = Nothing

                Public Sub New(obj As TelerikDataGridPage_obj1_Bindings)
                    weakRefToBindingObj = New Global.System.WeakReference(Of TelerikDataGridPage_obj1_Bindings)(obj)
                End Sub

                Private Function TryGetBindingObject() As TelerikDataGridPage_obj1_Bindings
                    Dim bindingObject As TelerikDataGridPage_obj1_Bindings = Nothing
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
                    UpdateChildListeners_Source(Nothing)
                End Sub

                Public Sub PropertyChanged_(sender As object, e As Global.System.ComponentModel.PropertyChangedEventArgs)
                    Dim bindings As TelerikDataGridPage_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        Dim propName As String = e.PropertyName
                        Dim obj As Global.Scouting_Mobile.Views.TelerikDataGridPage = TryCast(sender, Global.Scouting_Mobile.Views.TelerikDataGridPage)
                        If Global.System.String.IsNullOrEmpty(propName) Then
                            If obj IsNot Nothing Then
                                bindings.Update_Source(obj.Source, DATA_CHANGED)
                            End If
                        Else
                            Select Case propName
                                Case "Source":
                                    If obj IsNot Nothing Then
                                        bindings.Update_Source(obj.Source, DATA_CHANGED)
                                    End If
                                    Exit Select
                                Case Else
                                    Exit Select
                            End Select
                        End If
                    End If
                End Sub
                Public Sub UpdateChildListeners_(obj As Global.Scouting_Mobile.Views.TelerikDataGridPage)
                    Dim bindings As TelerikDataGridPage_obj1_Bindings = TryGetBindingObject()
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
                Public Sub PropertyChanged_Source(sender As object, e As Global.System.ComponentModel.PropertyChangedEventArgs)
                    Dim bindings As TelerikDataGridPage_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        Dim propName As String = e.PropertyName
                        Dim obj As Global.System.Collections.ObjectModel.ObservableCollection(Of Global.Scouting_Mobile.Core.Models.SampleOrder) = TryCast(sender, Global.System.Collections.ObjectModel.ObservableCollection(Of Global.Scouting_Mobile.Core.Models.SampleOrder))
                        If Global.System.String.IsNullOrEmpty(propName) Then
                        Else
                            Select Case propName
                                Case Else
                                    Exit Select
                            End Select
                        End If
                    End If
                End Sub
                Public Sub CollectionChanged_Source(sender As object, e As Global.System.Collections.Specialized.NotifyCollectionChangedEventArgs)
                    Dim bindings As TelerikDataGridPage_obj1_Bindings = TryGetBindingObject()
                    If bindings IsNot Nothing Then
                        Dim obj As Global.System.Collections.ObjectModel.ObservableCollection(Of Global.Scouting_Mobile.Core.Models.SampleOrder) = TryCast(sender, Global.System.Collections.ObjectModel.ObservableCollection(Of Global.Scouting_Mobile.Core.Models.SampleOrder))
                    End If
                End Sub
                Private cache_Source As Global.System.Collections.ObjectModel.ObservableCollection(Of Global.Scouting_Mobile.Core.Models.SampleOrder) = Nothing
                Public Sub UpdateChildListeners_Source(obj As Global.System.Collections.ObjectModel.ObservableCollection(Of Global.Scouting_Mobile.Core.Models.SampleOrder))
                    If obj IsNot cache_Source Then
                        If cache_Source IsNot Nothing Then
                            RemoveHandler DirectCast(cache_Source,Global.System.ComponentModel.INotifyPropertyChanged).PropertyChanged, AddressOf PropertyChanged_Source
                            RemoveHandler DirectCast(cache_Source, Global.System.Collections.Specialized.INotifyCollectionChanged).CollectionChanged, AddressOf CollectionChanged_Source
                            cache_Source = Nothing
                        End If
                        If obj IsNot Nothing Then
                            cache_Source = obj
                            AddHandler DirectCast(obj, Global.System.ComponentModel.INotifyPropertyChanged).PropertyChanged, AddressOf PropertyChanged_Source
                            AddHandler DirectCast(obj, Global.System.Collections.Specialized.INotifyCollectionChanged).CollectionChanged, AddressOf CollectionChanged_Source
                        End If
                    End If
                End Sub
            End Class
        End Class

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionId
            Case 2 ' Views\TelerikDataGridPage.xaml line 11
                    Me.ContentArea = CType(target, Global.Windows.UI.Xaml.Controls.Grid)
                    Exit Select
            Case 3 ' Views\TelerikDataGridPage.xaml line 14
                    Me.grid = CType(target, Global.Telerik.UI.Xaml.Controls.Grid.RadDataGrid)
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
               Case 1: ' Views\TelerikDataGridPage.xaml line 1
                    Dim element1 As Global.Windows.UI.Xaml.Controls.Page = CType(target, Global.Windows.UI.Xaml.Controls.Page)
                    Dim bindings As TelerikDataGridPage_obj1_Bindings = New TelerikDataGridPage_obj1_Bindings()
                    returnValue = bindings
                    bindings.SetDataRoot(Me)
                    Me.Bindings = bindings
                    AddHandler element1.Loading, AddressOf bindings.Loading
                    Global.Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings)
                    Exit Select
               Case 5: ' Views\TelerikDataGridPage.xaml line 28
                    Dim element5 As Global.Windows.UI.Xaml.Controls.FontIcon = CType(target, Global.Windows.UI.Xaml.Controls.FontIcon)
                    Dim bindings As TelerikDataGridPage_obj5_Bindings = New TelerikDataGridPage_obj5_Bindings()
                    returnValue = bindings
                    bindings.SetDataRoot(element5.DataContext)
                    AddHandler element5.DataContextChanged, AddressOf bindings.DataContextChangedHandler
                    Global.Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings)
                    Global.Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element5, bindings)
                    Exit Select
            End Select
            Return returnValue
        End Function
    End Class

End Namespace


