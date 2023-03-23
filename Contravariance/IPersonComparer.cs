﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contravariance
{
    public interface IPersonComparer<in T>
    {
        bool Compare(T x, T y); 
    }
}
