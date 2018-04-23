<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<head>
    <title>How to bind GridView extension to a Model filtered by a range of dates in MVC 3 (Razor)</title>
    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView}, _
                                      New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors} _
                                     )
    <link href="DX.ashx?cssfile=~/Content/Site.css" rel="stylesheet" type="text/css" />
    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.GridView}, _
                                  New Script With {.ExtensionSuite = ExtensionSuite.Editors} _
                                 )
</head>
<body>
    @RenderBody()
</body>
</html> 