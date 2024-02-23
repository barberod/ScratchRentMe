using ScratchRentMe.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls
{

    public partial class DummyUserControl : UserControl
    {
        public new Dictionary<string, object> Tag { get; set; }
        public Dummy GivenDummy { get; set; }

        public DummyUserControl(object tag)
        {
            InitializeComponent();
            Tag = (Dictionary<string, object>)tag;
            GivenDummy = (Dummy)Tag["dummy"];
            Load += DummyUserControl_Load;
        }

        private void DummyUserControl_Load(object sender, EventArgs e)
        {
            label1.Text = GivenDummy.Name;
        }
    }
}
