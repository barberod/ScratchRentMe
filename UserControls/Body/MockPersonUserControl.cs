using ScratchRentMe.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls.Body
{
    public partial class MockPersonUserControl : UserControl
    {
        public new Dictionary<string, object> Tag { get; set; }
        public Person GivenPerson { get; set; }

        public MockPersonUserControl(object tag)
        {
            InitializeComponent();
            Tag = (Dictionary<string, object>)tag;
            GivenPerson = (Person)Tag["person"];
            Load += MockPersonUserControl_Load;
        }

        private void MockPersonUserControl_Load(object sender, EventArgs e)
        {
            label1.Text = GivenPerson.Id.ToString();
            label2.Text = GivenPerson.Name;
        }
    }
}
