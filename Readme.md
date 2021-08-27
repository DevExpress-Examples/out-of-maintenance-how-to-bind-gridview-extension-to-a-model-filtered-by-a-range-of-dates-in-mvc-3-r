<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551059/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3096)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [_GridView.cshtml](./CS/Views/Home/_GridView.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [_Layout.cshtml](./CS/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# How to bind GridView extension to a Model filtered by a range of dates in MVC 3 (Razor)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3096/)**
<!-- run online end -->


<p>The example covers the following topics:<br />
- the GridView extension is bound to a DataSet that is filtered by external editors;<br />
- when a callback is performed, the grid's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_BeginCallbacktopic"><u>ASPxClientGridView.BeginCallback</u></a> event is handled. In the MVC GridView extension, it is possible to transmit client-side values as callback arguments to a Controller's Action, returning a Partial View;<br />
- jQuery asynchronous requests are not able to serialize the Date, and thus the serialization should be performed manually;<br />
- a DateTime object is created from a serialized string using the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime.parseexact?view=net-5.0"><u>DateTime.ParseExact</u></a> method;<br />
- custom resources (scripts and CSS files) are compressed using the HTTP Handler as demonstrated in the <a href="https://www.devexpress.com/Support/Center/p/E1900">How to compress and merge custom CSS and JavaScript files using ASPxHttpHandlerModule</a>example.</p>

<br/>


