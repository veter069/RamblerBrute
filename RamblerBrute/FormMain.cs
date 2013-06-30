using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using RamblerBrute.Properties;


//using Microsoft.VisualBasic;

namespace RamblerBrute
{
    public partial class BtnStart : Form
    {
        public static Checker _check1 = new Checker();
        public BtnStart()
        {
            InitializeComponent();
        }

        private void BtnStart_Load(object sender, EventArgs e)
        {
        }
        private void source_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog {Filter = Resources.BtnStart_source_Click____txt_____txt};
            openFile.ShowDialog();

            if (openFile.FileName != "")
            {
                Globals.Source.Clear();
                Globals.Source.AddRange(File.ReadAllLines(openFile.FileName));
                Globals.CountSource = Globals.Source.Count;
            }
            else
            {
                MessageBox.Show(Resources.BtnStart_source_Click_Выбери_файл__сцуко_);
            }
        }

        private void proxy_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog {Filter = Resources.BtnStart_source_Click____txt_____txt};
            openFile.ShowDialog();

            if (openFile.FileName != "")
            {
                Globals.Proxy.Clear();
                Globals.Proxy.AddRange(File.ReadAllLines(openFile.FileName));
                Globals.CountProxy = Globals.Proxy.Count;
            }
            else
            {
                MessageBox.Show(Resources.BtnStart_source_Click_Выбери_файл__сцуко_);
            }
        }

        private void proxytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbproxytype.Text == Resources.BtnStart_proxytype_SelectedIndexChanged_HTTP)
            {
                Globals.TypeProxy = 1;
            }else if (Cbproxytype.Text == Resources.BtnStart_proxytype_SelectedIndexChanged_Socks_4)
            {
                Globals.TypeProxy = 2;
            }
            else if (Cbproxytype.Text == Resources.BtnStart_proxytype_SelectedIndexChanged_Socks_5)
            {
                Globals.TypeProxy = 3;
            }
        }

        private void txtDelimeter_TextChanged(object sender, EventArgs e)
        {
            Globals.TxtDelimiter = txtDelimeter.Text;
        }

        private void GUI_Tick(object sender, EventArgs e)
        {
            string stat = "";
            stat += "Source: " + Globals.CountSource + Environment.NewLine;
            stat += "Proxy: " + Globals.CountProxy + Environment.NewLine;
            stat += "Good: " + Globals.CountGood + Environment.NewLine;
            stat += "Bad: " + Globals.CountBad + Environment.NewLine;
            stat += "PPS: " + Globals.Pps + Environment.NewLine;
            txtLog.Text = stat;
            if (_check1.AliveThreads() == 0)
            {
                _check1.StopThreads();
                Start.Text = @"Start";
            }
            Globals.Pps = 0;
        }

        private void Start_Click(object sender, EventArgs e)
        {    
           
            Globals.CountThreads = (int)nThreads.Value;
            if (_check1.AliveThreads()>0 )
            {
                _check1.StopThreads();
                Start.Text = @"Start";
            }
            else
            {
                _check1.CreateThreads();
                Start.Text = @"Stop";
            }
            //_check1.CreateThreads();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://forum.k0d.cc/");
        }

        void nThreads_ValueChanged(object sender, EventArgs e)
        {
            
        }


    }
}
