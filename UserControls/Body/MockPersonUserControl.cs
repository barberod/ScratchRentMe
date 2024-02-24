using ScratchRentMe.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScratchRentMe.UserControls.Body
{
    public partial class MockPersonUserControl : UserControl
    {
        public Person Person { get; set; }
        public Dictionary<string, object> Args { get; set; }

        public MockPersonUserControl(Session session = null, object target = null, Dictionary<string, object> args = null)
        {
            InitializeComponent();
            Person = (Person)target;
            Args = args;
            Load += MockPersonUserControl_Load;
        }

        private void MockPersonUserControl_Load(object sender, EventArgs e)
        {
            label1.Text = Person.Id.ToString();
            label2.Text = Person.Name;
        }
    }
}
