using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal interface IHaveDiagonal
    {
        double GetDiagonal();
        void DrawDiagonal(PaintEventArgs e);
    }
}
