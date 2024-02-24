using ScratchRentMe.Services;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchRentMe.Models
{
    public class PanelStyle
    {
        public Color BackColor = (Color)StyleService.Styles["backcolor:default"];
        public BorderStyle BorderStyle = (BorderStyle)StyleService.Styles["borderstyle:default"];
        public Color ForeColor = (Color)StyleService.Styles["forecolor:default"];

        public PanelStyle(Color backColor, BorderStyle borderStyle, Color foreColor ) {
            this.BackColor = backColor;
            this.BorderStyle = borderStyle;
            this.ForeColor = foreColor;
        }
    }
}
