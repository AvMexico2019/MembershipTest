﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipTest
{
    public partial class AgregarQuitarRol : Form
    {
        public int result;

        public AgregarQuitarRol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = 2;
            this.Close();
        }
    }
}
