Imports Microsoft.Toolkit.Uwp.UI.Controls

Imports Scouting_Mobile.Core.Models
Imports Scouting_Mobile.Core.Services

Namespace Views
    Public NotInheritable Partial Class MasterDetailPage
        Inherits Page
        Implements INotifyPropertyChanged

        Private _selected As SampleOrder

        Public Property Selected As SampleOrder
            Get
                Return _selected
            End Get
            Set
                [Set](_selected, value)
            End Set
        End Property

        Public Property SampleItems As ObservableCollection(Of SampleOrder) = new ObservableCollection(Of SampleOrder)

        Public Sub New()
            InitializeComponent()
            AddHandler Loaded, AddressOf MasterDetailPage_Loaded
        End Sub

        Private Async Sub MasterDetailPage_Loaded(sender As Object, e As RoutedEventArgs)
            SampleItems.Clear()

            Dim data = Await SampleDataService.GetMasterDetailDataAsync()

            For Each item As SampleOrder In data
                SampleItems.Add(item)
            Next

            If MasterDetailsViewControl.ViewState = MasterDetailsViewState.Both Then
                Selected = SampleItems.FirstOrDefault()
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
