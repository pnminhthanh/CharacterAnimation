﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            animationCtrl1.Start();
        }

        private void animationCtrl1_KeyDown(object sender, KeyEventArgs e)
        {
            animationCtrl1.ChooseAnimation(e.KeyCode);
            if (e.KeyCode == Keys.S)
            {
                animationCtrl2.AnimationSkill();
            }            
        }

        private void animationCtrl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }
    }
}
