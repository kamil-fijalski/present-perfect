using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace DungeonExplorer
{
    public partial class DungeonExplorer : Form
    {
        //private variable starting with underscore
        private Player _player;

        public DungeonExplorer()
        {
            InitializeComponent();

            //Default start values of new player
            _player = new Player
            {
                CurrentHitPoints = 10,
                MaximumHitPoints = 10,
                Gold = 20,
                Experience = 0,
                Level = 1
            };

            //set the labels on the main form
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.Experience.ToString();
            lblLevel.Text = _player.Level.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close the game
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Initialize the variables
            string message = "Dungeon Explorer by fuNcti0n (2018)\n\nAll rights reserved";
            string title = "Dungeon Explorer";
            DialogResult result;
            //Display box
            result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
