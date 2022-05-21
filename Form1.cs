namespace WinFormsApp1
{
    public enum Operation
    {
        Magiclvlknight,  // activities to be enumerated for every profession
        Magiclvlpaladin,
        Magiclvldruid,
        Magiclvl,sorcerer
    }
    public partial class Form1 : Form
    {
        private string _firstValue; //started skill
        private string _secondValue; //ended skill
        //private Operation _currentOperation = Operation.None;

        private bool _isTheResultOnTheScreen;
        public Form1()
        {

            InitializeComponent();
            tb3Screen.Text = "0";
        }


     
 
        private void lblDoubleView(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var clickedValue = (sender as TextBox).Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Profession
        private void cboProState(object sender, EventArgs e) //combobox state profession
        {
            lblValue.Text = cboState.Text;
        }

        //Skills
        private void cboSkillState(object sender, EventArgs e) //combobox state skill
        {
            lblValue2.Text = cboState2.Text;
        }

        //Measures - œrodki
        private void cboMeasuresState(object sender, EventArgs e) 
        {
            lblValue3.Text = cboState3.Text;
        }
        
        //double exp/skill event
        private void cboDoubleState(object sender, EventArgs e)
        {
            lblValue4.Text = cboState4.Text;
        }





        private void tb1ScreenEnter(object sender, EventArgs e)
        {
            if (tb1Screen.Text == "your skill")
            {
                tb1Screen.Text = "";
                tb1Screen.ForeColor = Color.Black;
            }
        }

        private void tb1ScreenLeave(object sender, EventArgs e)
        {
            if (tb1Screen.Text == "")
            {
                tb1Screen.Text = "your skill";

                tb1Screen.ForeColor = Color.Silver;
            }
        }

        private void tb2ScreenEnter(object sender, EventArgs e)
        {
            if (tb2Screen.Text == "skill you want")
            {
                tb2Screen.Text = "";
                tb2Screen.ForeColor = Color.Black;
            }
        }

        private void tb2ScreenLeave(object sender, EventArgs e)
        {
            if (tb2Screen.Text == "")
            {
                tb2Screen.Text = "skill you want";
                tb2Screen.ForeColor = Color.Silver;
            }
        }

        private void tb3Screen_TextChanged(object sender, EventArgs e)
        {

        }
        private void OnBtnResultClick(object sender, EventArgs e)
        {
            if (cboState2.Text == "Sword Fighting")
            {
                picBox5.Visible = true;
                picBox6.Visible = false;
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }
            else if (cboState2.Text == "Club Fighting")
            {
                picBox5.Visible = false;
                picBox6.Visible = true;
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }
            else if (cboState2.Text == "Distance Fighting")
            {
                picBox5.Visible = false;
                picBox6.Visible = false;
                picBox7.Visible = true;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }
            else if (cboState2.Text == "Magic Level")
            {
                picBox5.Visible = false;
                picBox6.Visible = false;
                picBox7.Visible = false;
                picBox8.Visible = true;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }
            else if (cboState2.Text == "Fist Fighting")
            {
                picBox5.Visible = false;
                picBox6.Visible = false;
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = true;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }
            else if (cboState2.Text == "Axe Fighting")
            {
                picBox5.Visible = false;
                picBox6.Visible = false;
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = true;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }
            else if (cboState2.Text == "Fishing")
            {
                picBox5.Visible = false;
                picBox6.Visible = false;
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = true;
                picBox12.Visible = false;
            }
            else if (cboState2.Text == "Shielding")
            {
                picBox5.Visible = false;
                picBox6.Visible = false;
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = true;
            }
            else if (cboState2.Text == "None")
            {
                picBox5.Visible = false;
                picBox6.Visible = false;
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }

            //// 

            if (cboState.Text == "Knight")
            {
                picBox1.Visible = true;
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox4.Visible = false;
            }
            else if (cboState.Text == "Paladin")
            {
                picBox1.Visible = false;
                picBox2.Visible = true;
                picBox3.Visible = false;
                picBox4.Visible = false;
            }
            else if (cboState.Text == "Druid")
            {
                picBox1.Visible = false;
                picBox2.Visible = false;
                picBox3.Visible = true;
                picBox4.Visible = false;
            }
            else if (cboState.Text == "Sorcerer")
            {
                picBox1.Visible = false;
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox4.Visible = true;
            }
            else
            {
                picBox1.Visible = false;
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox4.Visible = false;
            }
            //////
            ///
            if (cboState3.Text == "Mana Potion")
            {
                picBox13.Visible = true;
                picBox14.Visible = false;
                picBox15.Visible = false;
                picBox16.Visible = false;
            }
            else if (cboState3.Text == "Strong Mana Potion")
            {
                picBox13.Visible = false;
                picBox14.Visible = true;
                picBox15.Visible = false;
                picBox16.Visible = false;
            }
            else if (cboState3.Text == "Great Mana Potion")
            {
                picBox13.Visible = false;
                picBox14.Visible = false;
                picBox15.Visible = true;
                picBox16.Visible = false;
            }
            else if (cboState3.Text == "Ultimate Mana Potion")
            {
                picBox13.Visible = false;
                picBox14.Visible = false;
                picBox15.Visible = false;
                picBox16.Visible = true;
            }
            else if (cboState3.Text == "None")
            {
                picBox13.Visible = false;
                picBox14.Visible = false;
                picBox15.Visible = false;
                picBox16.Visible = false;
            }
            ////
            ///
            if (cboState6.Text == "Life Ring")
            {
                picBox18.Visible = true;
                picBox19.Visible = false;
            }
            else if (cboState6.Text == "Ring of Healing")
            {
                picBox18.Visible = false;
                picBox19.Visible = true;
            }
            else if (cboState6.Text == "None")
            {
                picBox18.Visible = false;
                picBox19.Visible = false;
            }
            ////
            ///
            if (cboState4.Text == "Collar of Green Plasma")
            {
                picBox22.Visible = true;
            }
            if (cboState4.Text == "None")
            {
                picBox22.Visible = false;
            }
            ////
            ///
            if (cboState5.Text == "Training Axe") //24
            {
                picBox23.Visible = true;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Training Bow")
            {
                picBox23.Visible = false;
                picBox24.Visible = true;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Training Club")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = true;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Training Rod")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = true;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Training Sword")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = true;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Training Wand")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = true;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Exercise Axe")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = true;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Exercise Bow")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = true;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Exercise Club")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = true;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Exercise Rod")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = true;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Exercise Sword")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = true;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Exercise Wand")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = true;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Durable Exercise Axe")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = true;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Durable Exercise Bow")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = true;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Durable Exercise Club")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = true;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Durable Exercise Rod")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = true;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Durable Exercise Sword")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = true;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Durable Exercise Wand")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = true;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Lasting Exercise Axe")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = true;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Lasting Exercise Bow")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = true;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Lasting Exercise Club")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = true;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Lasting Exercise Rod")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = true;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Lasting Exercise Sword")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = true;
                picBox46.Visible = false;
            }
            else if (cboState5.Text == "Lasting Exercise Wand")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = true;
            }
            else if (cboState5.Text == "None")
            {
                picBox23.Visible = false;
                picBox24.Visible = false;
                picBox25.Visible = false;
                picBox26.Visible = false;
                picBox27.Visible = false;
                picBox28.Visible = false;
                picBox29.Visible = false;
                picBox30.Visible = false;
                picBox31.Visible = false;
                picBox32.Visible = false;
                picBox33.Visible = false;
                picBox34.Visible = false;
                picBox35.Visible = false;
                picBox36.Visible = false;
                picBox37.Visible = false;
                picBox38.Visible = false;
                picBox39.Visible = false;
                picBox40.Visible = false;
                picBox41.Visible = false;
                picBox42.Visible = false;
                picBox43.Visible = false;
                picBox44.Visible = false;
                picBox45.Visible = false;
                picBox46.Visible = false;
            }
            //Food
            if (checkBox1.Checked)
            {
                picBox20.Visible = true;
            }
            else
            {
                picBox20.Visible = false;
            }
            //Double skill
            if (checkBox2.Checked)
            {
                picBox17.Visible = true;
            }
            else
            {
                picBox17.Visible = false;
            }
            //Exercise Dummy
            if (checkBox3.Checked)
            {
                picBox21.Visible = true;
            }
            else
            {
                picBox21.Visible = false;
            }
            //Promotion
            if (checkBox4.Checked)
            {
                picBox47.Visible = true;
            }
            else
            {
                picBox47.Visible = false;
            }
            //if (_currentOperation == Operation.None)
            //    return;

            //var firstNumber = double.Parse(_firstValue);
            //var secondNumber = double.Parse(_secondValue);

            //var result = Calculate(firstNumber, secondNumber);

            //tb3Screen.Text = result.ToString();
            //_secondValue = String.Empty;
        }
        //private double Calculate(double firstNumber, double secondNumber)
        //{
        //    switch (_currentOperation)
        //    {
        //        case Operation.None:
        //            return firstNumber;

        //        case Operation.Subtraction:
        //            return secondNumber - firstNumber;
        //    }
        //    return 0;
        //}

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            tb1Screen.Text = "";
            tb2Screen.Text = "";
            tb3Screen.Text = "";
            //_firstValue = String.Empty;
            //_secondValue = String.Empty;
            cboState.Text = null;
            cboState2.Text = null;
            cboState3.Text = null;
            cboState4.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picBox19_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblValue3_Click(object sender, EventArgs e)
        {

        }

        private void lblValue2_Click(object sender, EventArgs e)
        {

        }
    }
}