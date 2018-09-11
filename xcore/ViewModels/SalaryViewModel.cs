﻿using Models;
using System;
using System.Collections.Generic;
using ViewModels;

namespace ViewModels
{
    public class SalaryViewModel : ExtensionViewModel
    {
        public Employee Employee { get; set; }

        // information search box
        public SalarySearch Search { get; set; }

        public bool RightRequest { get; set; } = false;
    }
}
