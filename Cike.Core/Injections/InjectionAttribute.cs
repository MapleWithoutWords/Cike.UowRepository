﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cike.Core.Injections
{
    public class InjectionAttribute : Attribute
    {

        public bool ReplaceService { get; set; } = false;
        public ServiceLifetime? LifeTime { get; set; }
    }
}
