using MB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HookNetwork
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
            m_wView.LoadURL("https://www.baidu.com/");
        }
    }
}
