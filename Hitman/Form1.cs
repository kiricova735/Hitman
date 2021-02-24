using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hitman
{
    public partial class Form1 : Form
    {
        int scene = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AnswerOutput2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)       //red button press
            {

                if (scene == 0) { scene = 15; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { Application.Exit(); }
                else if (scene == 3) { scene = 20; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { }
                else if (scene == 6) { }
                else if (scene == 7) { }
                else if (scene == 8) { }
                else if (scene == 9) { }
                else if (scene == 10) { }
                else if (scene == 11) { }
                else if (scene == 12) { }
                else if (scene == 13) { }
                else if (scene == 14) { }
                else if (scene == 15) { }
                else if (scene == 16) { }
                else if (scene == 17) { }
                else if (scene == 18) { }
                else if (scene == 19) { }
                else if (scene == 20) { }
               
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 5) { }
                else if (scene == 6) { }
                else if (scene == 7) { }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene 
                    eventOutput.Text ="You are an infamous hitman and have been tasked to hunt down a target somewhere out here in the woods." +
                        " Word has it he is never alone, and has always got something up his sleeve. Be careful..." +
                        "Go north or south?";
                    redLabel.Text = "North";
                    blueLabel.Text = "South";
                    break;
                case 1:
                    eventOutput.Text = "You go deeper into the woods and come across a camp. Looks abandoned..." +
                        "Stop and investigate?";
                    redLabel.Text = "Don't investigate";
                    blueLabel.Text = "Investigate";

                    break;
                case 2:
                    eventOutput.Text = "You ignore the campsite and keep on walking forwards.";
                    Refresh();
                    Thread.Sleep(2000);
                    eventOutput.Text = "You take a turn and fall into a massive hole and fall to your death";
                        
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 3:
                    eventOutput.Text = "You spend some time investigating the abandoned camp," +
                        "and find a recently put-out campfire and fresh foot prints heading North." +
                        "Follow the footprints or go your own way?";
                    redLabel.Text = "Go your own way";
                    blueLabel.Text = "Follow foot prints";
                    break;
                case 4:
                    eventOutput.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";

                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
                    break;
            }
        }
    }
}
