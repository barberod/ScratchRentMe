using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchRentMe.Services
{
    public class StyleService
    {
        public static Dictionary<string, object> Styles { get; } = new Dictionary<string, object>
        {
            // colors
            ["backcolor:body"] = Color.Black,
            ["backcolor:default"] = SystemColors.Control,
            ["backcolor:inactive"] = Color.LightGray,

            ["forecolor:body"] = SystemColors.ControlText,
            ["forecolor:default"] = SystemColors.ControlText,
            ["forecolor:inactive"] = Color.DimGray,

            // borders
            ["borderstyle:default"] = BorderStyle.None,
            ["borderstyle:inactive"] = BorderStyle.None,
            ["borderstyle:body"] = BorderStyle.Fixed3D,

            // enablement
            ["enablement:default"] = true,
            ["enablement:inactive"] = false,

            // sizes
            ["size:body"] = new Size(755, 412),

            // minimumsizes
            ["minimumsize:body"] = new Size(360, 220)
        };
    }
}
