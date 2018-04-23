Imports DevExpress.Utils
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Xml.Serialization

Namespace CustomDataExplorer
        Public Class Fish
            <DisplayName("ID")> _
            Public Property ID() As Integer
            <DisplayName("Category")> _
            Public Property Category() As String
            <DisplayName("Common Name")> _
            Public Property CommonName() As String
            <DisplayName("Notes")> _
            Public Property Notes() As String
            <DisplayName("Scientific Classification")> _
            Public Property ScientificClassification() As ScientificClassification
        End Class
        Public Class ScientificClassification
            <XmlElement("Reference")> _
            Public Property Hyperlink() As String
            Public Property Kingdom() As String
            Public Property Phylum() As String
            <XmlElement("Class"), DisplayName("Class")> _
            Public Property _Class() As String
            Public Property Order() As String
            Public Property Family() As String
            Public Property Genus() As String
            Public Property Species() As String
        End Class

        Public NotInheritable Class FishesSource

            Private Sub New()
            End Sub

            Private Shared data_Renamed As List(Of Fish)

            Public Shared ReadOnly Property Data() As List(Of Fish)
                Get
                    If data_Renamed Is Nothing Then
                        data_Renamed = GetDataSource()
                    End If
                    Return data_Renamed
                End Get
            End Property

            Private Shared Function GetDataSource() As List(Of Fish)
                Return DataSourceHelper.GetDataSourcesFromXml(Of Fish)("fishes.xml", "Fishes")
            End Function
        End Class

        Public NotInheritable Class DataSourceHelper

            Private Sub New()
            End Sub

            Public Shared Function GetDataSourcesFromXml(Of T As Class)(ByVal fileName As String, ByVal attribute As String) As List(Of T)
                If Not File.Exists(fileName) Then
                    Return Nothing
                End If
                Using stream As Stream = File.OpenRead(fileName)
                    Dim s As New XmlSerializer(GetType(List(Of T)), New XmlRootAttribute(attribute))
                    Return DirectCast(s.Deserialize(stream), List(Of T))
                End Using
            End Function
        End Class
End Namespace