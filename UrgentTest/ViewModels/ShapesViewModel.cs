using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrgentTest.Models;

namespace UrgentTest.ViewModels
{
    public class ShapesViewModel
    {
        public Rectangle Rectangles { get; set; }
        public Square Squares { get; set; }
        public Ellipse Ellipses { get; set; }
        public Circle Circles { get; set; }
        public Textbox Textboxes { get; set; }

    }
}
