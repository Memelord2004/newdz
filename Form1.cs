using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamagoch
{

    public partial class Form1 : Form
    {
        int count_sec = 0;
        int obser = 10;
        int satiety = 100;
        int hp = 70;
        int happines = 10;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            timer1.Interval = 10000;
            timer1.Start();
            label4.Text = "70";
            label3.Text = "100";
            label2.Text = "10";
            label9.Text = "10";

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void eat_Click(object sender, EventArgs e) //кнопка пополнения еды
        {
            Random rnd2 = new Random();
            int value2 = rnd2.Next(0, 2);
            switch (value2)
            {
                case 0:
                    MessageBox.Show(
                        "Вы покормили своего питомца!",
                        "УраКласс"
                        );
                    satiety = 100;
                    label3.Text = satiety.ToString();
                    happines = happines + 10;
                    break;
                case 1:
                    MessageBox.Show(
                    "Вы покормили своего питомца!",
                            "УраКласс"
                                    );
                    satiety = 100;
                    label3.Text = satiety.ToString();
                    happines = happines + 10;
                    break;
                case 2:
                    MessageBox.Show(
                        "Ваш питомец не захотел есть вашу еду",
                                   "Вы черт"
                                        );
                    satiety = satiety;
                    label3.Text = satiety.ToString();
                    happines = happines - 10;
                    hp = hp - 10;
                    break;
            }


        }
    

        private void Stats_Click(object sender, EventArgs e) // кнопка статус
        {
            timer1.Stop(); // вот эта штука мне все пофиксила
            string text2 = "Cытость:";
            string text3 = "Здоровье:";
            string text4 = "Радость:";
            DialogResult result = MessageBox.Show(
                text2 + satiety.ToString() + Environment.NewLine +
                text3 + hp.ToString() + Environment.NewLine + text4 + happines.ToString(),
                "Статистика"

                 );
            if(result == DialogResult.OK)
            {
                timer1.Start();
            }
        }

        private void toilet_Click(object sender, EventArgs e) // туалет
        {
            obser = 0;
            label2.Text = obser.ToString();
        }

        private void heal_Click(object sender, EventArgs e) // хилл
        {
            hp = 100;
            label4.Text = hp.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rnd = new Random();      // отнятие сытости каждые 10сек
            int value = rnd.Next(1, 3);
            switch (value)
            {
                case 1:
                    satiety = satiety - 10;
                    break;
                case 2:
                    satiety = satiety - 5;
                    break;
                case 3:
                    satiety = satiety - 5;
                    break;
            }
            if (satiety == 30 | satiety == 35 | satiety == 25)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show(
                    "Ваш питомец сильно проголодался" + Environment.NewLine + "покормить его?",
                    "Warning",
                    MessageBoxButtons.YesNo
                    ); 

                if(result == DialogResult.Yes)
                {
                    timer1.Start();
                    Random rnd2 = new Random();
                    int value2 = rnd2.Next(0, 2);
                    switch (value2)
                    {
                        case 0:
                            timer1.Stop();
                            DialogResult result1 = MessageBox.Show(
                                "Вы покормили своего питомца!",
                                "УраКласс"
                                );
                            if(result1 == DialogResult.OK)
                            {
                                timer1.Start();
                            }
                            satiety = 100;
                            label3.Text = satiety.ToString();
                            happines = happines + 10;
                            break;
                        case 1:
                            DialogResult result2 = MessageBox.Show(
                            "Вы покормили своего питомца!",
                                    "УраКласс"
                                            );
                            if (result2 == DialogResult.OK)
                            {
                                timer1.Start();
                            }
                            satiety = 100;
                            label3.Text = satiety.ToString();
                            happines = happines + 10;
                            break;
                        case 2:
                            DialogResult result3 = MessageBox.Show(
                                "Ваш питомец не захотел есть вашу еду",
                                           "Вы черт"
                                                );
                            if (result3 == DialogResult.OK)
                            {
                                timer1.Start();
                            }
                            satiety = satiety;
                            label3.Text = satiety.ToString();
                            happines = happines - 10;
                            hp = hp - 10;
                            break;
                    }
                }
                hp = hp - 10;
                label4.Text = hp.ToString();


            }
            if (satiety < 0)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show(
                    "Ваш питомец Умер!" + Environment.NewLine + "Вы ужасный хозяин!",
                    "АААААААААААА", MessageBoxButtons.OK
                    ); 
                if(result == DialogResult.OK)
                {
                    timer1.Start();
                }
                hp = hp - 10;
                label4.Text = hp.ToString();
                this.Close();
             
            }

            if (obser < 100)
            {
                Random rnd1 = new Random();     // возможность рандомного обсёра.
                int value1 = rnd1.Next(0, 6);
                switch (value1)
                {
                    case 0:
                        obser = obser + 10;
                        break;
                    case 1:
                        obser = obser + 5;
                        break;
                    case 2:
                        obser = obser + 0;
                        break;
                    case 3:
                        obser = obser + 0;
                        break;
                    case 4:
                        obser = obser + 10;
                        break;
                    case 5:
                        obser = obser + 5;
                        break;
                    case 6:
                        obser = obser + 10;
                        break;
                }
            }
            string text = "Ваш питомец обосрался" + Environment.NewLine +
                           "Уберетесь за ним?";
            if (obser >= 100)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show(
                    text,
                    "Внимание!!!",
                    MessageBoxButtons.YesNo
                    );
                if (result == DialogResult.Yes)
                {
                    timer1.Start();
                    obser = 0;
                    label2.Text = obser.ToString();
                }
                if(result == DialogResult.No)
                {
                    DialogResult result2 = MessageBox.Show(
                        "Ладно...",
                        "Ок?"
                        );
                    if(result2 == DialogResult.OK)
                    {
                        timer1.Start();
                    }
                }

            }


            label3.Text = satiety.ToString();
            label2.Text = obser.ToString();
            label1.Text = (count_sec++).ToString();
            label9.Text = happines.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
