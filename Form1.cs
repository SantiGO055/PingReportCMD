using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Toolkit.Uwp.Notifications;

namespace FormCMD
{
    public partial class Form1 : Form
    {
        private int uno;
        private int dos;
        private int tres;
        private int cuatro;
        private bool notif = false;
        public Process proc;
        Thread t;
        delegate void CambiarProgresoDelegado(string texto, int valor);
        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ParameterizedThreadStart(executeCommand));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            uno = ValidarNumero(txtUno.Text);
            dos = ValidarNumero(txtDos.Text);
            tres = ValidarNumero(txtTres.Text);
            cuatro = ValidarNumero(txtCuatro.Text);
            //FormCancelar formCancelar = new FormCancelar();

            //formCancelar.ShowDialog();
            if (ValidarNumerosIngresados(uno, dos, tres, cuatro))
            {
                string ip;
                ip = uno + "." + dos + "." + tres + "." + cuatro;
                //this.Hide();
                if (txtDos.TextLength > 0)
                {
                    btnOk.Enabled = false;
                    t.Start("ping -t "+ ip);
                }
                    //executeCommand("ping -t " + ip);
            }
            else
            {
                MessageBox.Show("Error al ingresar la ip", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private bool checkLostPackages()
        {

            return true;
        }
        private int ValidarNumero(string numero)
        {
            if (int.TryParse(numero,out int numeroInt))
            {
                return numeroInt;
            }
            else
            {
                return 0;
            }
        }
        private bool ValidarNumerosIngresados(int uno, int dos, int tres, int cuatro)
        {
            if(uno != 0 && dos != 0 && tres != 0 && cuatro != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void executeCommand(object comando)
        {
            
            string commandR = (string)comando;

            
            try
            {
                //if (commandR == "exit")
                //{
                //    proc.StandardInput.Close();
                //}
                proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = "/c " + commandR,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                updateStatusExecution("Comando: " + commandR);
                proc.Start();


                while (!proc.StandardOutput.EndOfStream)
                {

                    string line = proc.StandardOutput.ReadLineAsync().Result;
                    if(line != null)
                    {
                        if (line.ToString().Contains("Haciendo ping a") || line.ToString().Contains("Respuesta desde") || String.IsNullOrEmpty(line) )
                        {
                            
                        }
                        else
                        {
                            //MessageBox.Show(line.ToString(), "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!this.notif)
                            {
                                Uri uriImg = new Uri("https://cdn-0.emojis.wiki/emoji-pics/facebook/pensive-face-facebook.png");
                                //this.notif = true;
                                //enviar notificacion de perdida de paquete
                                new ToastContentBuilder()
                                .AddAppLogoOverride(uriImg)
                                .AddArgument("action", "viewConversation")
                                .AddArgument("conversationId", 9813)
                                .AddText("Se ha perdido paquetes")
                                .AddText("Se perdieron paquetes " + comando)
                                .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 5, your TFM must be net5.0-windows10.0.17763.0 or greater
                            }
                            

                        }

                    }
                    updateStatusExecution(line);
                }
                
            }
            catch (Exception e)
            {
                updateStatusExecution("***Error while executing '" + commandR + "'" + " " + e);
                MessageBox.Show("El reporte ha finalizado y ha sido guardado en C:/reporte.txt", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void updateStatusExecution(String textR)
        {
            String currentDateTime = DateTime.Now.ToString(); ;
            
            guardarArchivo(textR);
            
        }
        private void guardarArchivo(string sb)
        {
            try
            {
                Directory.Exists(@"C:\reporte.txt");

                string[] arrayDirectorio = Directory.GetFiles(@"C:\", "reporte*.*");

                string pathApp = "C:\\";

                using (StreamWriter sw = new StreamWriter(@"C:\reporte.txt", true))
                {
                    sw.WriteLine("--------------------------");
                    sw.Write(sb);
                    sw.WriteLine(" | " + DateTime.Now);
                }

            }
            catch (Exception e)
            {

            }
        }

        private void txtUno_KeyDown(object sender, KeyEventArgs e)
        {
            
            //if (e.KeyCode.Equals(Keys.))
            //{
            //    textBox1.Focus();
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            executeCommand("exit");
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
                t.Abort();
            
        }

        private void txtUno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUno_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                    {
                        e.Handled = true;
            }
            if (e.KeyChar == '.'){
                e.Handled = true;
            }
            if (e.KeyChar == 46)
            {

                txtDos.Focus();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void txtDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46)
            {

                txtTres.Focus();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void txtTres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46)
            {

                txtCuatro.Focus();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOk_Click(this, new EventArgs());
            }
        }

        private void txtCuatro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == 46)
            {

                txtUno.Focus();
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOk_Click(this, new EventArgs());
            }
        }
    }
}
