using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // init
            InitializeComponent();

            // navigate to
            webBrowser.Navigate("file:///E:/contents/index.html");

            // void error
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void web_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
