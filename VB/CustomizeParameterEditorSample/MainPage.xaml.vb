Imports Microsoft.VisualBasic
Imports System.Collections.ObjectModel
Imports System.Windows.Controls
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Core
' ...

Namespace CustomizeParameterEditorSample
	Partial Public Class MainPage
		Inherits UserControl
		Private conditions As New ReadOnlyCollection(Of String)(New String() { "Quantity more than 30", "Quantity more than 60", "Unit price more than 40", "Unit price more than 60", "Discount more than 5", "Discount more than 15", "Extended price more than 1000", "Extended price more than 1500" })

		Private styles As New ReadOnlyCollection(Of String)(New String() { "Tahoma Bold", "Dark Red", "Light Red", "Dark Blue", "Light Blue", "Dark Green", "Light Green" })

		Public Sub New()
			ThemeManager.ApplicationThemeName = "Office2007Black"
			InitializeComponent()
			Dim model As New ReportPreviewModel("../ReportService.svc")
			model.ReportName = "CustomizeParameterEditorSample.Web.OrdersReport"
			AddHandler model.CustomizeParameterEditors, AddressOf model_CustomizeParameterEditors
			preview.Model = model
			model.CreateDocument()
		End Sub

		Private Sub model_CustomizeParameterEditors(ByVal sender As Object, ByVal e As CustomizeParameterEditorsEventArgs)
			If e.Parameter.Name = "ConditionIndexParameter" Then
				e.Editor = New ComboBoxEdit() With {.IsTextEditable = False, .ItemsSource = conditions}
				e.BoundDataMember = "SelectedIndex"
			End If
			If e.Parameter.Name = "StyleIndexParameter" Then
				e.Editor = New ComboBoxEdit() With {.IsTextEditable = False, .ItemsSource = styles}
				e.BoundDataMember = "SelectedIndex"
			End If
		End Sub
	End Class
End Namespace
