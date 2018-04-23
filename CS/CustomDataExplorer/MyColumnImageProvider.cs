using DevExpress.Data.Browsing.Design;
using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;

namespace CustomDataExplorer {
    class MyColumnImageProvider : DevExpress.Data.Browsing.Design.ColumnImageProvider {
        int categoryNameIndex;

        public override int GetColumnImageIndex(PropertyDescriptor property,
            DevExpress.Data.Browsing.Design.TypeSpecifics specifics) {
            if (property.Name.Equals("Product"))
                return categoryNameIndex;
            return base.GetColumnImageIndex(property, specifics);
        }
        public override DevExpress.Utils.ImageCollection CreateImageCollection() {
            ImageCollection result = base.CreateImageCollection();
            Image image = Image.FromFile("BOOrderItem_16x16.png");
            result.AddImage(image);
            categoryNameIndex = result.Images.Count - 1;
            return result;
        }
    }

}