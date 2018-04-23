using System.Collections.ObjectModel;
using System.Windows.Controls;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Core;
// ...

namespace CustomizeParameterEditorSample {
    public partial class MainPage : UserControl {
        ReadOnlyCollection<string> conditions = new ReadOnlyCollection<string>(new string[] {             
            "Quantity more than 30",
            "Quantity more than 60",
            "Unit price more than 40",
            "Unit price more than 60",
            "Discount more than 5",
            "Discount more than 15",
            "Extended price more than 1000",
            "Extended price more than 1500"
        });

        ReadOnlyCollection<string> styles = new ReadOnlyCollection<string>(new string[] {
            "Tahoma Bold",
            "Dark Red",
            "Light Red",
            "Dark Blue",
            "Light Blue",
            "Dark Green",
            "Light Green"
        });

        public MainPage() {
            ThemeManager.ApplicationThemeName = "Office2007Black";
            InitializeComponent();
            ReportPreviewModel model = new ReportPreviewModel("../ReportService.svc");
            model.ReportTypeName = "CustomizeParameterEditorSample.Web.OrdersReport";
            model.CustomizeParameterEditors += model_CustomizeParameterEditors;
            preview.Model = model;
            model.CreateDocument();
        }

        void model_CustomizeParameterEditors(object sender, CustomizeParameterEditorsEventArgs e) {
            if(e.Parameter.Name == "ConditionIndexParameter") {
                e.Editor = new ComboBoxEdit() { IsTextEditable = false, ItemsSource = conditions };
                e.BoundDataMember = "SelectedIndex";
            }
            if(e.Parameter.Name == "StyleIndexParameter") {
                e.Editor = new ComboBoxEdit() { IsTextEditable = false, ItemsSource = styles };
                e.BoundDataMember = "SelectedIndex";
            }
        }
    }
}
