﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Shapes.Shapes
{
    using Interfaces;
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;
        public double Width
        { 
            get
            {
                return this.width;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("Width can't be 0 or less.");
                }
                this.width=value;
            }
        }
        public double Height
        { 
            get
            {
                return this.height;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("Height can't be 0 or less.");
                }
                this.height=value;
            }
        }
        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}