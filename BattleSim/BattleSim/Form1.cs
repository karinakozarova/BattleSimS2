﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class Form1 : Form
    {
        Game newGame;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreateWeaponsAndSpells_Click(object sender, EventArgs e)
        {
            new CreateWeaponsAndSpells().Show();
        }
    }
}