using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace MineFieldNew
{
    public partial class FormMineField : Form
    {
        public FormMineField()
        {
            InitializeComponent();
            timerUp.Stop();
            timerDown.Stop();
            using (StreamWriter file = new StreamWriter("LeaderBoard.txt", true)) //allowing you to write the selection objects or values to be saved into "Leaderboard.txt"
            {
                
            }
            using (StreamReader sr = new StreamReader("LeaderBoard.txt"))
            {
                tbLeaderboard.Text = sr.ReadToEnd();
            }
        }
        const int maxRows = 20;
        const int maxCols = 20;
        const int labelCount = maxCols * maxRows; //declaring what the size of the grid will intale.

        int atCol;
        int atRow;
        int seconds = 0;
        bool Mute;

        bool[,] bombs = new bool[20, 20]; // delcaring where to place the bombs currently its within the 20 by 20.

        Label[] gridLabel = new Label[labelCount]; //declaring the grid to create labels.

        private bool RadioButEasy = false; //switch the values for radiobuttons to false.
        private bool RadioButMedium = false;
        private bool RadioButHard = false;

        private bool ButtonFamilyWasClicked = false; //switch the values for character buttons to false.
        private bool ButtonRabbitWasClicked = false;
        private bool ButtonCatWasClicked = false;
        private bool ButtonDogWasClicked = false;

        private void Form1_Load(object sender, EventArgs e)
        {

            lblUserName.Text = FrmLogIn.SetValueForName1;//display the name which was entered in the login screen.

            atRow = 19;
            atCol = 10; //the character will be starting at Row 19 and Colum 10.

            createLabelGrid();
            ShowSpriteAt(maxRows, maxCols);//once starts the form will load and create the grid and show the player.
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //allows to you to close and restart the game.
        }

        private void createLabelGrid()

        {

            int x_loc = 0;
            int y_loc = 0; //delcaring X and Y being 0's to allow the labels being created from the points 0,0.
            for (int i = 0; i < (labelCount); i++)
            {

                gridLabel[i] = new Label();
                gridLabel[i].Size = new Size(maxCols, maxRows);
                gridLabel[i].Location = new Point(x_loc, y_loc);
                gridLabel[i].BackColor = Color.SkyBlue;
                gridLabel[i].Name = "label" + (i + 1).ToString();
                panel1.Controls.Add(gridLabel[i]); //For loop to repeat the creation of labels from looking at Line
                //19 -> 21 using string manibulation and also array's.

                x_loc += maxCols;
                if (x_loc == labelCount)
                {
                    x_loc = 0;
                    y_loc += maxRows;
                }
            }

        }

        private void TimerDown_Tick(object sender, EventArgs e)
        {
            if (RadioButMedium) //this button allows you to display a count down time.
            {
                lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
                if (lblTime.Text == "10")//changes the color to red when you 10.
                {
                    this.BackColor = Color.DarkRed;
                }
            }
            else if (RadioButHard)
            {
                lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
                if (lblTime.Text == "10")//changes the color to red when you 10.
                {
                    this.BackColor = Color.DarkRed;
                }
            }
            else
                return;
        }

        private void TimerUp_Tick(object sender, EventArgs e)
        {
            seconds++; //allows to count up and displayed
            lblTime.Text = seconds.ToString();
        }

        private void plantBombs(int target)
        {
            Random r = new Random(); //setting a random value to the letter 'r'.

            int tryCol, tryRow;
            int setSoFar = 0;

            Array.Clear(bombs, 0, bombs.Length);
            //loop to fill arrat with number of bombs
            do
            {
                tryCol = r.Next(0, 20);
                tryRow = r.Next(0, 19); //setting so there is no bombs on the bottom row
                if (!bombs[tryCol, tryRow])
                {
                    bombs[tryCol, tryRow] = true;
                    setSoFar++; //allowing to place bombs if they are not set at tryCol and tryRow.
                }
            } while (setSoFar < target);
        }

        private Label getLabel(int atCol, int atRow)
        {
            int k = atRow * 20 + atCol + 1; // this will create a sprite aka a character
            string s = "label" + k.ToString();

            foreach (Control c in panel1.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.Label))
                {
                    if (c.Name == s)
                    {
                        return (Label)c;
                    }
                }
            }
            return null;
        }

        private void Start()
        {

            gameSound();//plays background music for the game.

            //checks both radio button and character buttons if they are selected before enabling the buttons.
            if (RadioButEasy && (ButtonDogWasClicked || ButtonCatWasClicked || ButtonFamilyWasClicked || ButtonRabbitWasClicked))
            {
                btnUp.Enabled = true;
                BtnDown.Enabled = true;
                BtnRight.Enabled = true;
                BtnLeft.Enabled = true;
            }
            else if (RadioButMedium && (ButtonDogWasClicked || ButtonCatWasClicked || ButtonFamilyWasClicked || ButtonRabbitWasClicked))
            {
                btnUp.Enabled = true;
                BtnDown.Enabled = true;
                BtnRight.Enabled = true;
                BtnLeft.Enabled = true;
            }
            else if (RadioButHard && (ButtonDogWasClicked || ButtonCatWasClicked || ButtonFamilyWasClicked || ButtonRabbitWasClicked))
            {
                btnUp.Enabled = true;
                BtnDown.Enabled = true;
                BtnRight.Enabled = true;
                BtnLeft.Enabled = true;
            }
            else
                return;
        }

        private void ShowSpriteAt(int maxCols, int maxRows)
        {

            Label lbl = getLabel(atCol, atRow); //displaying the character onto the grid with the selected character
            lbl.BackColor = Color.White;
            if (ButtonCatWasClicked)
                lbl.Image = Properties.Resources.cat;
            else if (ButtonDogWasClicked)
                lbl.Image = Properties.Resources.dog;
            else if (ButtonFamilyWasClicked)
                lbl.Image = Properties.Resources.family;
            else if (ButtonRabbitWasClicked)
                lbl.Image = Properties.Resources.Bunny;
            else
                return;

        }

        private void HideSpriteAt(int maxCols, int maxRows)
        {
            Label lbl = getLabel(atCol, atRow); //hide the sprite once u load the game and if u die.
            lbl.Image = null;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            showBombs(); //shows the bombs on the grid
            timerbomb.Start(); //starts the bomb
            Start(); //runs the start function.

            if (RadioButEasy) //depending on the timer set the time value.
            {
                timerUp.Start();
            }
            else if (RadioButMedium)
            {
                timerDown.Start();
            }
            else if (RadioButHard)
            {
                timerDown.Start();
            }
            else
                return;
        }

        private int bombCount(int atCol, int atRow)
        {
            int sofar = 0; //declaring there is no bombs currently.

            if (atCol > 0) // if the column is greater than  0 place a bomb.
            {
                if (bombs[atCol - 1, atRow])
                    sofar++;
            }
            if (atCol < 19) // if the column is less than 19 place a bomb.
            {
                if (bombs[atCol + 1, atRow])
                    sofar++;
            }
            if (atRow > 0) // if the row is greater than 0 place a bomb.
            {
                if (bombs[atCol, atRow - 1])
                    sofar++;
            }
            if (atRow < 19) // if the row is less than 19 place a bomb.
                if (bombs[atCol, atRow + 1])
                    sofar++;
            return
                sofar;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (lblTime.Text == "Time:")
            {
                MessageBox.Show("Please read the instruction within the help button before starting the game");
                //checks if the button is enabled to allow the use of W,A,S,D and Up,Down,Right and Left.
            }
            else
            {
                if (bombs[atCol, atRow])//if player hits the bomb dont allow the use of the key's
                {

                }
                else
                {
                    Label lbl = getLabel(atCol, atRow); //allowing the use of UP,DOWN,RIGHT AND LEFT ARROWS.
                    if (keyData == Keys.Up || keyData == Keys.W)
                    {
                        BtnUp_Click(null, null);
                        return true;
                    }
                    if (keyData == Keys.Down || keyData == Keys.S)
                    {
                        BtnDown_Click(null, null);
                        return true;
                    }
                    if (keyData == Keys.Left || keyData == Keys.A)
                    {
                        BtnLeft_Click(null, null);
                        return true;
                    }
                    if (keyData == Keys.Right || keyData == Keys.D)
                    {
                        BtnRight_Click(null, null);
                        return true;
                    }
                }
                
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void BtnUp_Click(object sender, EventArgs e)
        {
            if (atRow > 0) //Checking if the spire is on the edge of the map.
            {
                HideSpriteAt(atCol, atRow);
                atRow--;
                ShowSpriteAt(atCol, atRow);
                amIDead(atCol, atRow); //Checks if the sprite is alive of dead.
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (atCol > 0) //Checking if the spire is on the edge of the map.
            {
                HideSpriteAt(atCol, atRow);
                atCol--;
                ShowSpriteAt(atCol, atRow);
                amIDead(atCol, atRow); //checks if the sprite is alive of dead.
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            if (atRow < 19) //Checking if the spire is on the edge of the map.
            {
                HideSpriteAt(atCol, atRow);
                atRow++;
                ShowSpriteAt(atCol, atRow);
                amIDead(atCol, atRow); //checks if the sprite is alive of dead.
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (atCol < 19) //Checking if the Sprite (character) is on the edge of the map.
            {
                HideSpriteAt(atCol, atRow);
                atCol++;
                ShowSpriteAt(atCol, atRow);
                amIDead(atCol, atRow); //checks if the sprite is alive of dead.
            }
        }


        private void BtnPerson_Click(object sender, EventArgs e)
        {
            int atRow1; //Delcaring where the end of the goal will be.
            int atCol1;

            atRow1 = 0;
            atCol1 = 0;

            Label lbl1 = getLabel(atRow1, atCol1); //declaring where the house is.
            lbl1.Image = Properties.Resources.house;
            lbl1.BackColor = Color.White;
            Label lbl = getLabel(atCol, atRow);
            lbl.Image = Properties.Resources.family; //delcaring the image for btnperson.
            ButtonFamilyWasClicked = true;
            BtnDog.Enabled = false;
            BtnCat.Enabled = false;
            btnPerson.Enabled = false;
            btnRabbit.Enabled = false;
        }

        private void BtnRabbit_Click(object sender, EventArgs e)
        {
            int atRow1;//Delcaring where the end of the goal will be.
            int atCol1;

            atRow1 = 0;
            atCol1 = 0;

            Label lbl1 = getLabel(atRow1, atCol1);
            lbl1.Image = Properties.Resources.carrot;//declaring where the carrot is.
            lbl1.BackColor = Color.White;
            Label lbl = getLabel(atCol, atRow);
            lbl.Image = Properties.Resources.Bunny;//delcaring the image for btnrabbit.
            ButtonRabbitWasClicked = true;
            BtnDog.Enabled = false;
            BtnCat.Enabled = false;
            btnPerson.Enabled = false;
            btnRabbit.Enabled = false;
        }

        private void BtnCat_Click(object sender, EventArgs e)
        {
            int atRow1;//Delcaring where the end of the goal will be.
            int atCol1;

            atRow1 = 0;
            atCol1 = 0;

            Label lbl1 = getLabel(atRow1, atCol1);//declaring where the rat is.
            lbl1.Image = Properties.Resources.rat;
            lbl1.BackColor = Color.White;
            Label lbl = getLabel(atCol, atRow);
            lbl.Image = Properties.Resources.cat;//delcaring the image for btncat.
            ButtonCatWasClicked = true;
            BtnDog.Enabled = false;
            BtnCat.Enabled = false;
            btnPerson.Enabled = false;
            btnRabbit.Enabled = false;
        }

        private void BtnDog_Click(object sender, EventArgs e)
        {
            int atRow1;//Delcaring where the end of the goal will be.
            int atCol1;

            atRow1 = 0;
            atCol1 = 0;

            Label lbl1 = getLabel(atRow1, atCol1);//declaring where the pet house is.
            lbl1.Image = Properties.Resources.pet_house;
            lbl1.BackColor = Color.White;
            Label lbl = getLabel(atCol, atRow);
            lbl.Image = Properties.Resources.dog;//delcaring the image for btndog.
            ButtonDogWasClicked = true;
            BtnDog.Enabled = false;
            BtnCat.Enabled = false;
            btnPerson.Enabled = false;
            btnRabbit.Enabled = false;
        }

        

        private void RBEasy_CheckedChanged(object sender, EventArgs e)
        {
            RadioButEasy = true;//declaring the radio button being pressed.
            plantBombs(30); //plants 30 bombs.
            this.Refresh(); //refreshes the application
            RBMedium.Enabled = false; //declares the rest of the radio button to be false.
            RBHard.Enabled = false;
            lblLevel.Text = "EASY"; //display the lblLevel to be easy.
        }

        private void RBMedium_CheckedChanged(object sender, EventArgs e)
        {
            RadioButMedium = true;//declaring the radio button being pressed.
            plantBombs(60);//plants 60 bombs
            this.Refresh();//refreshes the application
            RBEasy.Enabled = false;//declares the rest of the radio button to be false.
            RBHard.Enabled = false;
            lblTime.Text = "100";//declaring the lbltime to start at 100 for the timer down to start counting down.
            lblLevel.Text = "MEDIUM";//display the lblLevel to be Medium.
        }

        private void RBHard_CheckedChanged(object sender, EventArgs e)
        {
            RadioButHard = true;//declaring the radio button being pressed.
            plantBombs(90);//plants 90 bombs
            this.Refresh();//refreshes the application
            RBEasy.Enabled = false;//declares the rest of the radio button to be false.
            RBMedium.Enabled = false;
            lblTime.Text = "70";//declaring the lbltime to start at 70 for the timer down to start counting down.
            lblLevel.Text = "HARD";//display the lblLevel to be Hard.
        }

        private void BtnLeadaboard_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter("LeaderBoard.txt", true)) //allowing you to write the selection objects or values to be saved into "Leaderboard.txt"
            {
                file.WriteLine(lblUserName.Text + " ---  " + lblLevel.Text + "  ---  " + lblTime.Text); //these values will be saved into "Leaderboard.txt".
            }
            using (StreamReader sr = new StreamReader("LeaderBoard.txt"))//searching for a file to read
            {
                tbLeaderboard.Text = sr.ReadToEnd(); //once read display it to tbLeaderboard.
            }
        }

        int i = 0;

        private void BtnMute_Click(object sender, EventArgs e)
        {

            if (i == 0 || btnMute.BackColor == Color.Transparent)
            {
                btnMute.BackColor = Color.Red;//turns the mute button to red.
                i++;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Guile_Theme__SNES_);
                player.Stop(); //if pressed stop the music
                Mute = true;//turns the mute value to true.
            }
            else if (i == 1 || btnMute.BackColor == Color.Red)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Guile_Theme__SNES_);
                player.Play(); //if the mute button is false play sound.
                btnMute.BackColor = Color.Transparent;//turns the mute button to transparent to display that the mute button isnt used.
                i++;
                Mute = false;//turns the mute value to false.
            }
        }

        private void amIDead(int atCol, int aRow)
        {
            if (bombs[atCol, atRow])//if the character is dead
            {
                sound(); //plays the sound when u die
                endgame();//displays the end game function
                showBombs();//shows where the bombs are on
                lblbomb.Text = "U are dead!!!! :((((";//changes the label.
                BtnStart.Enabled = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Guile_Theme__SNES_);
                player.Stop(); //stop the sound.
            }
            else if (atCol == 0 && atRow == 0)//if the character reaches the end
            {
                this.BackColor = Color.PeachPuff;//change the color to peachpuff/.
                btnUp.Enabled = false;//disables the btn directions.
                BtnDown.Enabled = false;
                BtnRight.Enabled = false;
                BtnLeft.Enabled = false;
                showBombs();//shows the bombs when u win
                lblbomb.Text = "YA WON!!!!";//changes the label
                timerDown.Stop();
                timerUp.Stop();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Guile_Theme__SNES_);
                player.Stop(); //stops the sound.
            }
            else
            {
                lblbomb.Text = "Danger Level:" + bombCount(atCol, atRow);//if non of the values are a thing.
            }
        }

        private void showBombs()
        {
            Label lbl; //gets a label value.
            for (int atRow = 0; atRow < 20; atRow++) //declaring the bombs to not be on the bottom
            {
                for (int atCol = 0; atCol < 20; atCol++) //declaring the bombs not be on col 20
                {
                    lbl = getLabel(atCol, atRow);//gets labels for 20 and 20 of the scales 
                    lbl.Image = null; //declare the image as blank.
                    if (bombs[atCol, atRow])
                    {
                        lbl.BackColor = Color.Red; //bombs turns red.
                    }
                    else
                    {
                        lbl.BackColor = Color.LightGray; //bombs grey if not touched.
                    }
                }
            }
        }

        private void gameSound()
        {
            if (Mute == false && btnUp.Enabled == false)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Guile_Theme__SNES_);
                player.Play(); //if the mute button is false play sound.
            }
            else
            {
                //if not false play nothing
            }
        }

        private void sound()
        {
            if (Mute == false) 
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.BoomNoise);
                player.Play(); //if the mute button is false play sound.
            }
            else
            {
                //if not false play nothing
            }
        }

        private void endgame()
        {
            this.BackColor = Color.Orange; //declares the backcolor of the form to orange.
            btnUp.Enabled = false; //disbles the btns direction to be false,
            BtnDown.Enabled = false;
            BtnRight.Enabled = false;
            BtnLeft.Enabled = false;
            timerUp.Stop(); //stops both up and down timer.
            timerDown.Stop();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart(); //restarts the application.
            Environment.Exit(0);
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a difficulty from the top right (Easy, Medium and Hard) this will place certain amount of bombs (Easy = 30 bombs, Medium = 60 bombs and Hard = 90)" + "                              "
                + "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                + "Once selected the difficulty select a character which is displayed on the bottom left this will display what character you will be playing as, it will also display the end goal.    "
                + "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                + "Once both steps are completed you can then start the application with the start button. To move around the game you can either use the buttons which are on the left hand side or could use " +
                "the A,S,W,D key's or could also use the arrow keys on the keyboard.                                      " +
                "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" +
                "You can save your time, name and also difficulty into a leaderboard system which will be saved and displayed within the box below, the Easy difficilty " +
                "is on a unlimited timer which won't be stopped however the Medium and Hard difficilty's will be restricted to a time.                       " +
                "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" +
                "The reset button will be avalible for you when you want to restart the game back to the login screen. ");
        }

        private void hidebombs () //hides the bombs
        {
            for (int i = 0; i < (labelCount); i++)
            {
                gridLabel[i].BackColor = Color.SkyBlue;
            }
                ShowSpriteAt(maxRows, maxCols);//once starts the form will load and create the grid and show the player.
        }
        private void timerbomb_Tick(object sender, EventArgs e)
        {
            timerbomb.Stop(); //stops the timerbomb from ticking.
            hidebombs(); //hides the bombs
        }
    }
}
