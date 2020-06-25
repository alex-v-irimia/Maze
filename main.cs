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
    public partial class Maze : Form
    {
        Dictionary<Button, Form> map = new Dictionary<Button, Form>();
        public Maze()
        {
            InitializeComponent();
            main_menu.Visible = true;
            level_select.Visible = false;

            map.Add(level1_button, new Level1());
            map.Add(level2_button, new Level2());
            map.Add(level3_button, new Level3());
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            main_menu.Visible = false;
            level_select.Visible = true;
        }

        private void select_level(object sender, EventArgs e)
        {
            Form level = map[(Button)sender];
            level.ShowDialog();
        }

        private void Maze_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q' || e.KeyChar == 'Q' || e.KeyChar == 27)
                Application.Exit();
        }
    }
}
