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
                else if (scene == 5) { Application.Exit(); }
                else if (scene == 6) { scene = 8; }
                else if (scene == 7) { scene = 10; }
                else if (scene == 8) { Application.Exit(); }
                else if (scene == 9) { scene = 11; }
                else if (scene == 10) { Application.Exit(); }
                else if (scene == 11) { Application.Exit(); }
                else if (scene == 12) { scene = 14; }
                else if (scene == 13) { Application.Exit(); }
                else if (scene == 14) { Application.Exit(); }
                else if (scene == 15) { }
                else if (scene == 16) { Application.Exit(); }
                else if (scene == 17) { scene = 18; }
                else if (scene == 18) { Application.Exit(); }
                else if (scene == 19) { Application.Exit(); }
                else if (scene == 20) { Application.Exit(); }
               
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 5) { scene = 0; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 9; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 9) { scene = 12; }
                else if (scene == 10) { scene = 0; }
                else if (scene == 11) { scene = 0; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 13) { scene = 0; }
                else if (scene == 14) { Application.Exit(); }
                else if (scene == 15) { scene = 0; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 17) { scene = 19; }
                else if (scene == 18) { scene = 0; }
                else if (scene == 19) { scene = 0; }
                else if (scene == 20) { scene = 0; }
            
            }
            else if (e.KeyCode == Keys.Space) //green button press
            {

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
                    eventOutput.Text = "The footprints you follow eventually take you to an old cabin." +
                        " You see lights leaking through the windows and voices coming from inside..." +
                        "Enter through front door or go around the back?";
                    redLabel.Text = "Front door";
                    blueLabel.Text = "The back";
                   break;
                case 5:
                    eventOutput.Text = "You foolishly enter the front door like its your own house and are immediately spotted and killed on the spot. " +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 6:
                    eventOutput.Text = "You circle around the building and arrive at the back door of the cabin and try to make out the conversation by listening through the door." +
                        "You cannot understand what they are saying." +
                        "Go inside or keep listening?";
                    redLabel.Text = "Keep listening";
                    blueLabel.Text = "Go inside";
                    break;
                case 7:
                    eventOutput.Text = "You quietly open the back door and head inside...";
                    Refresh();
                    Thread.Sleep(2000);
                    eventOutput.Text = "As you keep sneaking around the house towards the voices, you see someone with a gun heading your direction." +
                        "Take him out or let him pass?";
                    redLabel.Text = "Let him pass";
                    blueLabel.Text = "Take him out";
                   break;
                case 8:
                    eventOutput.Text = "You choose to keep listening and eventually fall asleep. " +
                    "Your sleeping body is later discovered by the people inside the house and you are killed." +
                    "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 9:
                    eventOutput.Text = "Once he turns the corner your behind, you quietly and swiftly knock him out. " +
                        "No one hears you. You continue walking towards the voices ";
                    Refresh();
                    Thread.Sleep(2000);
                    eventOutput.Text = "You finally find the room where the voices are coming from, and you clearly hear the voice of your target.He is here." +
                        "Go in guns blazing, Sneak a peak in the room, or back out completely?";
                    redLabel.Text = "Back out";
                    blueLabel.Text = "Guns blazing";
                    greenLabel.Text = "Sneak a peak";
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                default:
                    break;
            }
        }
    }
}
