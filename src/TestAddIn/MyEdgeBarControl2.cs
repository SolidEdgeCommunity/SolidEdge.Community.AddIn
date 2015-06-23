using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SolidEdgeCommunity.AddIn;

namespace TestAddIn
{
    public partial class MyEdgeBarControl2 : EdgeBarControl
    {
        public MyEdgeBarControl2()
        {
            InitializeComponent();
        }

        private void MyEdgeBarControl2_Load(object sender, EventArgs e)
        {
            // You can set the tooltip in the designer or at runtime.
            this.ToolTip = "My EdgeBar Control";

            // Trick to use the default system font.
            this.Font = SystemFonts.MessageBoxFont;
        }

        private void MyEdgeBarControl2_AfterInitialize(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
