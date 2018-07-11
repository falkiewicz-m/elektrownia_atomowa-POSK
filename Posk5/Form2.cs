using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Posk5
{
    public partial class Form2 : Form
    {
        private static int RandomNumber(int min, int max)
        {
            Random r = new Random();
            int result = r.Next(min, max);
            return result;
        }
        int czas = 15; //domyslne 15 minut
        bool alarmOff = false;
        System.Media.SoundPlayer alarm = new System.Media.SoundPlayer(@"C:\Users\Asus\documents\visual studio 2015\Projects\Posk5\Posk5\Resources\Massive_War_With_Alarm - Emmanuel_Exiga - 1899079650.wav");

        double pokaz_temp = 250;
        double pokaz_c = Double.Parse(HardwareInfo.procek().ToString()) * 31;
        double pokaz_m = HardwareInfo.pamiec()/1000;
        

        public Form2()
        {
            InitializeComponent();
            progressBar1.Value = (int)pokaz_temp;
            progressBar2.Value = (int)pokaz_c;
            progressBar3.Value = (int)pokaz_m;

            //    timer2.Interval = czas * 6000;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 8000;
            double t_int = RandomNumber(-90,90);
            if(t_int != 0)
            pokaz_temp += (t_int / 10);
            label6.Text = pokaz_temp.ToString();

            string t1 = "Temperatura przekroczyła dopuszczalną wartość!";
            string c1 = "Ciśnienie przekroczyło dopuszczalną wartość!";
            string m1 = "Moc przekroczyła dopuszczalną wartość!";
            string obniz_t = "\nObniż temperaturę!";
            string zwieksz_t = "\nZwiększ temperaturę!";
            string obniz_c = "\nZmniejsz ciśnienie!";
            string zwieksz_c = "\nZwiększ ciśnienie!";
            string obniz_m = "\nZmniejsz moc!";
            string zwieksz_m = "\nZwiększ moc!";
            //string ostrzezenie = "\nBo jebnie.";


            if (pokaz_temp > 280)
            {
                MessageBox.Show(t1+obniz_t);
            }

            if (pokaz_temp < 250)
            {
                MessageBox.Show(t1 + zwieksz_t);
            }

            double c_int = RandomNumber(-10, 10);
            if (c_int != 0)
            pokaz_c += (c_int / 10);
            label8.Text = pokaz_c.ToString();
            if (pokaz_c > 78)
                MessageBox.Show(c1 +obniz_c);
            if (pokaz_c < 70)
                MessageBox.Show(c1 + zwieksz_c);


            double m_int = RandomNumber(-200, 200);
            if (c_int != 0)
            pokaz_m += (m_int / 100);
            label9.Text = pokaz_m.ToString() ;

            if (pokaz_m > 7)
                MessageBox.Show(m1 + obniz_m);
            if (pokaz_m < 4)
                MessageBox.Show(m1 + zwieksz_m);


            progressBar1.Value = (int)pokaz_temp;
            progressBar2.Value = (int)pokaz_c;
            progressBar3.Value = (int)pokaz_m;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            pokaz_temp += 10;
            label6.Text = pokaz_temp.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pokaz_temp -= 10;
            label6.Text = pokaz_temp.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pokaz_c += 1;
            label8.Text = pokaz_c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pokaz_c -= 1;
            label8.Text = pokaz_c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pokaz_m += 0.5;
            label9.Text = pokaz_m.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pokaz_m -= 0.5;
            label9.Text = pokaz_m.ToString();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 California = new Form1();

            string i1 = "Nastąpi wylogowanie z systemu.";
            string i2 = "Czy na pewno chcesz się wylogować?";

            MessageBoxButtons b = MessageBoxButtons.OKCancel;
            DialogResult logout = MessageBox.Show(i1 + "\n\n" + i2);

            if (logout == DialogResult.OK)
            {
                this.Close();
                California.Show(); //yooour teeeth
                //she's my priestess, i'm your prieeest
                //yeeeah
            }

            


        }

        private void instrukcjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string i1 = "Obsługa:";
            string i2 = "\n\nW wypadku niebezpiecznych zachowań reaktora";
            string i3 = "\nużytkownik zostanie poinformowany o należnym zachowaniu.";
            string i4 = "\n\nZmiany wartości odbywają się za pomocą przycisków '+' oraz '-'";
            string i5 = "\nDla temperatury: kliknięcie przycisku to zmiana o 5 °C";
            string i6 = "\nDla ciśnienia: kliknięcie przycisku to zmiana o 1 atm";
            string i7 = "\nDla mocy: kliknięcie przycisku to zmiana o 0.5 MW";
            string i8 = "\n\n Autorzy:";
            string i9 = "\n  © Marika Trudnowska";
            string i10 = "\n  © Michał Falkiewicz";
            MessageBox.Show(i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = czas * 60000; //60000 - minuta
            if (alarmOff == true)
            {
                DialogResult dr = MessageBox.Show("Kliknij OK, by wyłączyć alarm!");
                while (dr != DialogResult.OK)
                    alarm.Play();
            }
            alarmOff = true;
        }

        private void dwieminuty_Click(object sender, EventArgs e)
        {
            czas = 2;
        }

        private void piecminut_Click(object sender, EventArgs e)
        {
            czas = 5;
        }

        private void dziesiecminut_Click(object sender, EventArgs e)
        {
            czas = 10;
        }

        private void pietnascieminut_Click(object sender, EventArgs e)
        {
            czas = 15;
        }

        private void dwadziesciaminut_Click(object sender, EventArgs e)
        {
            czas = 20;
        }

        private void trzydziesciminut_Click(object sender, EventArgs e)
        {
            czas = 30;
        }

        private void ustawCzas_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Wprowadź własną wartość (w minutach):", "Alarm", "0", -1, -1);
            try
            {
                czas = Int32.Parse(input);
            }
            catch
            {
                MessageBox.Show("Nieprawidłowa wartość!");
                ustawCzas.PerformClick();
            }

        }
    }
}
