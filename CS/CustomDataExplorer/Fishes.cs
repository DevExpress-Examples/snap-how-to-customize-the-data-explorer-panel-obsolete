using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace CustomDataExplorer {
        public class Fish {
            [DisplayName("ID")]
            public int ID { get; set; }
            [DisplayName("Category")]
            public string Category { get; set; }
            [DisplayName("Common Name")]
            public string CommonName { get; set; }
            [DisplayName("Notes")]
            public string Notes { get; set; }
            [DisplayName("Scientific Classification")]
            public ScientificClassification ScientificClassification { get; set; }
        }
        public class ScientificClassification {
            [XmlElement("Reference")]
            public string Hyperlink { get; set; }
            public string Kingdom { get; set; }
            public string Phylum { get; set; }
            [XmlElement("Class")]
            [DisplayName("Class")]
            public string _Class { get; set; }
            public string Order { get; set; }
            public string Family { get; set; }
            public string Genus { get; set; }
            public string Species { get; set; }
        }

        public static class FishesSource {
            static List<Fish> data;

            public static List<Fish> Data
            {
                get
                {
                    if (data == null)
                        data = GetDataSource();
                    return data;
                }
            }

            static List<Fish> GetDataSource() {
                return DataSourceHelper.GetDataSourcesFromXml<Fish>("fishes.xml", "Fishes");
            }
        }

        public static class DataSourceHelper {
            public static List<T> GetDataSourcesFromXml<T>(string fileName, string attribute) where T : class {
                if (!File.Exists(fileName))
                    return null;
                using (Stream stream = File.OpenRead(fileName)) {
                    XmlSerializer s = new XmlSerializer(typeof(List<T>), new XmlRootAttribute(attribute));
                    return (List<T>)s.Deserialize(stream);
                }
            }
        }
    }