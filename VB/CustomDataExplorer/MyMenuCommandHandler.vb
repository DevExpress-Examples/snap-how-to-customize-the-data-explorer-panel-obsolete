Imports DevExpress.Snap

Namespace CustomDataExplorer
    Public Class MyMenuCommandHandler
        Inherits MenuCommandHandler

        Public Sub New(ByVal snap As SnapControl)
            MyBase.New(snap)
        End Sub
        Public Overrides Sub UpdateCommandStatus()
            MyBase.UpdateCommandStatus()
            For Each item As DevExpress.XtraReports.Design.Commands.CommandSetItem In commands
                If item.CommandID Is DataExplorerCommands.AddDataSource Then
                    item.Supported = False
                End If
            Next item
        End Sub
    End Class
End Namespace