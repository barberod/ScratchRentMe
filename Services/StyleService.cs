using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchRentMe.Services
{
    public static class StyleService
    {
        public static Dictionary<string, object> Styles { get; } = new Dictionary<string, object>
        {
            // colors
            ["backcolor:body"] = Color.WhiteSmoke,
            ["backcolor:default"] = SystemColors.Control,
            ["backcolor:inactive"] = Color.LightGray,

            ["forecolor:body"] = SystemColors.ControlText,
            ["forecolor:default"] = SystemColors.ControlText,
            ["forecolor:inactive"] = Color.DimGray,

            ["custom:dark"] = Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227))))),

            // borders
            ["borderstyle:default"] = BorderStyle.None,
            ["borderstyle:inactive"] = BorderStyle.None,
            ["borderstyle:body"] = BorderStyle.Fixed3D,

            // sizes
            ["size:header"] = new Size(800, 60),
            ["size:toast"] = new Size(800, 30),
            ["size:sidebar"] = new Size(200, 220),
            ["size:footer"] = new Size(800, 60),
            ["size:accent"] = new Size(50, 220),
            ["size:body"] = new Size(550, 300),

            // minimumsizes
            ["size:header"] = new Size(650, 60),
            ["size:toast"] = new Size(650, 30),
            ["size:sidebar"] = new Size(200, 220),
            ["size:footer"] = new Size(650, 60),
            ["size:accent"] = new Size(50, 220),
            ["size:body"] = new Size(400, 220),

            // maximumsizes
            ["maximumsize:sidebar"] = new Size(200, 220),
            ["maximumsize:accent"] = new Size(30, 220)
        };
    }
}
