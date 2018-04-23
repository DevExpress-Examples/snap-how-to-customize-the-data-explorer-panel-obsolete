Imports DevExpress.Data.Browsing.Design
Imports DevExpress.Utils
Imports System.ComponentModel
Imports System.Drawing

Namespace CustomDataExplorer
    Friend Class MyColumnImageProvider
        Inherits DevExpress.Data.Browsing.Design.ColumnImageProvider

        Private categoryNameIndex As Integer

        Public Overrides Function GetColumnImageIndex(ByVal [property] As PropertyDescriptor, ByVal specifics As DevExpress.Data.Browsing.Design.TypeSpecifics) As Integer
            If [property].Name.Equals("Product") Then
                Return categoryNameIndex
            End If
            Return MyBase.GetColumnImageIndex([property], specifics)
        End Function
        Public Overrides Function CreateImageCollection() As DevExpress.Utils.ImageCollection
            Dim result As ImageCollection = MyBase.CreateImageCollection()
            Dim image As Image = System.Drawing.Image.FromFile("BOOrderItem_16x16.png")
            result.AddImage(image)
            categoryNameIndex = result.Images.Count - 1
            Return result
        End Function
    End Class

End Namespace