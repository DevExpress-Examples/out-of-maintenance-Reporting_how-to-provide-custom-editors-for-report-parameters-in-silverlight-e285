<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/CustomizeParameterEditorSample/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/CustomizeParameterEditorSample/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/CustomizeParameterEditorSample/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/CustomizeParameterEditorSample/MainPage.xaml.vb))
<!-- default file list end -->
# How to provide custom editors for report parameters in Silverlight


<p>This example demonstrates how you can provide your own custom editors that are shown in the Parameters UI of a report's Print Preview.</p><p>To do this, in the <strong>CustomizeParameterEditors</strong> event handler override the existing editor, and, for its <strong>BoundDataMember</strong> property, specify the data member that is associated with the parameter.</p><p>If required, you can also define a <strong>BoundDataConverter</strong> (a converter, which implements the <strong>IValueConverter</strong> interface) and <strong>BoundDataConverterParameter</strong> (a parameter that can be used in the converter's methods).</p><p>See also:<br />
- <a href="https://www.devexpress.com/Support/Center/p/E2858">How to pass parameters to a report, e.g. to limit the number of records shown on each of its pages</a>;<br />
- <a href="https://www.devexpress.com/Support/Center/p/E2887">How to modify report parameter values from code</a>.</p>

<br/>


