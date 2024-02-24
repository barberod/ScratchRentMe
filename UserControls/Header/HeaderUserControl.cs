using ScratchRentMe.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls.Header
{
    public partial class HeaderUserControl : UserControl
    {
        public User User { get; set; }
        public Dictionary<string, object> Args { get; set; }

        public HeaderUserControl(Session session = null, object target = null, Dictionary<string, object> args = null)
        {
            InitializeComponent();
            User = (User)target;
            Args = args;
            Load += HeaderUserControl_Load;
        }

        private void HeaderUserControl_Load(object sender, EventArgs e)
        {
            label1.Text = User.Name;
        }
    }
}
