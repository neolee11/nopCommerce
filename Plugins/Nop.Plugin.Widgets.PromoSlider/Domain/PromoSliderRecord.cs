﻿using System.Collections.Generic;
using Nop.Core;

namespace Nop.Plugin.Widgets.PromoSlider.Domain
{
    public class PromoSliderRecord : BaseEntity
    {
        public PromoSliderRecord()
        {
            Images = new List<PromoImageRecord>(  );
        }
        public virtual int PromoSliderId { get; set; }
        public virtual string PromoSliderName { get; set; }
        public bool  IsActive { get; set; }

        public virtual string ZoneName { get; set; }
        public virtual int Interval { get; set; }
        public virtual bool PauseOnHover { get; set; }
        public virtual bool Wrap { get; set; }
        public virtual bool KeyBoard { get; set; }

        public virtual List<PromoImageRecord> Images { get; set; }

    }
}
