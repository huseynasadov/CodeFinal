﻿using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class AccountVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public User User { get; set; }
    }
}
