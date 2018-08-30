using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Apple_Runner_CSharp
{
    public partial class Apple_Runner : Form
    {
        // Creates variables for use in moving sprite
        int ypos;
        int xpos;
        // Creates variable for use in detecting collision
        Boolean collision;
        // Creates variable for holding score
        int current_score = 0;
        //  Used for golden apple collison which stops the game
        Boolean golder_apple;
        int timercountdown = 50;
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
            LabelTimeLeft.Text = xpos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves left by 3
            xpos = xpos - 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_left);
            // // Debug Show Xpos in box
            LabelTimeLeft.Text = xpos.ToString();
        }
        private void Move_Sprite_Right()
        {
            // Debug Show Xpos in box
            LabelTimeLeft.Text = xpos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves right by 3
            xpos = xpos + 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_right);
            // // Debug Show Xpos in box
            LabelTimeLeft.Text = xpos.ToString();
        }
        private void Move_Sprite_Up()
        {
            // Debug Show Xpos in box
            LabelTimeLeft.Text = ypos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves up by 3
            ypos = ypos - 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_up);
            // // Debug Show Xpos in box
            LabelTimeLeft.Text = ypos.ToString();
        }
        private void Move_Sprite_Down()
        {
            // Debug Show Xpos in box
            LabelTimeLeft.Text = ypos.ToString();
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Moves down by 3
            ypos = ypos + 3;
            // Sets new point
            PicSprite.Location = new Point(xpos, ypos);
            // Loads left sprite image
            PicSprite.Image = (Apple_Runner_CSharp.Properties.Resources.man_going_down);
            // // Debug Show Xpos in box
            LabelTimeLeft.Text = ypos.ToString();
        }


        public void TextBoxKeyInput_KeyDown(object sender, KeyEventArgs e)
        {
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
        }
    }

 
    
}
