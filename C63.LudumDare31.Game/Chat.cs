﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C63.LudumDare31.Game
{
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            this.Dia1.Text = "";
        }
    }
}
