using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class MainParent : Form
    {
        private espServis servis = new espServis();

        int kontrolnaTemperatura = 0;
        int sobnaTemperatura = 0;

        bool stanjeKlime = false;
        public MainParent()
        {
            InitializeComponent();

            Image logo = new Bitmap(@"C:\Users\pc\Downloads\temperatures.png");

            panel4.BackgroundImage = logo;

            Image plus = new Bitmap(@"C:\Users\pc\Downloads\plus.png");

            btnPovecaj.BackgroundImage = plus;

            Image minus_button = new Bitmap(@"C:\Users\pc\Downloads\minus-button.png");

            btnSmanji.BackgroundImage = minus_button;

            Image tick = new Bitmap(@"C:\Users\pc\Downloads\tick.png");

            btnPotvrdi.BackgroundImage = tick;

            StartTemperatureListening();

            GetStanjeKlime();

        }

        private async void GetStanjeKlime()
        {
            var respons = await servis.GetStanjeKlime();
            stanjeKlime = respons;

            if (respons)
            {
                Image off = new Bitmap(@"C:\Users\pc\Downloads\stand-by.png");
                btnUpali.BackgroundImage = off;
            }
            else
            {
                Image on = new Bitmap(@"C:\Users\pc\Downloads\turn-off.png");
                btnUpali.BackgroundImage = on;
            }
        }

        private async void StartTemperatureListening()
        {
            while (true)
            {
                GetTemperatura();

                await Task.Delay(3000);
            }
        }

        private async void GetTemperatura()
        {

            var temperatura = await servis.GetTemperaturu();

            sobnaTemperatura = temperatura;

            if (temperatura >= 30)
            {

                Image fever = new Bitmap(@"C:\Users\pc\Downloads\fever.png");

                panel5.BackgroundImage = fever;
            }
            else
            {
                Image fine = new Bitmap(@"C:\Users\pc\Downloads\thermometer.png");

                panel5.BackgroundImage = fine;
            }

            lblTemperatura.Text = sobnaTemperatura.ToString() + " °C";

            if (lblKontrolnaTemperatura.Text == "x")
            {
                kontrolnaTemperatura = sobnaTemperatura;

                lblKontrolnaTemperatura.Text = kontrolnaTemperatura.ToString() + " °C";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (stanjeKlime)
            {
                var respons = await servis.KlimaOff();

                if (respons)
                    GetStanjeKlime();
            }
            else
            {
                var respons = await servis.KlimaON();

                if (respons)
                    GetStanjeKlime();
            }

        }


        private void PovecajTemperaturu(object sender, EventArgs e)
        {
            kontrolnaTemperatura++;
            lblKontrolnaTemperatura.Text = kontrolnaTemperatura.ToString() + " °C";
        }

        private void SmanjiTemperaturu(object sender, EventArgs e)
        {
            kontrolnaTemperatura--;

            lblKontrolnaTemperatura.Text = kontrolnaTemperatura.ToString() + " °C";
        }

        private async void PotvrdiPromjenuTemperature(object sender, EventArgs e)
        {
            await servis.PromjeniTemperaturu(kontrolnaTemperatura);
        }
    }
}
