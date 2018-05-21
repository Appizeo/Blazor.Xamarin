﻿using Daddoon.Blazor.Xam.Common.Services;
using Daddoon.Blazor.Xam.InteropApp.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Daddoon.Blazor.Xam.InteropApp.UWP.Services
{
    public class XamarinBridgeProxy : IXamarinBridge
    {
        public Task DisplayAlert(string title, string msg, string cancel)
        {
            return MethodDispatcher.CallVoidMethod(MethodBase.GetCurrentMethod(), title, msg, cancel);
        }
    }
}
