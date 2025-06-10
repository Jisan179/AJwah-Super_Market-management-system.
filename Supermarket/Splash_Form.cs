using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
	public partial class Splash_Form : Form
	{
		int loadingPercentage = 0;

		public Splash_Form()
		{
			InitializeComponent();
			timer1.Interval = 50; // Set the timer interval to 800 milliseconds
			timer1.Tick += timer1_Tick_1;
			timer1.Start(); // Start the timer
		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			loadingPercentage ++;
			label3.Text = $"Loading...{loadingPercentage}%"; // Corrected the property access
			if (loadingPercentage >= 100)
			{
				timer1.Stop(); // Stop the timer when loading is complete
				this.Hide(); // Hide the splash form
				Loginform loginForm = new Loginform(); // Create an instance of the login form
				loginForm.Show(); // Show the login form
			}
			else
			{
				label3.Refresh(); // Refresh the label to update the text
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
