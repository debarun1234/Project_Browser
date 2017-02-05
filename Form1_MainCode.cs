/// Please note that some of the codes are repeated and some are sot recognizable
/// Please delete those section when copying

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void newWIndowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                                
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("This is made by Debarun Ghosh. It is a the first browser app and there will be more updates in the year long enjoy the app.");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label1.Text = webBrowser1.Url.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            label2.Text = webBrowser1.StatusText;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void homeButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
