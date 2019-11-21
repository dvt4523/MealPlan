﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using Microsoft.AspNet.Identity;

namespace DotvvmApplication1.ViewModels
{
    public class MasterPageViewModel : DotvvmViewModelBase
    {
		public void SignOut()
        {
            Context.GetAuthentication().SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            Context.RedirectToRoute("Default", null, false, false);
        }
    }
}
