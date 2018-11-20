using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerlinClock
{
	public partial class Form1 : Form
	{
		Clock clock;


		public Form1()
		{
			InitializeComponent();
			clock = new Clock(DateTime.Now);
			clock.UpdateTime(DateTime.Now);
			timer1.Enabled = true;

		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			clock.UpdateTime(DateTime.Now);
			UpdateImagesOneMin(clock.Minutter1);
			UpdateImageFiveMin(clock.Minutter5);
			UpdateImagesOneHour(clock.Hour1);
			UpdateImagesFiveHour(clock.Hour5);

		}


		private void UpdateImagesOneMin(int Min)
		{
			switch (Min)
			{
				case 1:
					pictureBox1.BackColor = Color.Yellow;
					break;

				case 2:
					pictureBox1.BackColor = Color.Yellow;
					pictureBox2.BackColor = Color.Yellow;
					break;

				case 3:
					pictureBox1.BackColor = Color.Yellow;
					pictureBox2.BackColor = Color.Yellow;
					pictureBox3.BackColor = Color.Yellow;
					break;

				case 4:
					pictureBox1.BackColor = Color.Yellow;
					pictureBox2.BackColor = Color.Yellow;
					pictureBox3.BackColor = Color.Yellow;
					pictureBox4.BackColor = Color.Yellow;
					break;

				default:
					pictureBox1.BackColor = Color.Silver;
					pictureBox2.BackColor = Color.Silver;
					pictureBox3.BackColor = Color.Silver;
					pictureBox4.BackColor = Color.Silver;
					break;
			}
		}

		private void UpdateImageFiveMin(int min)
		{
			switch(min)
			{
				case 1:
					pictureBox5.BackColor = Color.Yellow;
					break;

				case 2:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					break;

				case 3:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					break;

				case 4:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					pictureBox8.BackColor = Color.Yellow;
					break;

				case 5:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					pictureBox8.BackColor = Color.Yellow;
					pictureBox9.BackColor = Color.Yellow;
					break;

				case 6:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					pictureBox8.BackColor = Color.Yellow;
					pictureBox9.BackColor = Color.Yellow;
					pictureBox10.BackColor = Color.Yellow;
					break;

				case 7:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					pictureBox8.BackColor = Color.Yellow;
					pictureBox9.BackColor = Color.Yellow;
					pictureBox10.BackColor = Color.Yellow;
					pictureBox11.BackColor = Color.Yellow;
					break;

				case 8:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					pictureBox8.BackColor = Color.Yellow;
					pictureBox9.BackColor = Color.Yellow;
					pictureBox10.BackColor = Color.Yellow;
					pictureBox11.BackColor = Color.Yellow;
					pictureBox12.BackColor = Color.Yellow;
					break;

				case 9:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					pictureBox8.BackColor = Color.Yellow;
					pictureBox9.BackColor = Color.Yellow;
					pictureBox10.BackColor = Color.Yellow;
					pictureBox11.BackColor = Color.Yellow;
					pictureBox12.BackColor = Color.Yellow;
					pictureBox13.BackColor = Color.Yellow;
					break;

				case 10:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					pictureBox8.BackColor = Color.Yellow;
					pictureBox9.BackColor = Color.Yellow;
					pictureBox10.BackColor = Color.Yellow;
					pictureBox11.BackColor = Color.Yellow;
					pictureBox12.BackColor = Color.Yellow;
					pictureBox13.BackColor = Color.Yellow;
					pictureBox14.BackColor = Color.Yellow;
					break;

				case 11:
					pictureBox5.BackColor = Color.Yellow;
					pictureBox6.BackColor = Color.Yellow;
					pictureBox7.BackColor = Color.Yellow;
					pictureBox8.BackColor = Color.Yellow;
					pictureBox9.BackColor = Color.Yellow;
					pictureBox10.BackColor = Color.Yellow;
					pictureBox11.BackColor = Color.Yellow;
					pictureBox12.BackColor = Color.Yellow;
					pictureBox13.BackColor = Color.Yellow;
					pictureBox14.BackColor = Color.Yellow;
					pictureBox15.BackColor = Color.Yellow;
					break;

				default:
					pictureBox5.BackColor = Color.Silver;
					pictureBox6.BackColor = Color.Silver;
					pictureBox7.BackColor = Color.Silver;
					pictureBox8.BackColor = Color.Silver;
					pictureBox9.BackColor = Color.Silver;
					pictureBox10.BackColor = Color.Silver;
					pictureBox11.BackColor = Color.Silver;
					pictureBox12.BackColor = Color.Silver;
					pictureBox13.BackColor = Color.Silver;
					pictureBox14.BackColor = Color.Silver;
					pictureBox15.BackColor = Color.Silver;

					break;
			}
		}

		private void UpdateImagesOneHour(int hour)
		{
			switch(hour)
			{
				case 1:
					pictureBox16.BackColor = Color.OrangeRed;
					break;

				case 2:
					pictureBox16.BackColor = Color.OrangeRed;
					pictureBox17.BackColor = Color.OrangeRed;
					break;

				case 3:
					pictureBox16.BackColor = Color.OrangeRed;
					pictureBox17.BackColor = Color.OrangeRed;
					pictureBox18.BackColor = Color.OrangeRed;
					break;

				case 4:
					pictureBox16.BackColor = Color.OrangeRed;
					pictureBox17.BackColor = Color.OrangeRed;
					pictureBox18.BackColor = Color.OrangeRed;
					pictureBox19.BackColor = Color.OrangeRed;
					break;

				default:
					pictureBox16.BackColor = Color.Silver;
					pictureBox17.BackColor = Color.Silver;
					pictureBox18.BackColor = Color.Silver;
					pictureBox19.BackColor = Color.Silver;
					break;
			}
		}

		private void UpdateImagesFiveHour(int hour)
		{
			switch (hour)
			{
				case 1:
					pictureBox20.BackColor = Color.OrangeRed;
					break;

				case 2:
					pictureBox20.BackColor = Color.OrangeRed;
					pictureBox21.BackColor = Color.OrangeRed;
					break;

				case 3:
					pictureBox20.BackColor = Color.OrangeRed;
					pictureBox21.BackColor = Color.OrangeRed;
					pictureBox22.BackColor = Color.OrangeRed;
					break;

				case 4:
					pictureBox20.BackColor = Color.OrangeRed;
					pictureBox21.BackColor = Color.OrangeRed;
					pictureBox22.BackColor = Color.OrangeRed;
					pictureBox23.BackColor = Color.OrangeRed;
					break;

				default:
					pictureBox20.BackColor = Color.Silver;
					pictureBox21.BackColor = Color.Silver;
					pictureBox22.BackColor = Color.Silver;
					pictureBox23.BackColor = Color.Silver;
					break;
			}
		}

	}
}
