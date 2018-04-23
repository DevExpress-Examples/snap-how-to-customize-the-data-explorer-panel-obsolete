namespace CustomDataExplorer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.snapControl1 = new DevExpress.Snap.SnapControl();
            this.snapDockManager1 = new DevExpress.Snap.Extensions.SnapDockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.fieldListDockPanel1 = new DevExpress.Snap.Extensions.UI.FieldListDockPanel();
            this.fieldListDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.reportExplorerDockPanel1 = new DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel();
            this.reportExplorerDockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.snapDocumentManager1 = new DevExpress.Snap.Extensions.SnapDocumentManager(this.components);
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.fieldListDockPanel1.SuspendLayout();
            this.reportExplorerDockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snapDocumentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            this.SuspendLayout();
            // 
            // snapControl1
            // 
            this.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snapControl1.Location = new System.Drawing.Point(0, 0);
            this.snapControl1.Name = "snapControl1";
            this.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = null;
            this.snapControl1.Size = new System.Drawing.Size(728, 576);
            this.snapControl1.TabIndex = 0;
            this.snapControl1.Text = "snapControl1";
            // 
            // snapDockManager1
            // 
            this.snapDockManager1.Form = this;
            this.snapDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.snapDockManager1.SnapControl = this.snapControl1;
            this.snapDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.fieldListDockPanel1);
            this.panelContainer1.Controls.Add(this.reportExplorerDockPanel1);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("5e80f571-b5b4-4856-b9ac-6911bf41bb32");
            this.panelContainer1.Location = new System.Drawing.Point(728, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
            this.panelContainer1.Size = new System.Drawing.Size(200, 576);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // fieldListDockPanel1
            // 
            this.fieldListDockPanel1.Controls.Add(this.fieldListDockPanel1_Container);
            this.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.fieldListDockPanel1.ID = new System.Guid("9f8cdc6c-3a47-45ae-bf64-b46b877d19e8");
            this.fieldListDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.fieldListDockPanel1.Name = "fieldListDockPanel1";
            this.fieldListDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.fieldListDockPanel1.Size = new System.Drawing.Size(200, 288);
            this.fieldListDockPanel1.SnapControl = this.snapControl1;
            // 
            // fieldListDockPanel1_Container
            // 
            this.fieldListDockPanel1_Container.Location = new System.Drawing.Point(5, 38);
            this.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            this.fieldListDockPanel1_Container.Size = new System.Drawing.Size(191, 245);
            this.fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // reportExplorerDockPanel1
            // 
            this.reportExplorerDockPanel1.Controls.Add(this.reportExplorerDockPanel1_Container);
            this.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.reportExplorerDockPanel1.ID = new System.Guid("e6242f00-a918-4726-9cf1-a8a4988cd3c4");
            this.reportExplorerDockPanel1.Location = new System.Drawing.Point(0, 288);
            this.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1";
            this.reportExplorerDockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.reportExplorerDockPanel1.Size = new System.Drawing.Size(200, 288);
            this.reportExplorerDockPanel1.SnapControl = this.snapControl1;
            // 
            // reportExplorerDockPanel1_Container
            // 
            this.reportExplorerDockPanel1_Container.Location = new System.Drawing.Point(5, 38);
            this.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container";
            this.reportExplorerDockPanel1_Container.Size = new System.Drawing.Size(191, 246);
            this.reportExplorerDockPanel1_Container.TabIndex = 0;
            // 
            // snapDocumentManager1
            // 
            this.snapDocumentManager1.ClientControl = this.snapControl1;
            this.snapDocumentManager1.View = this.noDocumentsView1;
            this.snapDocumentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.noDocumentsView1});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 576);
            this.Controls.Add(this.snapControl1);
            this.Controls.Add(this.panelContainer1);
            this.Name = "Form1";
            this.Text = "CustomDataExplorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snapDockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.fieldListDockPanel1.ResumeLayout(false);
            this.reportExplorerDockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snapDocumentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Snap.SnapControl snapControl1;
        private DevExpress.Snap.Extensions.SnapDockManager snapDockManager1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.Snap.Extensions.UI.FieldListDockPanel fieldListDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer fieldListDockPanel1_Container;
        private DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel reportExplorerDockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer reportExplorerDockPanel1_Container;
        private DevExpress.Snap.Extensions.SnapDocumentManager snapDocumentManager1;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
    }
}

