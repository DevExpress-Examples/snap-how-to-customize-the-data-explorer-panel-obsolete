Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomDataExplorer
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            ' Set the Treeview node images.
            DevExpress.Data.Browsing.Design.ColumnImageProvider.Instance = New MyColumnImageProvider()
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace
