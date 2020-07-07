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

            m_wView.OnLoadUrlBegin += OnLoadUrlBegin;
            m_wView.OnLoadUrlEnd += OnLoadUrlEnd;
            m_wView.OnNetResponse += OnNetResponse;
            m_wView.OnLoadUrlFail += OnLoadUrlFail;
        }

        private void OnLoadUrlBegin(object sender, LoadUrlBeginEventArgs e)
        {
            string strMethod = null;

            switch (m_wView.GetRequestMethod(e.Job))
            {
                case wkeRequestType.Get:
                    strMethod = "GET";
                    break;

                case wkeRequestType.Post:
                    strMethod = "POST";
                    break;

                case wkeRequestType.Put:
                    strMethod = "PUT";
                    break;

                case wkeRequestType.Invalidation:
                default:
                    strMethod = "UNKNOW";
                    break;
            }
            // 插入新的网络请求


            // 删除指定的网络请求


            // 修改指定的网络请求


            // 查询指定的网络请求
        }

        private void OnLoadUrlEnd(object sender, LoadUrlEndEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnNetResponse(object sender, NetResponseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnLoadUrlFail(object sender, LoadUrlFailEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
