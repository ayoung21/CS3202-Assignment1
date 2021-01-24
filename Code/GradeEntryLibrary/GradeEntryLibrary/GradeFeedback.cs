﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeEntryLibrary
{
    public partial class GradeFeedback: UserControl
    {
        public GradeFeedback()
        {
            InitializeComponent();
            this.intializeDefaultRadioButtons();
        }

        private void intializeDefaultRadioButtons()
        {
            this.radioButtonOptionA.Text = "Exceptional";
            this.radioButtonOptionB.Text = "Acceptable";
            this.radioButtonOptionC.Text = "Amateur";
            this.radioButtonOptionD.Text = "Unstatisfactory";

            this.radioButtonOptionA.Tag = 3;
            this.radioButtonOptionA.Tag = 2;
            this.radioButtonOptionA.Tag = 1;
            this.radioButtonOptionA.Tag = 0;
        }
    }
}