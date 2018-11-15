<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [_GridView.cshtml](./CS/Views/Home/_GridView.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [_Layout.cshtml](./CS/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# How to bind GridView extension to a Model filtered by a range of dates in MVC 3 (Razor)


<p>The example covers the following topics:<br />
- the GridView extension is bound to a DataSet that is filtered by external editors;<br />
- when a callback is performed, the grid's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_BeginCallbacktopic"><u>ASPxClientGridView.BeginCallback</u></a> event is handled. In the MVC GridView extension, it is possible to transmit client-side values as callback arguments to a Controller's Action, returning a Partial View;<br />
- jQuery asynchronous requests are not able to serialize the Date, and thus the serialization should be performed manually;<br />
- a DateTime object is created from a serialized string using the <a href="http://msdn.microsoft.com/en-us/library/system.datetime.parseexact.aspx"><u>DateTime.ParseExact</u></a> method;<br />
- custom resources (scripts and CSS files) are compressed using the HTTP Handler as demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E1900">How to compress and merge custom CSS and JavaScript files using ASPxHttpHandlerModule</a>example.</p>

<br/>


