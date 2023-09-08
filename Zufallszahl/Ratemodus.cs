using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zufallszahl
{

    public partial class Ratemodus : Form
    {
        private SoundPlayer _player; // Miachel Schneider Code


        public Ratemodus()
        {
            InitializeComponent();//Code von ChatGPT
            Label mylab2 = new Label();//Code von ChatGPT
            mylab2.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private static int zufallszahl()
        {
            Random random = new Random();
            int randomnumber = random.Next(0, 100);
            return randomnumber; //Code von ChatGPT
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        public void button1_Click(object sender, EventArgs e)
        {
            _player.Stop(); // Miachel Schneider Code
            Hide(); //Code von ChatGPT
            Ratemodus f2 = new Ratemodus();//Code von ChatGPT
            f2.ShowDialog();//Code von ChatGPT

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int randomnumber = zufallszahl();
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            string antwort;
            antwort = textBox1.Text;
            int zahl;
            antwort = textBox1.Text;


            if (int.TryParse(antwort, out zahl))
            {

                if (zahl > randomnumber)
                {
                    button3.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label2.Text = "Die Zahl ist grösser als die Zufallszahl.";
                    i++;
                }
                else if (zahl < randomnumber)
                {
                    button3.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label2.Text = "Die Zahl ist kleiner als die Zufallszahl.";
                    i++;
                }
                else
                {
                    PlayWinSound();
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label2.Visible = false;
                    label3.Visible = false;
                    label1.Visible = false;
                    textBox1.Visible = false;
                    label4.Text = $"Sie haben {i}Versuche gebraucht.";
                }
            }
            else
            {

                label2.Visible = true;
                label3.Visible = true;
                button3.Visible = true;
                label2.Text = "Sie haben eine ungültige Eingabe gemacht.";
                label2.Text = "Geben Sie nur Zahlen an.";
            }


        }


        public void PlayWinSound()//Code von ChatGPT
        {
            _player = new SoundPlayer(@"C:\Users\kochl\Desktop\IMS\BBB\Lernaterlier\2 Jahr\Einstieg\gewinnmusik.wav");//Code von ChatGPT und Herr Schneider
            _player.Play();//Code von ChatGPT und Herr Schneider
        }


    }
}
