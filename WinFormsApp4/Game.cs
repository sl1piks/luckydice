using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class Game
    {
        private int[] bets = new int[6];
        private int money = 50;
        public void Bet(int index, Button button, Label label)
        {
            if (money <= 0)
                return;
            bets[index]++;
            money--;
            button.Text = bets[index].ToString();
            label.Text = "Money " + money.ToString();
        }
        public void Start(Label label, params PictureBox[] pictures)
        {
            for (int i = 0; i < pictures.Length; i++)
            {
                int index = new Random().Next(6);
                pictures[i].Image = chooseImage(index);
                money += bets[index] * 2;
                label.Text = "Money " + money.ToString();
            }
        }
        public void Clear(params Button[] buttons)
        {
            for(int i = 0;i < buttons.Length;i++)
            {
                buttons[i].Text = "0";
                bets[i] = 0;
            }
        }
        private Bitmap chooseImage(int index) 
        {
            return index switch
            {
                0 => Resource1._1,
                1 => Resource1._2,
                2 => Resource1._3,
                3 => Resource1._4,
                4 => Resource1._5,
                5 => Resource1._6,
            };
        }
    }
}
