// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sales.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Sales.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Syncfusion.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\MVC Projects\Blazor project\Sales\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using Sales.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using Sales.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using Sales.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Purchases")]
    public partial class Purchases : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 148 "C:\MVC Projects\Blazor project\Sales\Pages\Purchases.razor"
       
    #region Toasters
    public static string ToastContent { get; set; }
    SfToast ToastObj;
    SfToast DeleteToastObj;
    SfToast ConfirmPricesToastObj;
    private string ToastPosition = "Right";
    private int AlarmTimeout { get; set; } = 120000;
    private List<ToastModel> Toast = new List<ToastModel>
{
        new ToastModel{ Title = "Warning!", Content=ToastContent, CssClass="e-toast-warning", Icon="e-warning toast-icons" },
        new ToastModel{ Title = "Success!", Content=ToastContent, CssClass="e-toast-success", Icon="e-success toast-icons" },
        new ToastModel{ Title = "Error!", Content=ToastContent, CssClass="e-toast-danger", Icon="e-error toast-icons" },
        new ToastModel{ Title = "Information!", Content=ToastContent, CssClass="e-toast-info", Icon="e-info toast-icons" }
    };
    #endregion Toasters
    private static ViewPurchase sal { get; set; }
    #region DropDowns
    public static List<AUnit> units { get; set; }
    public static List<AStock> products { get; set; }
    #endregion DropDowns

    protected override async Task OnInitializedAsync()
    {
        units = context.AUnits.ToList();
        products = context.AStocks.ToList();
    }
    public SfGrid<ViewPurchase> PurchasesGrid;


    public void Refresh()
    {
        PurchasesGrid.Refresh();
    }
    public void OnProductChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string,AStock> args)
    {
        var product = args.ItemData.UnitId;
        sal.UnitId = product;
        //AmountDisbursed = (decimal)args.Value;
        //InterestDue = (InterestRate / 100) * LoanPeriod * AmountDisbursed;
        //TotalLoanInterestAmount = InterestDue + AmountDisbursed;
        //MonthlyPayment = TotalLoanInterestAmount / LoanPeriod;
        StateHasChanged();

    }

    private Boolean Check = false;
    private DialogSettings DialogParams = new DialogSettings { MinHeight = "400px", Width = "550px" };
    public DateTime MinExpiryDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
    public DateTime MinDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
    public DateTime MaxDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

    // Customise dialogtemplate header
    public IWebHostEnvironment hostingEnv;
    public string Header { get; set; }
    public string ButtonText { get; set; }
    SfSpinner SpinnerObj;

    public SfTextBox Prodname;
    public SfTextBox ProdId;
    //public string ProId { get; set; } = "oooo-oooo";
    //public string ProductId;
    SfDatePicker<DateTime?> ManDate;
    SfDatePicker<DateTime?> ExpDate;
    SfNumericTextBox<decimal?> ProdPurchPrice { get; set; }
    SfNumericTextBox<decimal?> ProdSellPrice { get; set; }
    SfNumericTextBox<decimal?> Qtty { get; set; }
    SfDropDownList<string, AUnit> UnityId { get; set; }

    public string GetHeader(ViewPurchase Value)
    {
        if (Value.ProductId == null)
        {
            Value.ProductId = GetID();
            ButtonText = "Insert";
            return "Add a new Purchase";
        }
        else
        {
            ButtonText = "Save Changes";
            return "Edit Details for " + Value.StockProductName;
        }
    }
    public class PurchasesRoutineAdapter : DataAdaptor
    {
        String result = string.Empty;
        public string message = string.Empty;
        public IJSRuntime jsRuntime;
        public UserManagement user;
        public IToastService toastService;

        public PurchasesRoutineAdapter(IJSRuntime jSRuntime, UserManagement _user, IToastService ts)
        {
            jsRuntime = jSRuntime;
            user = _user;
            toastService = ts;
        }

        ViewModel.AlertMessageType messageType = ViewModel.AlertMessageType.Error;

        public override object Read(DataManagerRequest dm, string key = null)
        {
            using (var _context = new SalesPurchasesContext())
            {
                var _data = _context.ViewPurchases.OrderByDescending(a => a.AddedDate).ToList();
                IEnumerable DataSource = _data;
                //int count = _data.Count;

                if (dm.Search != null && dm.Search.Count > 0)
                {
                    // Searching
                    DataSource = DataOperations.PerformSearching(DataSource, dm.Search);
                }
                if (dm.Sorted != null && dm.Sorted.Count > 0)
                {
                    // Sorting
                    DataSource = DataOperations.PerformSorting(DataSource, dm.Sorted);
                }
                if (dm.Where != null && dm.Where.Count > 0)
                {
                    // Filtering
                    DataSource = DataOperations.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);
                }
                int count = DataSource.Cast<ViewPurchase>().Count();
                if (dm.Skip != 0)
                {
                    //Paging
                    DataSource = DataOperations.PerformSkip(DataSource, dm.Skip);
                }
                if (dm.Take != 0)
                {
                    DataSource = DataOperations.PerformTake(DataSource, dm.Take);
                }

                return dm.RequiresCounts ? new DataResult() { Result = DataSource, Count = count } : (object)DataSource;
            }
        }
        public override object Update(DataManager dataManager, object value, string keyField, string key)
        {
            using (var _context = new SalesPurchasesContext())
            {
                var val = (value as ViewPurchase);
                var exist = _context.AProducts.FirstOrDefault(o => o.ProductId == val.ProductId);
                if (exist != null)
                {
                    exist.ProductName = val.ProductName;
                    exist.ManufactureDate = val.ManufactureDate;
                    exist.ExpiryDate = val.ExpiryDate;
                    exist.ProductPurchasePrice = val.ProductPurchasePrice;
                    exist.ProductSellingPrice = val.ProductSellingPrice;
                    exist.Quantity = val.Quantity;
                    exist.UnitId = val.UnitId;

                    _context.Entry(exist).State = EntityState.Modified;
                    _context.SaveChanges();

                    string result = "Record Updated Successfully";
                    toastService.ShowInfo(result);

                    AProductLog sallog = new AProductLog();
                    //Save Into Log Table
                    sallog.ProductLogId = Guid.NewGuid().ToString();
                    sallog.ProductId = val.ProductId;
                    sallog.ProductName = val.ProductName;
                    sallog.ManufactureDate = val.ManufactureDate;
                    sallog.ExpiryDate = val.ExpiryDate;
                    sallog.ProductPurchasePrice = val.ProductPurchasePrice;
                    sallog.ProductSellingPrice = val.ProductSellingPrice;
                    sallog.Quantity = val.Quantity;
                    sallog.UnitId = val.UnitId;
                    sallog.UpdatedBy = user.GetStaffName();
                    sallog.UpdatedDate = DateTime.Now;

                    _context.AProductLogs.Add(sallog);
                    _context.SaveChanges();

                }
                return value;
            }
        }
        public override object Remove(DataManager dataManager, object value, string keyField, string key)
        {
            using (var _context = new SalesPurchasesContext())
            {

                //var delData = data.GetAllOrders().Where(x => x.MemberId == (string)value).FirstOrDefault();
                var delData = _context.AProducts.Where(x => x.ProductId == (string)value).FirstOrDefault();
                _context.AProducts.Remove(delData);
                _context.SaveChanges();

                string result = "Record Deleted Successfully";
                toastService.ShowInfo(result);

                //data.DeleteOrder((int)value);
                return delData;
            }

        }
        public override async Task<Object> InsertAsync(DataManager dataManager, object value, string key)
        {
            using (var _context = new SalesPurchasesContext())
            {
                var val = (value as ViewPurchase);
                AProduct reg = new AProduct();
                AProductLog reglog = new AProductLog();
                var exist = _context.AProducts.FirstOrDefault(o => o.ProductName == val.ProductName);

                if (exist != null)
                {
                    exist.ProductName = val.ProductName;
                    exist.ManufactureDate = val.ManufactureDate;
                    exist.ExpiryDate = val.ExpiryDate;
                    exist.ProductPurchasePrice = val.ProductPurchasePrice;
                    exist.ProductSellingPrice = val.ProductSellingPrice;
                    exist.Quantity = GetQuantityID() + val.Quantity;
                    exist.UnitId = val.UnitId;
                    exist.PurchasedBy = user.GetStaffName();
                    exist.PurchaseDate = DateTime.Now;
                    exist.AddedBy = user.GetStaffName();
                    exist.AddedDate = DateTime.Now;
                    _context.Entry(exist).State = EntityState.Modified;
                    _context.SaveChanges();

                    //Save Into Log Table
                    reglog.ProductLogId = Guid.NewGuid().ToString();
                    reglog.ProductId = exist.ProductId;
                    reglog.ProductName = val.ProductName;
                    reglog.ManufactureDate = val.ManufactureDate;
                    reglog.ExpiryDate = val.ExpiryDate;
                    reglog.ProductPurchasePrice = val.ProductPurchasePrice;
                    reglog.ProductSellingPrice = val.ProductSellingPrice;
                    reglog.Quantity = GetQuantityID() + val.Quantity; ;
                    reglog.UnitId = val.UnitId;

                    reglog.UpdatedBy = user.GetStaffName();
                    reglog.UpdatedDate = DateTime.Now;

                    _context.AProductLogs.Add(reglog);
                    await _context.SaveChangesAsync();

                    string result = "Record Updated Successfully";
                    toastService.ShowInfo(result);
                }
                else {
                    try
                    {
                        reg.ProductId = Guid.NewGuid().ToString();
                        reg.ProductName = val.ProductName;
                        reg.ManufactureDate = val.ManufactureDate;
                        reg.ExpiryDate = val.ExpiryDate;
                        reg.ProductPurchasePrice = val.ProductPurchasePrice;
                        reg.ProductSellingPrice = val.ProductSellingPrice;
                        reg.Quantity = val.Quantity;
                        reg.UnitId = val.UnitId;
                        reg.PurchasedBy = user.GetStaffName();
                        reg.PurchaseDate = DateTime.Now;
                        reg.AddedBy = user.GetStaffName();
                        reg.AddedDate = DateTime.Now;

                        //Save Into Log Table
                        reglog.ProductLogId = Guid.NewGuid().ToString();
                        reglog.ProductId = reg.ProductId;
                        reglog.ProductName = val.ProductName;
                        reglog.ManufactureDate = val.ManufactureDate;
                        reglog.ExpiryDate = val.ExpiryDate;
                        reglog.ProductPurchasePrice = val.ProductPurchasePrice;
                        reglog.ProductSellingPrice = val.ProductSellingPrice;
                        reglog.Quantity = val.Quantity;
                        reglog.UnitId = val.UnitId;

                        reglog.AddedBy = user.GetStaffName();
                        reglog.AddedDate = DateTime.Now;
                        reglog.UpdatedBy = user.GetStaffName();
                        reglog.UpdatedDate = DateTime.Now;

                        try
                        {
                            _context.AProducts.Add(reg);
                            _context.AProductLogs.Add(reglog);
                            await _context.SaveChangesAsync();

                            string result = "Record Saved Successfully";
                            toastService.ShowInfo(result);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            return value;
        }

    }

    private async void ConfirmYesBtnclick()
    {
        await SpinnerObj.ShowAsync();

        using (var _context = new SalesPurchasesContext())
        {

            AProduct reg = new AProduct();
            AProductLog reglog = new AProductLog();
            ViewPurchase regview = new ViewPurchase();

            var exist = _context.AProducts.FirstOrDefault(o => o.ProductId == ProdId.Value.ToString());

            if (exist == null)
            {

                reg.ProductId = Guid.NewGuid().ToString();
                reg.ProductName = sal.ProductName;

                //check if date are not null
                DateTime? manufacture_date = null;
                DateTime? expiry_date = null;

                if (ManDate.Value != null && ExpDate.Value != null)
                {
                    reg.ManufactureDate = ManDate.Value;
                    reg.ExpiryDate = ExpDate.Value;
                }

                reg.ProductPurchasePrice = ProdPurchPrice.Value;
                reg.ProductSellingPrice = ProdSellPrice.Value;
                reg.UnitId = UnityId.Value.ToString();
                reg.Quantity = Qtty.Value;
                reg.PurchasedBy = user.GetStaffName();
                reg.PurchaseDate = DateTime.Now;

                //Save Into Log Table
                reglog.ProductLogId = Guid.NewGuid().ToString();
                reglog.ProductId = reg.ProductId;
                reglog.ProductName = sal.ProductName;
                if (ManDate.Value != null && ExpDate.Value != null)
                {
                    reglog.ManufactureDate = ManDate.Value;
                    reglog.ExpiryDate = ExpDate.Value;
                }
                reglog.ProductPurchasePrice = ProdPurchPrice.Value;
                reglog.ProductSellingPrice = ProdSellPrice.Value;
                reglog.Quantity = Qtty.Value;
                reglog.UnitId = UnityId.Value.ToString();

                reglog.AddedBy = user.GetStaffName();
                reglog.AddedDate = DateTime.Now;

                try
                {
                    _context.AProducts.Add(reg);
                    _context.AProductLogs.Add(reglog);
                    await _context.SaveChangesAsync();
                    PurchasesGrid.CloseEdit();
                    Refresh();
                    await this.ConfirmPricesToastObj.Hide();

                    await this.ToastObj.Show(new ToastModel { Title = "Record Saved", Content = "Record saved succesfully ", CssClass = "e-toast-success", Icon = "e-success toast-icons" });

                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }

            else if (exist != null) {

                exist.ProductName = sal.ProductName;

                //check if date are not null
                DateTime? manufacture_date = null;
                DateTime? expiry_date = null;

                if (ManDate.Value != null && ExpDate.Value != null)
                {
                    exist.ManufactureDate = ManDate.Value;
                    exist.ExpiryDate = ExpDate.Value;
                }

                exist.ProductPurchasePrice = ProdPurchPrice.Value;
                exist.ProductSellingPrice = ProdSellPrice.Value;
                exist.UnitId = UnityId.Value.ToString();
                exist.Quantity = Qtty.Value;
                exist.PurchasedBy = user.GetStaffName();
                exist.PurchaseDate = DateTime.Now;

                //Save Into Log Table
                reglog.ProductLogId = Guid.NewGuid().ToString();
                reglog.ProductId = ProdId.Value.ToString();
                reglog.ProductName = sal.ProductName;
                if (ManDate.Value != null && ExpDate.Value != null)
                {
                    reglog.ManufactureDate = ManDate.Value;
                    reglog.ExpiryDate = ExpDate.Value;
                }

                reglog.ProductPurchasePrice = ProdPurchPrice.Value;
                reglog.ProductSellingPrice = ProdSellPrice.Value;
                reglog.Quantity = Qtty.Value;
                reglog.UnitId = UnityId.Value.ToString();

                reglog.UpdatedBy = user.GetStaffName();
                reglog.UpdatedDate = DateTime.Now;

                try
                {
                    _context.Entry(exist).State = EntityState.Modified;
                    _context.SaveChanges();
                    _context.AProductLogs.Add(reglog);
                    await _context.SaveChangesAsync();
                    PurchasesGrid.CloseEdit();
                    Refresh();
                    await this.ConfirmPricesToastObj.Hide();

                    await this.ToastObj.Show(new ToastModel { Title = "Record Saved", Content = "Record updated succesfully ", CssClass = "e-toast-success", Icon = "e-success toast-icons" });

                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }

        }
    }

    private async void ConfirmNoBtnclick()
    {
        try
        {
            await this.ConfirmPricesToastObj.Hide();
        }
        catch (Exception ex)
        {
            await this.ToastObj.Show(new ToastModel { Title = "Error!", Content = ex.ToString(), CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
        }
    }
    //Assign Default Value To Product ID
    public string GetID()
    {
        int result = 0;
        using (var _context = new SalesPurchasesContext())
        {
            result = _context.AProducts.ToList().Count();
            string code = "ooooo-ooooo-oooo-oooo-oooooooooooo";
            var pay = new AProduct()
            {ProductId = code };
            return code;
        }
    }

    public async void PurActionBeginHandler(ActionEventArgs<ViewPurchase> Args)
    {
        var data = Args.Data;

        if (Args.RequestType == Syncfusion.Blazor.Grids.Action.Save)
        {
            //Check if a Column is not Null Before You Save
            if (data.ProductName == null)
            {
                await this.ToastObj.Show(new ToastModel { Title = "Error!", Content = "Please Enter the Product Name!", CssClass = "e-toast-danger", Icon = "e-error toast-icons" });
                Args.Cancel = true;
            }

            else if ((Args.Data.ProductPurchasePrice) > (Args.Data.ProductSellingPrice))
            {
                await this.ConfirmPricesToastObj.Show();
                Args.Cancel = true;
            }

            else if((Args.Data.ManufactureDate) >= (Args.Data.ExpiryDate))
            {
                await this.ToastObj.Show(new ToastModel { Title = "Warning!", Content = "Date of Expiry has to be after the date of Manufacture!", CssClass = "e-toast-warning", Icon = "e-error toast-icons" });
                Args.Cancel = true;
            }
        }
    }

    public void CustomizeCell(QueryCellInfoEventArgs<ViewPurchase> Args)
    {
        if (Args.Column.Field == "ProfitorLoss")
        {
            if ((Args.Data.ProductPurchasePrice) > (Args.Data.ProductSellingPrice))
            {
                Args.Cell.AddClass(new string[] { "Loss" });
            }
            else if ((Args.Data.ProductPurchasePrice) < (Args.Data.ProductSellingPrice))
            {
                Args.Cell.AddClass(new string[] { "Profit" });
            }
            else
            {
                Args.Cell.AddClass(new string[] { "BalancedPrice" });
            }
        }
    }

    public static decimal GetQuantityID()
    {
        using (var dbContext = new SalesPurchasesContext())
        {
            decimal count = 1;
            var councode = dbContext.AProducts.OrderByDescending(o => o.Quantity).FirstOrDefault(z => z.ProductName == sal.ProductName);
            if (councode != null)
            {
                count = Convert.ToDecimal(councode.Quantity);
            }
            return (Convert.ToInt32(count));
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManagement user { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SalesPurchasesContext context { get; set; }
    }
}
#pragma warning restore 1591