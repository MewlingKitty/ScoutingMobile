Imports Microsoft.Toolkit.Uwp.UI.Animations

Imports Scouting_Mobile.Core.Models
Imports Scouting_Mobile.Core.Services
Imports Scouting_Mobile.Services

Namespace Views
    Public NotInheritable Partial Class ContentGridPage
        Inherits Page
        Implements INotifyPropertyChanged

        Public Property Source As ObservableCollection(Of SampleOrder) = New ObservableCollection(Of SampleOrder)

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Async Sub OnNavigatedTo(e As NavigationEventArgs)
            MyBase.OnNavigatedTo(e)
            Source.Clear()

            ' TODO WTS: Replace this with your actual data
            Dim data = Await SampleDataService.GetContentGridDataAsync()

            For Each item As SampleOrder In data
                Source.Add(item)
            Next
        End Sub

        Private Sub OnItemClick(sender As Object, e As ItemClickEventArgs)
            Dim item = TryCast(e.ClickedItem, SampleOrder)
            If item IsNot Nothing Then
                NavigationService.Frame.SetListDataItemForNextConnectedAnimation(item)
                NavigationService.Navigate(Of ContentGridDetailPage)(item.OrderID)
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
