﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle rectangle =
                new System.Drawing.Rectangle
                (
                    Console.WindowLeft, Console.WindowTop,
                    Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, rectangle);

            Rectangle rect = new Rectangle(200, 150, 300, 50, 1, Color.AliceBlue);
            rect.Info(e);

            Square square = new Square(50, 350, 250, 2, Color.Red);
            square.Info(e);

            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(250, 700, 50, 3, Color.Green);
            equilateralTriangle.Info(e);
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
    }
    }
    
}
