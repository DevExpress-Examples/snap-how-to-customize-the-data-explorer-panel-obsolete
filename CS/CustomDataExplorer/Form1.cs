using DevExpress.Data.Design;
using DevExpress.DataAccess.Excel;
using DevExpress.Snap;
using DevExpress.Snap.Extensions.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDataExplorer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            SnapFieldListTreeView treeView = fieldListDockPanel1.Controls[0].Controls[0] as SnapFieldListTreeView;

            // Customize the context menu.
            MenuCommandHandler menuCommandHandler = new MyMenuCommandHandler(snapControl1);
            menuCommandHandler.RegisterMenuCommands();
            snapControl1.ReplaceService<MenuCommandHandler>(menuCommandHandler);

            // Remove the Parameters node.
            IDataSourceCollectorService oldService = snapControl1.GetService<IDataSourceCollectorService>();
            MyDataSourceCollectorService newService = new MyDataSourceCollectorService(oldService);
            snapControl1.ReplaceService<IDataSourceCollectorService>(newService);
            SnapFieldListTreeView view = fieldListDockPanel1.Controls[0].Controls[0] as SnapFieldListTreeView;
            view.AllowSvgImages = false;
            view.UpdateDataSource(snapControl1, newService.GetDataSources());

            #region #FieldListDockPanel_Options
            // Retain the original field order in the tree.
            fieldListDockPanel1.SortOrder = SortOrder.None;
            // Display nested fields at the bottom.
            fieldListDockPanel1.ShowComplexProperties = DevExpress.XtraReports.Design.ShowComplexProperties.Last;
            // Specify the Data Explorer window caption.
            fieldListDockPanel1.Text = "My Data";
            #endregion #FieldListDockPanel_Options
        }

        private void Form1_Load(object sender, EventArgs e) {
            ExcelDataSource textDataSource = CreateMyOrdersDataSource();

            snapControl1.Document.DataSources.Add("My Xml Data", FishesSource.Data);
            snapControl1.DataSource = textDataSource;
        }

        private static ExcelDataSource CreateMyOrdersDataSource() {
            ExcelDataSource excelDataSource = new ExcelDataSource();
            excelDataSource.Name = "My Orders";
            excelDataSource.FileName = "Orders.csv";

            // Specify import settings.
            CsvSourceOptions csvSourceOptions = new CsvSourceOptions();
            csvSourceOptions.DetectEncoding = true;
            csvSourceOptions.DetectNewlineType = true;
            csvSourceOptions.ValueSeparator = '\t';
            excelDataSource.SourceOptions = csvSourceOptions;

            // Define the data source schema.
            FieldInfo fieldID = new FieldInfo { Name = "ID", Type = typeof(int) };
            FieldInfo fieldDate = new FieldInfo { Name = "Date", Type = typeof(DateTime) };
            FieldInfo fieldProduct = new FieldInfo { Name = "Product", Type = typeof(string) };
            FieldInfo fieldCategory = new FieldInfo { Name = "Category", Type = typeof(string) };
            FieldInfo fieldPrice = new FieldInfo { Name = "Price", Type = typeof(decimal) };
            FieldInfo fieldQty = new FieldInfo { Name = "Qty", Type = typeof(int) };
            FieldInfo fieldDiscount = new FieldInfo { Name = "IsDiscount", Type = typeof(bool) };
            FieldInfo fieldAmount = new FieldInfo { Name = "Amount", Type = typeof(decimal) };
            // Add the created fields to the data source schema in the order that matches the column order in the source file.
            excelDataSource.Schema.AddRange(new FieldInfo[] { fieldID, fieldDate, fieldProduct, fieldCategory, fieldPrice, fieldQty, fieldDiscount, fieldAmount });
            excelDataSource.Fill();
            return excelDataSource;
        }
    }
}
