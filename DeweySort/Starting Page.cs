using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweySort
{
    public partial class Starting_Page : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Starting_Page()
        {
            InitializeComponent();
            player.SoundLocation = "C:\\Users\\lab_services_student\\source\\repos\\DeweySort\\DeweySort\\GameMusic.wav";
            player.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game_Modes game_Modes = new Game_Modes();
            game_Modes.Show();
            this.Hide();
        }
    }
}
