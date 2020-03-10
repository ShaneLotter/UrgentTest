using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrgentTest.Models
{
    public class Rectangle
    {
        [Required]
        [Display(Name = "Position X")]
        public int PositionX { get; set; }

        [Required]
        [Display(Name = "Position Y")]
        public int PositionY { get; set; }

        [Required]
        [Display(Name = "Width")]
        public int Width { get; set; }

        [Required]
        [Display(Name = "Height")]
        public int Height { get; set; }
    }
    
    public class Square
    {
        [Required]
        [Display(Name = "Position X")]
        public int PositionX { get; set; }

        [Required]
        [Display(Name = "Position Y")]
        public int PositionY { get; set; }

        [Required]
        [Display(Name = "Width")]
        public int Width { get; set; }
    }

    public class Ellipse
    {
        [Required]
        [Display(Name = "Position X")]
        public int PositionX { get; set; }

        [Required]
        [Display(Name = "Position Y")]
        public int PositionY { get; set; }

        [Required]
        [Display(Name = "Horizontal Diameter")]
        public int HorizontalDiameter { get; set; }

        [Required]
        [Display(Name = "Vertical Diameter")]
        public int VerticalDiameter { get; set; }
    }

    public class Circle
    {
        [Required]
        [Display(Name = "Position X")]
        public int PositionX { get; set; }

        [Required]
        [Display(Name = "Position Y")]
        public int PositionY { get; set; }

        [Required]
        [Display(Name = "Diameter")]
        public int Diameter { get; set; }
    }

    public class Textbox
    {
        [Required]
        [Display(Name = "Position X")]
        public int PositionX { get; set; }

        [Required]
        [Display(Name = "Position Y")]
        public int PositionY { get; set; }

        [Required]
        [Display(Name = "Width")]
        public int Width { get; set; }

        [Required]
        [Display(Name = "Height")]
        public int Height { get; set; }

        [Display(Name = "Text")]
        public string Text { get; set; }
    }
}
