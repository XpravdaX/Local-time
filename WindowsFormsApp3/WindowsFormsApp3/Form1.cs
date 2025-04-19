using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            update_Time();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            update_Time();
        }

        private void update_Time()
        {
            TimeZoneInfo moscowTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
            DateTime moscowTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, moscowTimeZone);
            timeMosckow.Text = moscowTime.ToString("dd MMMM yyyy г. HH:mm:ss");

            TimeZoneInfo londonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime londonTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, londonTimeZone);
            timeLondon.Text = londonTime.ToString("dd MMMM yyyy г. HH:mm:ss");

            TimeZoneInfo newYorkTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime newYorkTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, newYorkTimeZone);
            timeNewYork.Text = newYorkTime.ToString("dd MMMM yyyy г. HH:mm:ss");


            TimeZoneInfo tokyoTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            DateTime tokyoTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tokyoTimeZone);
            timeTokio.Text = tokyoTime.ToString("dd MMMM yyyy г. HH:mm:ss");
        }
    }
}
