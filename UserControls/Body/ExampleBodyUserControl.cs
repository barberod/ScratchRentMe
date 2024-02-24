using ScratchRentMe.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls.Body
{
    public partial class ExampleBodyUserControl : UserControl
    {
        public ExampleBodyUserControl(Session session = null, object target = null, Dictionary<string, object> args = null)
        {
            InitializeComponent();
        }
    }
}
