using System.Drawing;
using System.Windows.Forms;

namespace ScratchRentMe.Models
{
    public class PanelState
    {
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public BorderStyle BorderStyle { get; set; }
        public bool Enabled { get; set; }
        public bool Visible { get; set; }
    }
}
