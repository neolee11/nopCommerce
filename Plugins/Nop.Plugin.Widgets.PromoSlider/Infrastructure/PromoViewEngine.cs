﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Web.Framework.Themes;

namespace Nop.Plugin.Widgets.PromoSlider.Infrastructure
{
    public class PromoViewEngine: ThemeableRazorViewEngine
    {
        public PromoViewEngine()
        {
            ViewLocationFormats = new[] { "~/Plugins/Widgets.PromoSlider/Views/{0}.cshtml" };
            PartialViewLocationFormats = new[] { "~/Plugins/Widgets.PromoSlider/Views/{0}.cshtml" };
        }
    }
}
