﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Models
{
    internal class Functions
    {
        public int Sum(params int[] values)
            => values.Sum();
    }
}
