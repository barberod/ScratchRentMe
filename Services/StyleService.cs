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
            ["backcolor:body"] = Color.WhiteSmoke,
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
            ["size:header"] = new Size(985, 60),
            ["size:toast"] = new Size(985, 30),
            ["size:sidebar"] = new Size(200, 220),
            ["size:footer"] = new Size(985, 60),
            ["size:accent"] = new Size(30, 220),
            ["size:body"] = new Size(755, 412),

            // minimumsizes
            ["minimumsize:header"] = new Size(600, 60),
            ["minimumsize:toast"] = new Size(600, 30),
            ["minimumsize:sidebar"] = new Size(200, 220),
            ["minimumsize:footer"] = new Size(600, 30),
            ["minimumsize:accent"] = new Size(30, 220),
            ["minimumsize:body"] = new Size(360, 220),

            // maximumsizes
            ["maximumsize:sidebar"] = new Size(200, 220),
            ["maximumsize:accent"] = new Size(30, 220),
        };
    }
}
