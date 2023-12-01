﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal interface IHaveHeight
    {
        double GetHeight();
        void DrawHeight(PaintEventArgs e);
    }
}
