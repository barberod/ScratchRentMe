using ScratchRentMe.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls
{
    public partial class BlankUserControl : UserControl
    {
        public BlankUserControl(Session session = null, object target = null, Dictionary<string, object> args = null)
        {
            InitializeComponent();
        }
    }
}
