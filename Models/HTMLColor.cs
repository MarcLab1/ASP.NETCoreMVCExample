using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRandomHTMLColor.Models
{
   
    public class HTMLColor
    {
        private readonly int opaque = 255;
        private Random rando = new Random();

        public HTMLColor()
        {
            red = rando.Next(0, 255);
            blue = rando.Next(0, 255);
            green = rando.Next(0, 255);
            color = Color.FromArgb(opaque, red, green, blue);
            colorHex = "#"+ red.ToString("X") + green.ToString("X") + blue.ToString("X");
            colorRBG = red + ", " + green + ", " + blue;
        }

        public HTMLColor(int r, int g, int b)
        {
            red = r;
            blue = b;
            green = g;
            color = Color.FromArgb(opaque, red, green, blue);
            colorHex = "#" + red.ToString("X") + green.ToString("X") + blue.ToString("X");
            colorRBG = red + ", " + green + ", " + blue;
        }
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }

        public string colorHex { get; set; }
       
        public Color color { get; }

        public String colorRBG { get; set; }
    }
}

