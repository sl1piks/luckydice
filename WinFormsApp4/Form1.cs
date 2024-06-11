namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Game game = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           game.Bet(0, button1, label2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.Bet(3, button4, label2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Bet(1, button2, label2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            game.Bet(5, button6, label2);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.Bet(2, button3, label2);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            game.Bet(4, button5, label2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            game.Start(label2, pictureBox1, pictureBox2,pictureBox3);
            game.Clear(button1, button2, button3, button4, button5, button6);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
