Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Threading.Tasks

Imports Windows.Storage
Imports Windows.Storage.Pickers
Imports Windows.Storage.Streams
Imports Windows.UI.Xaml.Media.Imaging

Namespace Helpers
    Module ImageHelper

        Async Function LoadImageFileAsync() As Task(Of StorageFile)
            Dim openPicker = New FileOpenPicker With {
                .SuggestedStartLocation = PickerLocationId.PicturesLibrary
            }
            openPicker.FileTypeFilter.Add(".png")
            openPicker.FileTypeFilter.Add(".jpeg")
            openPicker.FileTypeFilter.Add(".jpg")
            openPicker.FileTypeFilter.Add(".bmp")
            Dim imageFile = Await openPicker.PickSingleFileAsync()
            Return imageFile
        End Function

        Async Function GetBitmapFromImageAsync(file As StorageFile) As Task(Of BitmapImage)
            If file Is Nothing Then
                Return Nothing
            End If

            Try
                Using fileStream = Await file.OpenAsync(FileAccessMode.Read)
                    Dim bitmapImage = New BitmapImage()
                    Await bitmapImage.SetSourceAsync(fileStream)
                    Return bitmapImage
                End Using

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Async Function ImageFromStringAsync(data As String) As Task(Of BitmapImage)
            Dim byteArray = Convert.FromBase64String(data)
            Dim image = New BitmapImage()

            Using stream = New InMemoryRandomAccessStream()
                Await stream.WriteAsync(byteArray.AsBuffer())
                stream.Seek(0)
                Await image.SetSourceAsync(stream)
            End Using

            Return image
        End Function

        Function ImageFromAssetsFile(fileName As String) As BitmapImage
            Dim image = New BitmapImage(New Uri($"ms-appx:///Assets/{fileName}"))
            Return image
        End Function
    End Module
End Namespace
