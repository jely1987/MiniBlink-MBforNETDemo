using System;
using MB;
using System.Windows.Forms;

namespace Print
{
    public partial class Form1 : Form
    {
        WebView m_wView = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_wView = new WebView();
            m_wView.Bind(this);
            m_wView.LoadURL("https://www.miniblink.net");
        }
    }
}
