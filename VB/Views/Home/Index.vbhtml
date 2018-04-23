@ModelType Example.OrdersModel
<table summary="Personal Movie Rating" class="myTable">
    <thead>
        <tr>
            <th scope="col" class="myHeader">
                Start Date:
            </th>
            <th scope="col" class="myHeader">
                End Date:
            </th>
            <th scope="col" class="myHeader">
                Get Results:
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td class="myCell">
                @Html.DevExpress().DateEdit(Sub(settings)
                                                settings.Name = "StartDate"

                                                settings.Properties.MinDate = Model.MinDate
                                                settings.Properties.MaxDate = Model.MaxDate

                                                settings.Properties.Width = Unit.Percentage(100)
                                            End Sub).Bind(Model.StartDate).GetHtml()
            </td>
            <td class="myCell">
                @Html.DevExpress().DateEdit(Sub(settings)
                                                settings.Name = "EndDate"

                                                settings.Properties.MinDate = Model.MinDate
                                                settings.Properties.MaxDate = Model.MaxDate

                                                settings.Properties.Width = Unit.Percentage(100)

                                                settings.Properties.ValidationSettings.EnableCustomValidation = True
                                                settings.Properties.ValidationSettings.Display = Display.Dynamic
                                                settings.Properties.ClientSideEvents.Validation = "function (s, e) { e.isValid = e.value >= StartDate.GetValue(); e.errorText = 'The End Date value is less than the Start Date'; }"
                                            End Sub).Bind(Model.EndDate).GetHtml()
            </td>
            <td class="myCell">
                @Html.DevExpress().Button(Sub(settings)
                                              settings.Name = "btn"
                                              settings.Text = "Apply"
                                              settings.Width = Unit.Percentage(100)
                                              settings.CausesValidation = True
                                              settings.ClientSideEvents.Click = "function (s, e) {" _
                                                     & "  if (!ASPxClientEdit.ValidateGroup (''))" _
                                                     & "    return;" _
                                                     & "  startDate = StartDate.GetDate();" _
                                                     & "  endDate = EndDate.GetDate();" _
                                                     & "  gridView.Refresh();" _
                                                     & "}"
                                                  
                                          End Sub).GetHtml()
            </td>
        </tr>
        <tr>
            <td class="myGridCell" colspan="3">
                @Html.Partial("_GridView", Model.Data)
            </td>
        </tr>
    </tbody>
</table>
<script type="text/javascript">
    var startDate = StartDate.GetDate(),
        endDate = EndDate.GetDate();

    Date.prototype.toMSJSON = function () {
        var date = '"\\\/Date(' + this.getTime() + ')\\\/"';
        return date;
    };
</script>
