using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermarket
{
	public partial class Loginform : Form
	{
		public Loginform()
		{
			InitializeComponent();
			this.MouseDown += Loginform_MouseDown;
		}
		// to move the form freely in window.
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HTCAPTION = 0x2;

		private void Loginform_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void guna2CircleButton1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Text_Box_username_TextChanged(object sender, EventArgs e)
		{

		}

		private void Button_login_Click(object sender, EventArgs e)
		{

		}

		private void label_clear_Click(object sender, EventArgs e)
		{
			Text_Box_username.Clear();
			Text_Box_password.Clear();
		}

		private void label_cross_Click(object sender, EventArgs e)
		{

		}
		private void label8_MouseEnter(object sender, EventArgs e)
		{
			label_exit.ForeColor = Color.Red;
		}

		private void label_exit_MouseLeave(object sender, EventArgs e)
		{
			label_exit.ForeColor = Color.Black;
		}

		private void label_minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void label_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void comboBox_role_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox_role.DropDownStyle = ComboBoxStyle.DropDownList; // disables typing
			Text_Box_username.Focus();
		}

		private void label_minimize_MouseEnter(object sender, EventArgs e)
		{
			label_minimize.ForeColor = Color.Red;
		}

		private void label_minimize_MouseLeave(object sender, EventArgs e)
		{
			label_minimize.ForeColor = Color.Black;
		}

		private void guna2TextBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
