using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webXD.Navigate(txtURL.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webXD.GoBack();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webXD.DocumentText = "Buenos Dias :D";
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webXD.Refresh();
        }
    }
}
