using ScratchRentMe.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls.Footer
{
    public partial class FooterUserControl : UserControl
    {
        public FooterUserControl(Session session = null, object target = null, Dictionary<string, object> args = null)
        {
            InitializeComponent();
        }
    }
}
