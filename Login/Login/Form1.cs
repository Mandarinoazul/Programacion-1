using System.Runtime.InteropServices;


namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Importar DLL para arrastar formulario + using de System.RunTime.InteropServices
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg, int msg, int lParam);


        private void Txtusername_Enter(object sender, EventArgs e)
        {
            if (Txtusername.Text == "USUARIO")
            {
                Txtusername.Text = "";
                Txtusername.ForeColor = Color.LightGray;
            }
        }

        private void Txtusername_Leave(object sender, EventArgs e)
        {
            if (Txtusername.Text == "")
            {
                Txtusername.Text = "USUARIO";
                Txtusername.ForeColor = Color.DimGray;
            }
        }

        private void Txtpassword_Enter(object sender, EventArgs e)
        {
            if (Txtpassword.Text == "PASSWORD")
            {
                Txtpassword.Text = "";
                Txtpassword.ForeColor = Color.LightGray;
                Txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {
            if (Txtpassword.Text == "")
            {
                Txtpassword.Text = "PASSWORD";
                Txtpassword.ForeColor = Color.DimGray;
                Txtpassword.UseSystemPasswordChar = false;

            }
        }

        private void Txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            string message = "Desea cerrar la aplicacion?";
            string title = "Cerrar ventana";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }

        private void Btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panellogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}