Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraReports.UI

Namespace CustomizeParameterEditorSample.Web
	Public Class OrdersReport
		Inherits XtraReport
		Private ReportHeader As ReportHeaderBand
		Private xrLabel1 As XRLabel
		Public formattingRulesDataSet1 As OrdersReportDataSet
		Private ordersTableAdapter As OrdersTableAdapter
		Private GroupHeader1 As GroupHeaderBand
		Private xrTable2 As XRTable
		Private xrTableRow2 As XRTableRow
		Private xrTableCell9 As XRTableCell
		Private xrTableCell10 As XRTableCell
		Private xrTableCell11 As XRTableCell
		Private xrTableCell12 As XRTableCell
		Private xrTableCell14 As XRTableCell
		Private xrTableCell15 As XRTableCell
		Private xrTableCell5 As XRTableCell
		Private oddStyle As XRControlStyle
		Private formattingRule1 As FormattingRule
		Private xrTable1 As XRTable
		Private xrTableRow3 As XRTableRow
		Private xrTableCell13 As XRTableCell
		Private xrTableCell16 As XRTableCell
		Private xrTableCell17 As XRTableCell
		Private xrTableCell18 As XRTableCell
		Private xrTableCell20 As XRTableCell
		Private xrTableCell21 As XRTableCell
		Private xrTableCell22 As XRTableCell
		Private style1 As XRControlStyle
		Private style2 As XRControlStyle
		Private style3 As XRControlStyle
		Private style4 As XRControlStyle
		Private style5 As XRControlStyle
		Private style6 As XRControlStyle
		Private style7 As XRControlStyle
		Private topMarginBand1 As TopMarginBand
		Private bottomMarginBand1 As BottomMarginBand
		Private ConditionIndexParameter As DevExpress.XtraReports.Parameters.Parameter
		Private StyleIndexParameter As DevExpress.XtraReports.Parameters.Parameter
		Private Detail As DetailBand

		Public Sub New()
			InitializeComponent()
			AddHandler BeforePrint, AddressOf Report_BeforePrint
		End Sub

		Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
			SetParameters(CInt(Fix(Parameters("ConditionIndexParameter").Value)), CInt(Fix(Parameters("StyleIndexParameter").Value)))
		End Sub



		Public Sub SetParameters(ByVal conditionIndex As Integer, ByVal styleIndex As Integer)
			formattingRule1.Condition = GetCondition(conditionIndex)
			formattingRule1.ApplyStyle(GetStyleByIndex(styleIndex))
		End Sub

		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
			Me.formattingRulesDataSet1 = New OrdersReportDataSet()
			Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ordersTableAdapter = New OrdersTableAdapter()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.oddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.style1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.style2 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.style3 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.style4 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.style5 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.style6 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.style7 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ConditionIndexParameter = New DevExpress.XtraReports.Parameters.Parameter()
			Me.StyleIndexParameter = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.formattingRulesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.HeightF = 23F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.DetailPrintCount = 0
			Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			' 
			' xrTable1
			' 
			Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.xrTable1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTable1.FormattingRules.Add(Me.formattingRule1)
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.OddStyleName = "oddStyle"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow3})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(649F, 23F)
			Me.xrTable1.StylePriority.UseBorderColor = False
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UseFont = False
			Me.xrTable1.StylePriority.UsePadding = False
			Me.xrTable1.StylePriority.UseTextAlignment = False
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' formattingRule1
			' 
			Me.formattingRule1.Condition = "[Extended Price] > 1000"
			Me.formattingRule1.DataMember = "OrdesTable"
			Me.formattingRule1.DataSource = Me.formattingRulesDataSet1
			' 
			' 
			' 
			Me.formattingRule1.Formatting.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
			Me.formattingRule1.Name = "formattingRule1"
			' 
			' formattingRulesDataSet1
			' 
			Me.formattingRulesDataSet1.DataSetName = "FormattingRulesDataSet"
			Me.formattingRulesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' xrTableRow3
			' 
			Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell13, Me.xrTableCell16, Me.xrTableCell17, Me.xrTableCell18, Me.xrTableCell20, Me.xrTableCell21, Me.xrTableCell22})
			Me.xrTableRow3.Name = "xrTableRow3"
			Me.xrTableRow3.Weight = 1
			' 
			' xrTableCell13
			' 
			Me.xrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdesTable.OrderID")})
			Me.xrTableCell13.Name = "xrTableCell13"
			Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell13.StylePriority.UseTextAlignment = False
			Me.xrTableCell13.Text = "xrTableCell13"
			Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell13.Weight = 0.10323574730354392
			' 
			' xrTableCell16
			' 
			Me.xrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdesTable.OrderDate", "{0:d}")})
			Me.xrTableCell16.Name = "xrTableCell16"
			Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell16.StylePriority.UseTextAlignment = False
			Me.xrTableCell16.Text = "xrTableCell16"
			Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell16.Weight = 0.14329738058551617
			' 
			' xrTableCell17
			' 
			Me.xrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdesTable.ProductName")})
			Me.xrTableCell17.Name = "xrTableCell17"
			Me.xrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell17.StylePriority.UseTextAlignment = False
			Me.xrTableCell17.Text = "xrTableCell17"
			Me.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCell17.Weight = 0.30508474576271188
			' 
			' xrTableCell18
			' 
			Me.xrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdesTable.Quantity")})
			Me.xrTableCell18.Name = "xrTableCell18"
			Me.xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell18.StylePriority.UseTextAlignment = False
			Me.xrTableCell18.Text = "xrTableCell18"
			Me.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell18.Weight = 0.089368258859784278
			' 
			' xrTableCell20
			' 
			Me.xrTableCell20.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdesTable.UnitPrice", "{0:c2}")})
			Me.xrTableCell20.Name = "xrTableCell20"
			Me.xrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell20.StylePriority.UseTextAlignment = False
			Me.xrTableCell20.Text = "xrTableCell20"
			Me.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell20.Weight = 0.12942989214175654
			' 
			' xrTableCell21
			' 
			Me.xrTableCell21.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdesTable.Discount", "{0:0%}")})
			Me.xrTableCell21.Name = "xrTableCell21"
			Me.xrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell21.StylePriority.UseTextAlignment = False
			Me.xrTableCell21.Text = "xrTableCell21"
			Me.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell21.Weight = 0.10939907550077041
			' 
			' xrTableCell22
			' 
			Me.xrTableCell22.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrdesTable.Extended Price", "{0:c2}")})
			Me.xrTableCell22.Name = "xrTableCell22"
			Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell22.StylePriority.UseTextAlignment = False
			Me.xrTableCell22.Text = "xrTableCell22"
			Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell22.Weight = 0.12018489984591681
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.HeightF = 50F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 27.75F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 50F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "Orders Report"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 23F
			Me.GroupHeader1.KeepTogether = True
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.RepeatEveryPage = True
			' 
			' xrTable2
			' 
			Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(247))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(233))))))
			Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(230))))), (CInt(Fix((CByte(225))))), (CInt(Fix((CByte(225))))))
			Me.xrTable2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(649F, 23F)
			Me.xrTable2.StylePriority.UseBackColor = False
			Me.xrTable2.StylePriority.UseBorderColor = False
			Me.xrTable2.StylePriority.UseBorders = False
			Me.xrTable2.StylePriority.UseTextAlignment = False
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell9, Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12, Me.xrTableCell14, Me.xrTableCell5, Me.xrTableCell15})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 0, 100F)
			Me.xrTableCell9.StylePriority.UseFont = False
			Me.xrTableCell9.StylePriority.UsePadding = False
			Me.xrTableCell9.StylePriority.UseTextAlignment = False
			Me.xrTableCell9.Text = "Order ID"
			Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell9.Weight = 0.10323574730354392
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 0, 100F)
			Me.xrTableCell10.StylePriority.UseFont = False
			Me.xrTableCell10.StylePriority.UsePadding = False
			Me.xrTableCell10.StylePriority.UseTextAlignment = False
			Me.xrTableCell10.Text = "Order Date"
			Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell10.Weight = 0.14329738058551617
			' 
			' xrTableCell11
			' 
			Me.xrTableCell11.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTableCell11.Name = "xrTableCell11"
			Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 1, 0, 100F)
			Me.xrTableCell11.StylePriority.UseFont = False
			Me.xrTableCell11.StylePriority.UsePadding = False
			Me.xrTableCell11.StylePriority.UseTextAlignment = False
			Me.xrTableCell11.Text = "Product Name"
			Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell11.Weight = 0.30508474576271188
			' 
			' xrTableCell12
			' 
			Me.xrTableCell12.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTableCell12.Name = "xrTableCell12"
			Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
			Me.xrTableCell12.StylePriority.UseFont = False
			Me.xrTableCell12.StylePriority.UsePadding = False
			Me.xrTableCell12.StylePriority.UseTextAlignment = False
			Me.xrTableCell12.Text = "Quantity"
			Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell12.Weight = 0.089368258859784278
			' 
			' xrTableCell14
			' 
			Me.xrTableCell14.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTableCell14.Name = "xrTableCell14"
			Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
			Me.xrTableCell14.StylePriority.UseFont = False
			Me.xrTableCell14.StylePriority.UsePadding = False
			Me.xrTableCell14.StylePriority.UseTextAlignment = False
			Me.xrTableCell14.Text = "Unit Price"
			Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell14.Weight = 0.12942989214175654
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
			Me.xrTableCell5.StylePriority.UseFont = False
			Me.xrTableCell5.StylePriority.UsePadding = False
			Me.xrTableCell5.StylePriority.UseTextAlignment = False
			Me.xrTableCell5.Text = "Discount"
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell5.Weight = 0.10939907550077041
			' 
			' xrTableCell15
			' 
			Me.xrTableCell15.Font = New System.Drawing.Font("Tahoma", 9.75F)
			Me.xrTableCell15.Name = "xrTableCell15"
			Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 4, 1, 0, 100F)
			Me.xrTableCell15.StylePriority.UseFont = False
			Me.xrTableCell15.StylePriority.UsePadding = False
			Me.xrTableCell15.StylePriority.UseTextAlignment = False
			Me.xrTableCell15.Text = "Ext. Price"
			Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell15.Weight = 0.12018489984591681
			' 
			' oddStyle
			' 
			Me.oddStyle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(236))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(233))))))
			Me.oddStyle.Name = "oddStyle"
			' 
			' style1
			' 
			Me.style1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold)
			Me.style1.Name = "style1"
			' 
			' style2
			' 
			Me.style2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(177))))), (CInt(Fix((CByte(38))))), (CInt(Fix((CByte(64))))))
			Me.style2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(226))))))
			Me.style2.Name = "style2"
			' 
			' style3
			' 
			Me.style3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(180))))), (CInt(Fix((CByte(188))))))
			Me.style3.Name = "style3"
			' 
			' style4
			' 
			Me.style4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(85))))), (CInt(Fix((CByte(130))))), (CInt(Fix((CByte(90))))))
			Me.style4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(226))))))
			Me.style4.Name = "style4"
			' 
			' style5
			' 
			Me.style5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(56))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(159))))))
			Me.style5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(226))))))
			Me.style5.Name = "style5"
			' 
			' style6
			' 
			Me.style6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(198))))), (CInt(Fix((CByte(204))))), (CInt(Fix((CByte(187))))))
			Me.style6.Name = "style6"
			' 
			' style7
			' 
			Me.style7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(175))))), (CInt(Fix((CByte(197))))), (CInt(Fix((CByte(221))))))
			Me.style7.Name = "style7"
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' ConditionIndexParameter
			' 
			Me.ConditionIndexParameter.Description = "Condition:"
			Me.ConditionIndexParameter.Name = "ConditionIndexParameter"
			Me.ConditionIndexParameter.Type = GetType(Integer)
			Me.ConditionIndexParameter.Value = 6
			' 
			' StyleIndexParameter
			' 
			Me.StyleIndexParameter.Description = "Style:"
			Me.StyleIndexParameter.Name = "StyleIndexParameter"
			Me.StyleIndexParameter.Type = GetType(Integer)
			Me.StyleIndexParameter.Value = 0
			' 
			' Report
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.GroupHeader1, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.DataAdapter = Me.ordersTableAdapter
			Me.DataMember = "OrdesTable"
			Me.DataSource = Me.formattingRulesDataSet1
			Me.FilterString = "[OrderDate] Between(#1994-01-01#, #1995-01-01#)"
			Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.ConditionIndexParameter, Me.StyleIndexParameter})
			Me.RequestParameters = False
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.oddStyle, Me.style1, Me.style2, Me.style3, Me.style4, Me.style5, Me.style6, Me.style7})
			Me.Version = "10.2"
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.formattingRulesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		Private Function GetCondition(ByVal index As Integer) As String
			Select Case index
				Case 0
					Return "[Quantity] > 30"
				Case 1
					Return "[Quantity] > 60"
				Case 2
					Return "[UnitPrice] > 40"
				Case 3
					Return "[UnitPrice] > 60"
				Case 4
					Return "[Discount] > 0.05"
				Case 5
					Return "[Discount] > 0.15"
				Case 6
					Return "[Extended Price] > 1000"
				Case 7
					Return "[Extended Price] > 1500"
			End Select
			Return "[Extended Price] > 1000"
		End Function
		Private Function GetStyleByIndex(ByVal index As Integer) As XRControlStyle
			Select Case index
				Case 0
					Return style1
				Case 1
					Return style2
				Case 2
					Return style3
				Case 3
					Return style5
				Case 4
					Return style7
				Case 5
					Return style4
				Case 6
					Return style6
			End Select
			Return style1
		End Function
	End Class
End Namespace
