using DevExpress.Data.Design;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataExplorer {
    public class MyDataSourceCollectorService : IDataSourceCollectorService {
        private readonly IDataSourceCollectorService innerService;
        public MyDataSourceCollectorService(IDataSourceCollectorService oldService) {
            innerService = oldService;
        }
        public object[] GetDataSources() {
            object[] dataSources = innerService.GetDataSources();
            List<object> result = new List<object>();
            foreach (object item in dataSources) {
                if (!(item is DevExpress.XtraReports.Native.Parameters.ParametersDataSource)) {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
