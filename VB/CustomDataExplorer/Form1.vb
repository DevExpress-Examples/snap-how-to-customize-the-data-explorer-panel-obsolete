Imports DevExpress.Data.Design
Imports DevExpress.DataAccess.Excel
Imports DevExpress.Snap
Imports DevExpress.Snap.Extensions.Native
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomDataExplorer
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            Dim treeView As SnapFieldListTreeView = TryCast(fieldListDockPanel1.Controls(0).Controls(0), SnapFieldListTreeView)

            ' Customize the context menu.
            Dim menuCommandHandler As MenuCommandHandler = New MyMenuCommandHandler(snapControl1)
            menuCommandHandler.RegisterMenuCommands()
            snapControl1.ReplaceService(Of MenuCommandHandler)(menuCommandHandler)

            ' Remove the Parameters node.
            Dim oldService As IDataSourceCollectorService = snapControl1.GetService(Of IDataSourceCollectorService)()
            Dim newService As New MyDataSourceCollectorService(oldService)
            snapControl1.ReplaceService(Of IDataSourceCollectorService)(newService)
            Dim view As SnapFieldListTreeView = TryCast(fieldListDockPanel1.Controls(0).Controls(0), SnapFieldListTreeView)
            view.UpdateDataSource(snapControl1, newService.GetDataSources())

'            #Region "#FieldListDockPanel_Options"
            ' Retain the original field order in the tree.
            fieldListDockPanel1.SortOrder = SortOrder.None
            ' Display nested fields at the bottom.
            fieldListDockPanel1.ShowComplexProperties = DevExpress.XtraReports.Design.ShowComplexProperties.Last
            ' Specify the Data Explorer window caption.
            fieldListDockPanel1.Text = "My Data"
'            #End Region ' #FieldListDockPanel_Options
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim textDataSource As ExcelDataSource = CreateMyOrdersDataSource()

            snapControl1.Document.DataSources.Add("My Xml Data", FishesSource.Data)
            snapControl1.DataSource = textDataSource
        End Sub

        Private Shared Function CreateMyOrdersDataSource() As ExcelDataSource
            Dim excelDataSource As New ExcelDataSource()
            excelDataSource.Name = "My Orders"
            excelDataSource.FileName = "Orders.csv"

            ' Specify import settings.
            Dim csvSourceOptions As New CsvSourceOptions()
            csvSourceOptions.DetectEncoding = True
            csvSourceOptions.DetectNewlineType = True
            csvSourceOptions.ValueSeparator = ControlChars.Tab
            excelDataSource.SourceOptions = csvSourceOptions

            ' Define the data source schema.
            Dim fieldID As FieldInfo = New FieldInfo With { _
                .Name = "ID", _
                .Type = GetType(Integer) _
            }
            Dim fieldDate As FieldInfo = New FieldInfo With { _
                .Name = "Date", _
                .Type = GetType(Date) _
            }
            Dim fieldProduct As FieldInfo = New FieldInfo With { _
                .Name = "Product", _
                .Type = GetType(String) _
            }
            Dim fieldCategory As FieldInfo = New FieldInfo With { _
                .Name = "Category", _
                .Type = GetType(String) _
            }
            Dim fieldPrice As FieldInfo = New FieldInfo With { _
                .Name = "Price", _
                .Type = GetType(Decimal) _
            }
            Dim fieldQty As FieldInfo = New FieldInfo With { _
                .Name = "Qty", _
                .Type = GetType(Integer) _
            }
            Dim fieldDiscount As FieldInfo = New FieldInfo With { _
                .Name = "IsDiscount", _
                .Type = GetType(Boolean) _
            }
            Dim fieldAmount As FieldInfo = New FieldInfo With { _
                .Name = "Amount", _
                .Type = GetType(Decimal) _
            }
            ' Add the created fields to the data source schema in the order that matches the column order in the source file.
            excelDataSource.Schema.AddRange(New FieldInfo() { fieldID, fieldDate, fieldProduct, fieldCategory, fieldPrice, fieldQty, fieldDiscount, fieldAmount })
            excelDataSource.Fill()
            Return excelDataSource
        End Function
    End Class
End Namespace
