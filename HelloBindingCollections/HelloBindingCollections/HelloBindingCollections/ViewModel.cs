using System.Collections.Generic;
using Xamarin.Forms;

namespace HelloBindingCollections
{
    public class ViewModel
    {
        static ViewModel()
        {
            NamedColors = new List<NamedColor>

        {
            new NamedColor{Name= "Alice Blue", Color=Color.AliceBlue},

            new NamedColor{Name= "Antique White", Color=Color.AntiqueWhite},

            new NamedColor{Name= "Aqua", Color=Color.Aqua},

            new NamedColor{Name= "Aquamarine", Color=Color.Aquamarine},

            new NamedColor{Name= "Azure", Color=Color.Azure},

            new NamedColor{Name= "Beige", Color=Color.Beige},

            new NamedColor{Name= "Bisque", Color=Color.Bisque},

            new NamedColor{Name= "Black", Color=Color.Black},

            new NamedColor{Name= "Blanched Almond", Color=Color.BlanchedAlmond},

            new NamedColor{Name= "Blue", Color=Color.Blue},

            new NamedColor{Name= "Blue Violet", Color=Color.BlueViolet},

            new NamedColor{Name= "Brown", Color=Color.Brown},

            new NamedColor{Name= "Burly Wood", Color=Color.BurlyWood},

            new NamedColor{Name= "Cadet Blue", Color=Color.CadetBlue},

            new NamedColor{Name= "Chartreuse", Color=Color.Chartreuse}

        };
        }
        public static IList<NamedColor> NamedColors { private set; get; }
    }
}
