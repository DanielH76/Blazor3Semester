using BlazorTest1.Data.ApiData;
using BlazorTest1.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest1.Pages
{
    public partial class WeeklyForecast
    {
        [Inject]
        OpenWeatherService oService { get; set; }

        OpenWeatherRoot root;
        protected override async Task OnInitializedAsync()
        {
            root = await oService.Get(53, 23, null);
        }
    }
}
