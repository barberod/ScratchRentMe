using ScratchRentMe.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls.Header
{
    public partial class HeaderUserControl : UserControl
    {
        public new Dictionary<string, object> Tag { get; set; }
        public User GivenUser { get; set; }

        public HeaderUserControl(object tag)
        {
            InitializeComponent();
            Tag = (Dictionary<string, object>)tag;
            GivenUser = (User)Tag["user"];
            Load += HeaderUserControl_Load;
        }

        private void HeaderUserControl_Load(object sender, EventArgs e)
        {
            label1.Text = GivenUser.Name;
        }
    }
}
