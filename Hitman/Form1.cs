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
using System.Media;


namespace Hitman
{
    public partial class Hitman : Form
    {
        int scene = 0;
        SoundPlayer shooting = new SoundPlayer(Properties.Resources._238246__18hiltc__assualt_rifle_shooting6);
        SoundPlayer oneshot = new SoundPlayer(Properties.Resources._115295__warriorsfan12331__gun_shot2);
        SoundPlayer win = new SoundPlayer(Properties.Resources._391539__mativve__electro_win_sound);
        public Hitman()
        {
            InitializeComponent();
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
                else if (scene == 15)
                {
                    Random randomGen = new Random();
                    int value = randomGen.Next(1, 101);

                    if (value < 61) { scene = 16; }
                    else { scene = 17; }

                }
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
                if (scene == 9) { scene = 13; }
                else if (scene == 14) { Application.Exit(); }
            }
            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:
                    //start scene 

                    eventOutput.Text = "You are an infamous hitman and have been tasked to hunt down a target somewhere out here in the woods." +
                        " Word has it he is never alone, so think twice about your decisions..." +
                        "Go north or south?";
                    redLabel.Text = "South";
                    blueLabel.Text = "North";
                    eventpicOutput.BackgroundImage = Properties.Resources.forest;
                    break;
                case 1:
                    eventOutput.Text = "You go deeper into the woods and come across a camp. Looks abandoned..." +
                        "Stop and investigate?";
                    redLabel.Text = "Don't investigate";
                    blueLabel.Text = "Investigate";
                    eventpicOutput.BackgroundImage = Properties.Resources.campp;
                    break;
                case 2:
                    eventOutput.Text = "You ignore the campsite and keep on walking forwards.";
                    Refresh();
                    Thread.Sleep(2000);
                    eventOutput.Text = "You take a turn and fall into a massive hole and fall to your death." +
                         "Restart?";
                    eventpicOutput.BackgroundImage = Properties.Resources.hole;
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 3:
                    eventOutput.Text = "You spend some time investigating the abandoned camp," +
                        "and find a recently put-out campfire and fresh foot prints heading North." +
                        "Follow the footprints or go your own way?";
                    redLabel.Text = "Go your own way";
                    blueLabel.Text = "Follow foot prints";
                    eventpicOutput.BackgroundImage = Properties.Resources.footprints;
                    break;
                case 4:
                    eventOutput.Text = "The footprints you follow eventually take you to an old cabin." +
                        " You see lights leaking through the windows and voices coming from inside..." +
                        "Enter through front door or go around the back?";
                    redLabel.Text = "Front door";
                    blueLabel.Text = "The back";
                    eventpicOutput.BackgroundImage = Properties.Resources.cabin;
                    break;
                case 5:
                    eventOutput.Text = "You foolishly enter the front door like its your own house and are immediately spotted and killed on the spot. " +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    eventpicOutput.BackgroundImage = Properties.Resources.gunman;
                    oneshot.Play();
                    break;
                case 6:
                    eventOutput.Text = "You circle around the building and arrive at the back door of the cabin and try to make out the conversation by listening through the door." +
                        "You cannot understand what they are saying." +
                        "Go inside or keep listening?";
                    redLabel.Text = "Keep listening";
                    blueLabel.Text = "Go inside";
                    eventpicOutput.BackgroundImage = Properties.Resources.backdoor;
                    break;
                case 7:
                    eventOutput.Text = "You quietly open the back door and head inside...";
                    Refresh();
                    Thread.Sleep(2000);
                    eventOutput.Text = "As you keep sneaking around the house towards the voices, you see someone with a gun heading your direction." +
                        "Take him out or let him pass?";
                    redLabel.Text = "Let him pass";
                    blueLabel.Text = "Take him out";
                    eventpicOutput.BackgroundImage = Properties.Resources.man_in_hall;
                    break;
                case 8:
                    eventOutput.Text = "You choose to keep listening and eventually fall asleep. " +
                    "Your sleeping body is later discovered by the people inside the house and you are killed." +
                    "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    eventpicOutput.BackgroundImage = Properties.Resources.man_on_ground;
                    break;
                case 9:
                    eventOutput.Text = "Once he turns the corner your behind, you quietly and swiftly knock him out. " +
                        "No one hears you. You continue walking towards the voices ";
                    Refresh();
                    Thread.Sleep(2000);
                    eventOutput.Text = "You finally find the room where the voices are coming from, and you clearly hear the voice of your target. He is here." +
                        "Go in guns blazing, Sneak a peak in the room, or back out completely?";
                    redLabel.Text = "Back out";
                    blueLabel.Text = "Guns blazing";
                    greenLabel.Text = "Sneak a peak";
                    eventpicOutput.BackgroundImage = Properties.Resources.keyhole;
                    break;
                case 10:
                    eventOutput.Text = "You decide to let him pass but he spots you once he turns the corner. You Immediately get shot and die." +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    eventpicOutput.BackgroundImage = Properties.Resources.gunman;
                    break;
                case 11:
                    eventOutput.Text = "Out of no where, you decide this is a stupid mission.You leave the house through a window, and abandon the mission." +
                        "You are then later killed by your client in rage who hired you for abandoning you mission." +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    greenLabel.Text = "";
                    eventpicOutput.BackgroundImage = Properties.Resources.sneaking_out;
                    break;
                case 12:
                    eventOutput.Text = "You bust down the door of the room their in, whip out your guns and start blindly shooting.";
                    eventpicOutput.BackgroundImage = Properties.Resources.standoff;
                    shooting.Play();
                    Refresh();
                    Thread.Sleep(3000);
                    eventOutput.Text = "You manage to take down everyone in the room, including your target." +
                        " You have completed your mission. You win." +
                        "End the game or play again?";
                    eventpicOutput.BackgroundImage = Properties.Resources.win;
                    redLabel.Text = "End";
                    blueLabel.Text = "Restart";
                    break;
                case 13:
                    eventOutput.Text = "You slowly peak into the room and are spotted almost instantly. You get unloaded on by bullets. You died." +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    greenLabel.Text = "";
                    eventpicOutput.BackgroundImage = Properties.Resources.peeking;
                    shooting.Play();
                    break;
                case 14:
                    eventOutput.Text = "Congrats on winning and thank you for playing!" +
                        "Did you like the game?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "Yes";
                    greenLabel.Text = "No (yes)";
                    eventpicOutput.BackgroundImage = Properties.Resources.thanks;
                    win.Play();
                    break;
                case 15:
                    eventOutput.Text = "You find yourself out of the woods and at a busy highway" +
                        "Cross the highway or go back into woods?";
                    redLabel.Text = "Cross highway";
                    blueLabel.Text = "Back to woods";
                    eventpicOutput.BackgroundImage = Properties.Resources.highway;
                    break;
                case 16:
                    eventOutput.Text = "You make it halfway through the highway until you are completely owned by a Honda mini van." +
                        " You go flying into the air and meet your dead as soon as you hit the ground. You died." +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    eventpicOutput.BackgroundImage = Properties.Resources.honda;
                    break;
                case 17:
                    eventOutput.Text = "You barely cross the highway. You now find yourself at a gas station." +
                        "Go inside or go back and continue your mission?";
                    redLabel.Text = "Go inside";
                    blueLabel.Text = "Go back";
                    eventpicOutput.BackgroundImage = Properties.Resources.store;

                    break;
                case 18:
                    eventOutput.Text = "You step inside the gas station convenience store and are suddenly greeted with two police officers who immediately recognize who you are, " +
                        "and arrest you at once. You lose." +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    eventpicOutput.BackgroundImage = Properties.Resources.arrest;
                    break;
                case 19:
                    eventOutput.Text = "You were lucky crossing the highway the first time, but not so much this time. " +
                        "You get rammed by a speeding Toyota Corolla and die instantly." +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    eventpicOutput.BackgroundImage = Properties.Resources.toyota;
                    break;
                case 20:
                    eventOutput.Text = "You choose your own path and you get step on a beartrap. Your leg is gets severed and you bleed out. You died." +
                        "Restart?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    eventpicOutput.BackgroundImage = Properties.Resources.bear_trap;
                    break;
            }
        }
    }
}
