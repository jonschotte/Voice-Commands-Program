using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Voice_Commands_Program
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            VoiceRec.Main1(new String[0]);

        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Say watch video or click here to open the video link on voice recognition!
           

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WhatIsIt(object sender, EventArgs e)
        {

            What W = new What();
            W.Show();
        }

        private void HowDoesItWork(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yxxRAHVtafI&t=");
        }


        private void WhereB_Click(object sender, EventArgs e)
        {
            Where H = new Where();
            H.Show();
        }

        private void WhenB_Click(object sender, EventArgs e)
        {
            When N = new When();
            N.Show();
        }
    }
}
