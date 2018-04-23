@ModelType Example.Northwind.OrdersDataTable
@Imports System.Drawing
@Html.DevExpress().GridView(Sub(settings)
                                settings.Name = "gridView"
                                settings.KeyFieldName = "OrderID"

                                settings.Columns.Add("OrderID", MVCxGridViewColumnType.TextBox)
                                settings.Columns.Add("OrderDate", MVCxGridViewColumnType.DateEdit).CellStyle.BackColor = Color.Yellow
                                settings.Columns.Add("Freight", MVCxGridViewColumnType.TextBox)
                                settings.Columns.Add("ShipName", MVCxGridViewColumnType.TextBox)

                                settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}

                                settings.Width = Unit.Percentage(100)

                                settings.ClientSideEvents.BeginCallback = "function (s, e) {" _
                                                                        & "    e.customArgs['StartDate'] = StartDate.GetDate().toMSJSON();" _
                                                                        & "    e.customArgs['EndDate'] = EndDate.GetDate().toMSJSON();" _
                                                                        & "}"

                                settings.SettingsPager.ShowEmptyDataRows = True
                            End Sub).Bind(Model).GetHtml()