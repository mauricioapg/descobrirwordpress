using IpPublicKnowledge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescobrirWordPress
{
    public partial class fomularioPrincipal : Form
    {
        public fomularioPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUrl.Text = "http://";
        }

        private void txtUrl_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text == string.Empty)
            {
                txtUrl.Text = "http://";
            }
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            try
            {
                validarUrl(url);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                WebResponse response = request.GetResponse();
                Stream dados = response.GetResponseStream();
                StreamReader leitura = new StreamReader(dados);
                string htmlObtido = leitura.ReadToEnd();

                if (htmlObtido.Contains("wp-content") || htmlObtido.Contains("wp-includes"))
                {
                    labelResultado.Text = "Este site foi desenvolvido em WordPress";
                    labelResultado.ForeColor = Color.Green;
                }
                else
                {
                    labelResultado.Text = "Este site não foi desenvolvido em WordPress";
                    labelResultado.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validarUrl(string host)
        {
            Uri myUri = new Uri(host);
            Ping ping = new Ping();
            PingReply respostaPing = ping.Send(myUri.Host, 1000);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            labelResultado.ResetText();
            txtUrl.Text = "http://";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progresso.Increment(8);
        }
    }
}
