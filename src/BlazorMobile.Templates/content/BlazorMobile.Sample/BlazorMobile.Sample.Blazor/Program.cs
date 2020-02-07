﻿using BlazorMobile.Common;
using BlazorMobile.Common.Services;
using BlazorMobile.Sample.Blazor.Helpers;
using Microsoft.AspNetCore.Blazor.Hosting;
using System;
using System.Threading.Tasks;

namespace BlazorMobile.Sample.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            #region Services registration

            ServicesHelper.ConfigureCommonServices(builder.Services);

            #endregion

            #region DEBUG

            //Only if you want to test WebAssembly with remote debugging from a dev machine
            BlazorMobileService.EnableClientToDeviceRemoteDebugging("127.0.0.1", 8888);

            #endregion

            BlazorMobileService.Init((bool success) =>
            {
                Console.WriteLine($"Initialization success: {success}");
                Console.WriteLine("Device is: " + BlazorDevice.RuntimePlatform);
            });

            builder.RootComponents.Add<MobileApp>("app");

            await builder.Build().RunAsync();
        }
    }
}
