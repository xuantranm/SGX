﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;

namespace ViewModels
{
    public class DanhGiaXCGViewModel : ExtensionViewModel
    {
        public IList<FactoryDanhGiaXCG> List { get; set; }

        #region Dropdownlist
        public IList<FactoryStage> Stages { get; set; }
        public IList<FactoryMotorVehicle> Vehicles { get; set; }
        #endregion

        #region Search
        public string cd { get; set; }

        public string xm { get; set; }

        public string rate { get; set; }

        public DateTime? from { get; set; }

        public DateTime? to { get; set; }

        public int page { get; set; }

        public int size { get; set; }

        public string sortField { get; set; }

        public string sort { get; set; }
        #endregion

        public int Records { get; set; }

        public int Pages { get; set; }
    }
}
