Imports Scouting_Mobile.Core.Models
Imports Scouting_Mobile.Core.Services

Namespace Views
    Public NotInheritable Partial Class TelerikDataGridPage
        Inherits Page
        Implements INotifyPropertyChanged

        Public Property Source As ObservableCollection(Of SampleOrder) = New ObservableCollection(Of SampleOrder)

        ' TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on TelerikDataGridPage.xaml.
        ' For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        ' You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Async Sub OnNavigatedTo(e As NavigationEventArgs)
            MyBase.OnNavigatedTo(e)
            Source.Clear()

            ' TODO WTS: Replace this with your actual data
            Dim data = Await SampleDataService.GetGridDataAsync()
            For Each item In data
                Source.Add(item)
            Next
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
