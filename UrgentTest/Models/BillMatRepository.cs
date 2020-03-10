using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrgentTest.ViewModels;

namespace UrgentTest.Models
{
    public class BillMatRepository : IBillMatRepository
    {
        public BillofMaterial GenerateBill(ShapesViewModel shapes)
        {
            
            BillofMaterial billofMaterial = new BillofMaterial();
            List<string> materials = new List<string>();
            string rectangle = "";
            string square = "";
            string ellipse = "";
            string circle = "";
            string textbox = "";
            rectangle = "Rectangle (" + shapes.Rectangles.PositionX.ToString() + "," + shapes.Rectangles.PositionY.ToString() + ") width=" + shapes.Rectangles.Width.ToString() + " height=" + shapes.Rectangles.Height.ToString() + "";
            materials.Add(rectangle);
            square = "Square (" + shapes.Squares.PositionX.ToString() + "," + shapes.Squares.PositionY.ToString() + ") size=" + shapes.Squares.Width.ToString() + "";
            materials.Add(square);
            ellipse = "Ellipse (" + shapes.Ellipses.PositionX.ToString() + "," + shapes.Ellipses.PositionY.ToString() + ") diameterH = " + shapes.Ellipses.HorizontalDiameter.ToString() + " diameterV = " + shapes.Ellipses.VerticalDiameter.ToString() + "";
            materials.Add(ellipse);
            circle = "Circle (" + shapes.Circles.PositionX.ToString() + "," + shapes.Circles.PositionY.ToString() + ") size=" + shapes.Circles.Diameter.ToString() + "";
            materials.Add(circle);
            if (shapes.Textboxes.Text == null)
            {
                shapes.Textboxes.Text = "";
            }
            textbox = "Textbox (" + shapes.Textboxes.PositionX.ToString() + "," + shapes.Textboxes.PositionY.ToString() + ") width=" + shapes.Textboxes.Width.ToString() + " height=" + shapes.Textboxes.Height.ToString() + " text=\"" + shapes.Textboxes.Text.ToString() + "\"";
            materials.Add(textbox);
            billofMaterial.Materials = materials;

            throw new System.ArgumentException("Parameter cannot be null", "original");

            return billofMaterial;
        }

        public BillofMaterial ThrowAbort()
        {
            BillofMaterial billofMaterial = new BillofMaterial();
            List<string> materials = new List<string>();
            string Abort = "+++++Abort+++++";
            materials.Add(Abort);
            billofMaterial.Materials = materials;

            return billofMaterial;
        }
    }
}
