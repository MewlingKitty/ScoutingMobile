﻿#ExternalChecksum("C:\Users\ncd39\source\repos\Scouting Mobile\Views\SettingsPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "802D52FE4B055A545BC964931AD7421A")
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

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Class SettingsPage
        Inherits Global.Windows.UI.Xaml.Controls.Page


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        private WithEvents ReverseBoolToVisibility As Global.Microsoft.Toolkit.Uwp.UI.Converters.BoolToVisibilityConverter
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        private WithEvents BoolNegationConverter As Global.Microsoft.Toolkit.Uwp.UI.Converters.BoolNegationConverter
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        private WithEvents ContentArea As Global.Windows.UI.Xaml.Controls.StackPanel
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        private WithEvents FeedbackLink As Global.Windows.UI.Xaml.Controls.HyperlinkButton

        Private _contentLoaded As Boolean

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true

            Dim resourceLocator As New Global.System.Uri("ms-appx:///Views/SettingsPage.xaml")
            Global.Windows.UI.Xaml.Application.LoadComponent(Me, resourceLocator, Global.Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application)
        End Sub

        Partial Private Sub UnloadObject(unloadableObject As Global.Windows.UI.Xaml.DependencyObject)
        End Sub


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        Private Interface ISettingsPage_Bindings
            Sub Initialize()
            Sub Update()
            Sub StopTracking()
            Sub DisconnectUnloadedObject(connectionId As Integer)
        End Interface

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.18362.1")>  _
        Private Bindings As ISettingsPage_Bindings

    End Class

End Namespace


