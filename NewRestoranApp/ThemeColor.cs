using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace NewRestoranApp
{
    public static class ThemeColor
    {
      public static Color PrimaryColor { get; set; }
      public static Color SecondaryColor { get; set; }
      public static  List<string> ColorList = new List<string>()
        {
   "#3f51b5",
   "#009688",
   "#ff5722",
   "#607d8b",
   "#ff9800",
   "#9c27b0",
   "#2196f3",
   "#ea676c",
   "#e41a4a",
   "#5987bb",
   "#018790",
   "#0e3441",
   "#00b0ad",
   "#721d47",
   "#ea4833",
   "#ef937e",
   "#f37521",
   "#a12059",
   "#126881",
   "#8bc240",
   "#364d58",
   "#c7dc58",
   "#0094bc",
   "#e4126b",
   "#43b76e",
   "#7bcfe9",
   "#b71c46"};

    public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if(correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
