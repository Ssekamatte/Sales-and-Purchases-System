using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.ViewModel
{
    public class Alerts
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        public Alerts()
        {
            var serviceScope = ServiceActivator.GetScope();
            JSRuntime = (IJSRuntime)serviceScope.ServiceProvider.GetService(typeof(IJSRuntime));
        }
        public async Task GenerateAlert(string message)
        {
            try
            {
                await Task.Delay(600);
                await JSRuntime.InvokeVoidAsync("showAlert", message);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
