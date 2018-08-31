using System;
using System.Drawing;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Apple_Runner_CSharp
{
    public partial class Apple_Runner : Form
    {
        // Creates variables for use in moving sprite
        int ypos;
        int xpos;
        // Create variable for time spent
        int time_Spent = 0;
        // Creates variable for use in detecting collision
        Boolean collision;
        // Creates variable for holding score
        int current_score = 0;
        //  Used for golden apple collison which stops the game
        Boolean Golden_Apple;
        int timercountdown = 50;
        // Used for hiding cursor in textbox
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public Apple_Runner()
        {
            InitializeComponent();
        }

        public void Apple_Runner_Load(object sender, EventArgs e)
        {
            // Reports X and Y details
            xpos = PicSprite.Location.X;
            ypos = PicSprite.Location.Y;
        }
        private void PlayAppleBumpSound()
        {
            // New Sound
            SoundPlayer audio = new SoundPlayer(Apple_Runner_CSharp.Properties.Resources.Mario_Coin);
            // Play
            audio.Play();
            Convert.ToInt32(xpos);
        }
        private void PlayGoldenAppleSound()
        {
            // New Sound
            SoundPlayer audio = new SoundPlayer(Apple_Runner_CSharp.Properties.Resources.mario_level_complete);
            // Play
            audio.Play();
        }
        private void Move_Sprite_Left()
        {
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = xpos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves left by 3
            xpos = xpos - 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_left);
            // // Debug Show Xpos in box
            //LabelTimeLeft.Text = xpos.ToString();
        }
        private void Move_Sprite_Right()
        {
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = xpos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves right by 3
            xpos = xpos + 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_right);
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = xpos.ToString();
        }
        private void Move_Sprite_Up()
        {
            // Debug Show Ypos in box
            // LabelTimeLeft.Text = ypos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves up by 3
            ypos = ypos - 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_up);
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = ypos.ToString();
        }
        private void Move_Sprite_Down()
        {
            // Debug Show Ypos in box
            // LabelTimeLeft.Text = ypos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves down by 3
            ypos = ypos + 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_down);
            // Debug Show Xpos in box
            // LabelTimeLeft.Text = ypos.ToString();
        }


        public void TextBoxKeyInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (PicSprite.Bounds.IntersectsWith(PictureBox1.Bounds))
            {                
                // Run method for general purposes
                isAppleHit();
                // Move box out of range
                PictureBox1.Top = 10000000;
                // Make box invisible
                PictureBox1.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox2.Bounds))
            {
                isAppleHit();
                PictureBox2.Top = 10000000;
                PictureBox2.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox3.Bounds))
            {
                isAppleHit();
                PictureBox3.Top = 10000000;
                PictureBox3.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox4.Bounds))
            {
                isAppleHit();
                PictureBox4.Top = 10000000;
                PictureBox4.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox5.Bounds))
            {
                isAppleHit();
                PictureBox5.Top = 10000000;
                PictureBox5.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox6.Bounds))
            {
                isAppleHit();
                PictureBox6.Top = 10000000;
                PictureBox6.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox7.Bounds))
            {
                isAppleHit();
                PictureBox7.Top = 10000000;
                PictureBox7.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox8.Bounds))
            {
                isAppleHit();
                PictureBox8.Top = 10000000;
                PictureBox8.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox9.Bounds))
            {
                isAppleHit();
                PictureBox9.Top = 10000000;
                PictureBox9.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox10.Bounds))
            {
                isAppleHit();
                PictureBox10.Top = 10000000;
                PictureBox10.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox11.Bounds))
            {
                isAppleHit();
                PictureBox11.Top = 10000000;
                PictureBox11.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox12.Bounds))
            {
                isAppleHit();
                PictureBox12.Top = 10000000;
                PictureBox12.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox13.Bounds))
            {
                isAppleHit();
                PictureBox13.Top = 10000000;
                PictureBox13.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox13.Bounds))
            {
                isAppleHit();
                PictureBox13.Top = 10000000;
                PictureBox13.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox14.Bounds))
            {
                isAppleHit();
                PictureBox14.Top = 10000000;
                PictureBox14.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox15.Bounds))
            {
                isAppleHit();
                PictureBox15.Top = 10000000;
                PictureBox15.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox16.Bounds))
            {
                isAppleHit();
                PictureBox16.Top = 10000000;
                PictureBox16.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox17.Bounds))
            {
                isAppleHit();
                PictureBox17.Top = 10000000;
                PictureBox17.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox18.Bounds))
            {
                isAppleHit();
                PictureBox18.Top = 10000000;
                PictureBox18.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox19.Bounds))
            {
                isAppleHit();
                PictureBox19.Top = 10000000;
                PictureBox19.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox20.Bounds))
            {
                isAppleHit();
                PictureBox20.Top = 10000000;
                PictureBox20.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox21.Bounds))
            {
                isAppleHit();
                PictureBox21.Top = 10000000;
                PictureBox21.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox22.Bounds))
            {
                isAppleHit();
                PictureBox22.Top = 10000000;
                PictureBox22.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox23.Bounds))
            {
                isAppleHit();
                PictureBox23.Top = 10000000;
                PictureBox23.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox24.Bounds))
            {
                isAppleHit();
                PictureBox24.Top = 10000000;
                PictureBox24.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox25.Bounds))
            {
                isAppleHit();
                PictureBox25.Top = 10000000;
                PictureBox25.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox26.Bounds))
            {
                isAppleHit();
                PictureBox26.Top = 10000000;
                PictureBox26.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox27.Bounds))
            {
                isAppleHit();
                PictureBox27.Top = 10000000;
                PictureBox27.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox28.Bounds))
            {
                isAppleHit();
                PictureBox28.Top = 10000000;
                PictureBox28.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox29.Bounds))
            {
                isAppleHit();
                PictureBox29.Top = 10000000;
                PictureBox29.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox30.Bounds))
            {
                isAppleHit();
                PictureBox30.Top = 10000000;
                PictureBox30.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox31.Bounds))
            {
                isAppleHit();
                PictureBox31.Top = 10000000;
                PictureBox31.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox32.Bounds))
            {
                isAppleHit();
                PictureBox32.Top = 10000000;
                PictureBox32.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox33.Bounds))
            {
                isAppleHit();
                PictureBox33.Top = 10000000;
                PictureBox33.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox34.Bounds))
            {
                isAppleHit();
                PictureBox34.Top = 10000000;
                PictureBox34.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox35.Bounds))
            {
                isAppleHit();
                PictureBox35.Top = 10000000;
                PictureBox35.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox36.Bounds))
            {
                isAppleHit();
                PictureBox36.Top = 10000000;
                PictureBox36.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox37.Bounds))
            {
                isAppleHit();
                PictureBox37.Top = 10000000;
                PictureBox37.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox38.Bounds))
            {
                isAppleHit();
                PictureBox38.Top = 10000000;
                PictureBox38.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox39.Bounds))
            {
                isAppleHit();
                PictureBox39.Top = 10000000;
                PictureBox39.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox40.Bounds))
            {
                isAppleHit();
                PictureBox40.Top = 10000000;
                PictureBox40.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox41.Bounds))
            {
                isAppleHit();
                PictureBox41.Top = 10000000;
                PictureBox41.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox42.Bounds))
            {
                isAppleHit();
                PictureBox42.Top = 10000000;
                PictureBox42.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox43.Bounds))
            {
                isAppleHit();
                PictureBox43.Top = 10000000;
                PictureBox43.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox44.Bounds))
            {
                isAppleHit();
                PictureBox44.Top = 10000000;
                PictureBox44.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox45.Bounds))
            {
                isAppleHit();
                PictureBox45.Top = 10000000;
                PictureBox45.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox46.Bounds))
            {
                isAppleHit();
                PictureBox46.Top = 10000000;
                PictureBox46.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox47.Bounds))
            {
                isAppleHit();
                PictureBox47.Top = 10000000;
                PictureBox47.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox48.Bounds))
            {
                isAppleHit();
                PictureBox48.Top = 10000000;
                PictureBox48.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox49.Bounds))
            {
                isAppleHit();
                PictureBox49.Top = 10000000;
                PictureBox49.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox50.Bounds))
            {
                isAppleHit();
                PictureBox50.Top = 10000000;
                PictureBox50.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox51.Bounds))
            {
                isAppleHit();
                PictureBox51.Top = 10000000;
                PictureBox51.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox52.Bounds))
            {
                isAppleHit();
                PictureBox52.Top = 10000000;
                PictureBox52.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox53.Bounds))
            {
                isAppleHit();
                PictureBox53.Top = 10000000;
                PictureBox53.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox54.Bounds))
            {
                isAppleHit();
                PictureBox54.Top = 10000000;
                PictureBox54.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox55.Bounds))
            {
                isAppleHit();
                PictureBox55.Top = 10000000;
                PictureBox55.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox56.Bounds))
            {
                isAppleHit();
                PictureBox56.Top = 10000000;
                PictureBox56.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox57.Bounds))
            {
                isAppleHit();
                PictureBox57.Top = 10000000;
                PictureBox57.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox58.Bounds))
            {
                isAppleHit();
                PictureBox58.Top = 10000000;
                PictureBox58.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox59.Bounds))
            {
                isAppleHit();
                PictureBox59.Top = 10000000;
                PictureBox59.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox60.Bounds))
            {
                isAppleHit();
                PictureBox60.Top = 10000000;
                PictureBox60.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox61.Bounds))
            {
                isAppleHit();
                PictureBox61.Top = 10000000;
                PictureBox61.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox62.Bounds))
            {
                isAppleHit();
                PictureBox62.Top = 10000000;
                PictureBox62.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox63.Bounds))
            {
                isAppleHit();
                PictureBox63.Top = 10000000;
                PictureBox63.Visible = false;
            }
            if (PicSprite.Bounds.IntersectsWith(PictureBox64.Bounds))
            {
                // Call Golden Apple Method
                IsGolden_Apple_Hit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label1.Bounds))
            {
                // Call Label Method
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label1.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label2.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label3.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label4.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label5.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label6.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label7.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label8.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label9.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label10.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label11.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label12.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label13.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label14.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label15.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label16.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label17.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label18.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label19.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label20.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label21.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label22.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label23.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label24.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label25.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label26.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label27.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label28.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label29.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label30.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label31.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label32.Bounds))
            {
                IsLabelHit();
            }
            if (PicSprite.Bounds.IntersectsWith(Label35.Bounds))
            {
                IsLabelHit();
            }

            // Call methods for moving sprites
            if (e.KeyCode == Keys.Left)
            {
                Move_Sprite_Left();
            }
            if (e.KeyCode == Keys.Right)
            {
                Move_Sprite_Right();
            }
            if (e.KeyCode == Keys.Up)
            {
                Move_Sprite_Up();
            }
            if (e.KeyCode == Keys.Down)
            {
                Move_Sprite_Down();
            }
            if (e.KeyCode == Keys.W)
            {
                Move_Sprite_Up();
            }
            if (e.KeyCode == Keys.A)
            {
                Move_Sprite_Left();

            }
            if (e.KeyCode == Keys.S)
            {
                Move_Sprite_Down();
            }
            if (e.KeyCode == Keys.D)
            {
                Move_Sprite_Right();

            }
            // Handle textbox cursor
            HideCaret(TextBoxKeyInput.Handle);
        }

        private void TimerRemaining_Tick(object sender, EventArgs e)
        {
            // When time is over the timer is disabled, message is displayed and app exits
            TimerRemaining.Enabled = false;
            MessageBox.Show("Out of Time");
            Application.Exit();
        }

        private void TimerDown_Tick(object sender, EventArgs e)
        {
            //  'Uses TimerCountDown variable to minus 1 at a rate of every second to give the illusion of a countdown, Default Value is 50 in the form which means it counts down from 50
            timercountdown = timercountdown - 1;
            //  'Outputs Timer Countdown to Label
            LabelTimeLeft.Text = timercountdown.ToString();
            //'Stops timerdown when countdown reaches 0 and disables it
            if (timercountdown == 0)
            {
                TimerDown.Enabled = false;
                TimerDown.Stop();
            }

            // 'Stops timerdown when Golden_Apple = True, also disables timer
            if (Golden_Apple == true)
            {
                TimerDown.Enabled = false;
                TimerDown.Stop();
            }
        }

        private void Apple_Runner_FormClosing(object sender, FormClosingEventArgs e)
        {
            // App Exit on close handle
            Application.Exit();
        }
        private void isAppleHit()
        {
            // Set collision to true
            collision = true;
            // Increment Score
            current_score = current_score + 100;
            // Display score in Label
            LabelScore.Text = current_score.ToString();
            // Set collision to false
            collision = false;
            // Use sound method
            PlayAppleBumpSound();
        }
        private void IsGolden_Apple_Hit()
        {
            // Set collision to true
            collision = true;
            // Set Golden Apple True
            Golden_Apple = true;
            // Increment Score
            current_score = current_score + 1000;
            // Display score in Label
            LabelScore.Text = current_score.ToString();
            // Set collision to false
            collision = false;
            // Play end of game sound
            PlayGoldenAppleSound();
            // Stop Timers
            TimerDown.Stop();
            TimerRemaining.Stop();
            // Show message
            MessageBox.Show("Well done you completed the game and scored " + current_score.ToString());
            // New instance of save file
            SaveFileDialog Score_Save = new SaveFileDialog();
            // Loop to make sure user saves file
            if (Score_Save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Set Path
                string path = Score_Save.FileName;
                // New BinaryWriter
                StreamWriter BW = new StreamWriter(File.Create(path));
                // Write Line and values
                BW.Write("User scored {0} points in {1} seconds on Apple Runner", current_score, CalculateTimeElapsed(userTime:time_Spent));
                // Dispose
                BW.Dispose();
            }
            // Exit
            Application.Exit();
        }
        private void IsLabelHit()
        {
            //Stop Timers
            TimerDown.Stop();
            TimerRemaining.Stop();
            // User Message
            MessageBox.Show("You hit a barrier and lost");
            // Exit App
            Application.Exit();
        }
        public int CalculateTimeElapsed(int userTime)
        {
            // Set variable to hold conversion
            int x = Convert.ToInt32(LabelTimeLeft.Text);
            // Calculate time elapsed by subtracting time elapsed from time given
            userTime = 50 - x;
            // Return Value
            return userTime;
        }
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
       
       
    }

}
       

   


