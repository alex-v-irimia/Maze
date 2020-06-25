using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Level1 : Form
    {
        Point start_pos;
        bool is_paused = false;
        private void setLocation()
        {
            start_pos = PointToScreen(start.Location);
            start_pos.X += start.Size.Width / 2;
            start_pos.Y += start.Size.Height / 2;
        }
        public Level1()
        {
            InitializeComponent();
        }

        private void restart()
        {
            Cursor.Position = start_pos;
        }

        private void wall_touch(object sender, EventArgs e)
        {
            if (is_paused) return;
            MessageBox.Show("You lost!\nTry again");
            restart();
        }

        private void finish_MouseEnter(object sender, EventArgs e)
        {
            if (is_paused) return;
            MessageBox.Show("You won!");
            this.Close();
        }

        private void Level1_LocationChanged(object sender, EventArgs e)
        {
            setLocation();
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'p' || e.KeyChar == 'P')
            {
                is_paused = !is_paused;
                paused.Visible = is_paused;
            }
            else if (e.KeyChar == 27 || e.KeyChar == 'q' || e.KeyChar == 'Q')//ESCAPE=27
                this.Close();
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            paused.Visible = is_paused;
            setLocation();
            Cursor.Position = start_pos;
        }
    }
}
