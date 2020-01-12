Imports System.Linq
Imports System.Runtime.CompilerServices

Imports Scouting_Mobile.Models

Imports Windows.UI.Xaml.Controls

Imports WinUI = Microsoft.UI.Xaml.Controls

Namespace Views
    ' For more info about the TabView Control see
    ' https://docs.microsoft.com/uwp/api/microsoft.ui.xaml.controls.tabview?view=winui-2.2
    ' For other samples, get the XAML Controls Gallery app http://aka.ms/XamlControlsGallery
    Public NotInheritable Partial Class TabViewPage
        Inherits Page
        Implements INotifyPropertyChanged

        ' In this sample the content shown in the Tab is a string, set the content to the model you want to show
        Public ReadOnly Property Tabs As ObservableCollection(Of TabViewItemData) = New ObservableCollection(Of TabViewItemData)() From {
            New TabViewItemData() With {
                .Index = 1,
                .Header = "Game 1",
                .Content = "I intend to put the individual games here, in a tab-like format." & vbCrLf & "This will be the Main page of the app."
           }
        }

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnAddTabButtonClick(sender As Microsoft.UI.Xaml.Controls.TabView, args As Object)
            Dim newIndex As Integer = If(Tabs.Any(), Tabs.Max(Function(t) t.Index) + 1, 1)
            Tabs.Add(New TabViewItemData() With {
                .Index = newIndex,
                .Header = $"Game {newIndex}",
                .Content = $"This is the content for Game {newIndex} (TODO)"
            })
        End Sub

        Private Sub OnTabCloseRequested(sender As WinUI.TabView, args As WinUI.TabViewTabCloseRequestedEventArgs)
            Dim item As TabViewItemData = TryCast(args.Item, TabViewItemData)

            If item IsNot Nothing Then
                Tabs.Remove(item)
            End If
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

