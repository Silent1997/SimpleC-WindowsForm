using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// this sis a test comment
            // new comment

            PopupForm popup = new PopupForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                label2.Text = "Thank you for saying hello.";
                label2.TextAlign = ContentAlignment.TopCenter;
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                label2.Text = "Have a great day!";
                label2.TextAlign = ContentAlignment.TopCenter;
            }

            popup.Dispose();
        }
    }
}
