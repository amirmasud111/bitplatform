﻿using Bit.Websites.Careers.Shared.Dtos.Account;

namespace Bit.Websites.Careers.Web.Components
{
    public partial class CareerBox
    {
        [Parameter]
        public CareerDto CareerModel { get; set; }
    }
}