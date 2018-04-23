using DevExpress.Snap;

namespace CustomDataExplorer {
    public class MyMenuCommandHandler : MenuCommandHandler {
        public MyMenuCommandHandler(SnapControl snap) : base(snap) {
        }
        public override void UpdateCommandStatus() {
            base.UpdateCommandStatus();
            foreach (DevExpress.XtraReports.Design.Commands.CommandSetItem item in commands) {
                if (item.CommandID == DataExplorerCommands.AddDataSource) {
                    item.Supported = false;
                }
            }
        }
    }
}