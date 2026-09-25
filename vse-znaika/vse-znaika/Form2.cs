using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vse_znaika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();   // показываем спрятанную Form1
            this.Close();        // закрываем Form2
=======
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
>>>>>>> dcff06d126e7a6a5bece25b9645e894d61736d3e
        }
    }
}
