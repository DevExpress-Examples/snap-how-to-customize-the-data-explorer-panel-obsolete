using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDataExplorer {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Set the Treeview node images.
            DevExpress.Data.Browsing.Design.ColumnImageProvider.Instance = new MyColumnImageProvider();
            Application.Run(new Form1());
        }
    }
}
