using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraReports.UI;

namespace CustomizeParameterEditorSample.Web {
    public class OrdersReport: XtraReport {
        private ReportHeaderBand ReportHeader;
        private XRLabel xrLabel1;
        public OrdersReportDataSet formattingRulesDataSet1;
        private OrdersTableAdapter ordersTableAdapter;
        private GroupHeaderBand GroupHeader1;
        private XRTable xrTable2;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell10;
        private XRTableCell xrTableCell11;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell14;
        private XRTableCell xrTableCell15;
        private XRTableCell xrTableCell5;
        private XRControlStyle oddStyle;
        private FormattingRule formattingRule1;
        private XRTable xrTable1;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell13;
        private XRTableCell xrTableCell16;
        private XRTableCell xrTableCell17;
        private XRTableCell xrTableCell18;
        private XRTableCell xrTableCell20;
        private XRTableCell xrTableCell21;
        private XRTableCell xrTableCell22;
        private XRControlStyle style1;
        private XRControlStyle style2;
        private XRControlStyle style3;
        private XRControlStyle style4;
        private XRControlStyle style5;
        private XRControlStyle style6;
        private XRControlStyle style7;
        private TopMarginBand topMarginBand1;
        private BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.Parameters.Parameter ConditionIndexParameter;
        private DevExpress.XtraReports.Parameters.Parameter StyleIndexParameter;
        private DetailBand Detail;
    
        public OrdersReport() {
            InitializeComponent();
            BeforePrint += Report_BeforePrint;
        }

        void Report_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            SetParameters((int)Parameters["ConditionIndexParameter"].Value, (int)Parameters["StyleIndexParameter"].Value);
        }
        


        public void SetParameters(int conditionIndex, int styleIndex) {
            formattingRule1.Condition = GetCondition(conditionIndex);
            formattingRule1.ApplyStyle(GetStyleByIndex(styleIndex));
        }

        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.formattingRulesDataSet1 = new OrdersReportDataSet();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ordersTableAdapter = new OrdersTableAdapter();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.oddStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.style1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.style2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.style3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.style4 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.style5 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.style6 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.style7 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ConditionIndexParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.StyleIndexParameter = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formattingRulesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 23F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.ReportPrintOptions.DetailCount = 0;
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // xrTable1
            // 
            this.xrTable1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTable1.FormattingRules.Add(this.formattingRule1);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.OddStyleName = "oddStyle";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable1.SizeF = new System.Drawing.SizeF(649F, 23F);
            this.xrTable1.StylePriority.UseBorderColor = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UsePadding = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // formattingRule1
            // 
            this.formattingRule1.Condition = "[Extended Price] > 1000";
            this.formattingRule1.DataMember = "OrdesTable";
            this.formattingRule1.DataSource = this.formattingRulesDataSet1;
            // 
            // 
            // 
            this.formattingRule1.Formatting.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.formattingRule1.Name = "formattingRule1";
            // 
            // formattingRulesDataSet1
            // 
            this.formattingRulesDataSet1.DataSetName = "FormattingRulesDataSet";
            this.formattingRulesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrdesTable.OrderID")});
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.Text = "xrTableCell13";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell13.Weight = 0.10323574730354392;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrdesTable.OrderDate", "{0:d}")});
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = "xrTableCell16";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell16.Weight = 0.14329738058551617;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrdesTable.ProductName")});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = "xrTableCell17";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell17.Weight = 0.30508474576271188;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrdesTable.Quantity")});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.Text = "xrTableCell18";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell18.Weight = 0.089368258859784278;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrdesTable.UnitPrice", "{0:c2}")});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.Text = "xrTableCell20";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell20.Weight = 0.12942989214175654;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrdesTable.Discount", "{0:0%}")});
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "xrTableCell21";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell21.Weight = 0.10939907550077041;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrdesTable.Extended Price", "{0:c2}")});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.Text = "xrTableCell22";
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell22.Weight = 0.12018489984591681;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.ReportHeader.HeightF = 50F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(650F, 50F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Orders Report";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 23F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.xrTable2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(649F, 23F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseBorderColor = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell14,
            this.xrTableCell5,
            this.xrTableCell15});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 0, 100F);
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "Order ID";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell9.Weight = 0.10323574730354392;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 0, 100F);
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "Order Date";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 0.14329738058551617;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 2, 1, 0, 100F);
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "Product Name";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell11.Weight = 0.30508474576271188;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F);
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UsePadding = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "Quantity";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell12.Weight = 0.089368258859784278;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F);
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UsePadding = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.Text = "Unit Price";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell14.Weight = 0.12942989214175654;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F);
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Discount";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.10939907550077041;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F);
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UsePadding = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "Ext. Price";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell15.Weight = 0.12018489984591681;
            // 
            // oddStyle
            // 
            this.oddStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.oddStyle.Name = "oddStyle";
            // 
            // style1
            // 
            this.style1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.style1.Name = "style1";
            // 
            // style2
            // 
            this.style2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(38)))), ((int)(((byte)(64)))));
            this.style2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.style2.Name = "style2";
            // 
            // style3
            // 
            this.style3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(188)))));
            this.style3.Name = "style3";
            // 
            // style4
            // 
            this.style4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(130)))), ((int)(((byte)(90)))));
            this.style4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.style4.Name = "style4";
            // 
            // style5
            // 
            this.style5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(112)))), ((int)(((byte)(159)))));
            this.style5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.style5.Name = "style5";
            // 
            // style6
            // 
            this.style6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(204)))), ((int)(((byte)(187)))));
            this.style6.Name = "style6";
            // 
            // style7
            // 
            this.style7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(197)))), ((int)(((byte)(221)))));
            this.style7.Name = "style7";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // ConditionIndexParameter
            // 
            this.ConditionIndexParameter.Description = "Condition:";
            this.ConditionIndexParameter.Name = "ConditionIndexParameter";
            this.ConditionIndexParameter.Type = typeof(int);
            this.ConditionIndexParameter.Value = 6;
            // 
            // StyleIndexParameter
            // 
            this.StyleIndexParameter.Description = "Style:";
            this.StyleIndexParameter.Name = "StyleIndexParameter";
            this.StyleIndexParameter.Type = typeof(int);
            this.StyleIndexParameter.Value = 0;
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.GroupHeader1,
            this.topMarginBand1,
            this.bottomMarginBand1});
            this.DataAdapter = this.ordersTableAdapter;
            this.DataMember = "OrdesTable";
            this.DataSource = this.formattingRulesDataSet1;
            this.FilterString = "[OrderDate] Between(#1994-01-01#, #1995-01-01#)";
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.ConditionIndexParameter,
            this.StyleIndexParameter});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.oddStyle,
            this.style1,
            this.style2,
            this.style3,
            this.style4,
            this.style5,
            this.style6,
            this.style7});
            this.Version = "10.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formattingRulesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        string GetCondition(int index) {
            switch(index) {
                case 0: return "[Quantity] > 30";
                case 1: return "[Quantity] > 60";
                case 2: return "[UnitPrice] > 40";
                case 3: return "[UnitPrice] > 60";
                case 4: return "[Discount] > 0.05";
                case 5: return "[Discount] > 0.15";
                case 6: return "[Extended Price] > 1000";
                case 7: return "[Extended Price] > 1500";
            }
            return "[Extended Price] > 1000";
        }
        XRControlStyle GetStyleByIndex(int index) {
            switch(index) {
                case 0: return style1;
                case 1: return style2;
                case 2: return style3;
                case 3: return style5;
                case 4: return style7;
                case 5: return style4;
                case 6: return style6;
            }
            return style1;
        }
    }
}
