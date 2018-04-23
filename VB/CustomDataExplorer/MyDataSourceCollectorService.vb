Imports DevExpress.Data.Design
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace CustomDataExplorer
    Public Class MyDataSourceCollectorService
        Implements IDataSourceCollectorService

        Private ReadOnly innerService As IDataSourceCollectorService
        Public Sub New(ByVal oldService As IDataSourceCollectorService)
            innerService = oldService
        End Sub
        Public Function GetDataSources() As Object() Implements IDataSourceCollectorService.GetDataSources
            Dim dataSources() As Object = innerService.GetDataSources()
            Dim result As New List(Of Object)()
            For Each item As Object In dataSources
                If Not (TypeOf item Is DevExpress.XtraReports.Native.Parameters.ParametersDataSource) Then
                    result.Add(item)
                End If
            Next item
            Return result.ToArray()
        End Function
    End Class
End Namespace
