﻿using SERVICE.DAL.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Factory
{
    internal static class ServiceFactory
    {
        public static LanguageRepository LanguageRepository { get; private set; }

    }
}
