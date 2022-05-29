namespace WinFormsApp1
{
    public enum Operation
    {
        none,
        professionRatioDS,  // activities to be enumerated for every profession
        professionRatioP,
        professionRatioK,

    }
    public partial class Form1 : Form
    {
        private string _skillLevelTarget; //started skill
        private Operation _currentOperation = Operation.none;
        private string _secondValue;
        private string _skillLevel;
        private string _result; 

        //ended skill
        //private Operation _currentOperation = Operation.None;

        private bool _isTheResultOnTheScreen;
        public Form1()
        {

            InitializeComponent();
            tboxResults.Text = null;
        }

        //GENERAL WINDOW
        private void Form(object sender, EventArgs e)
        {

        }

        //LABELS

        private void lbProfessionText(object sender, EventArgs e)
        {

        }

        private void lbLevelText(object sender, EventArgs e)
        {

        }

        private void lbWeaponText(object sender, EventArgs e)
        {

        }

        private void lbSkillLevelText(object sender, EventArgs e)
        {

        }

        private void lbPercOfActSkillLevelText(object sender, EventArgs e)
        {

        }

        private void lbSkillLevelTargetText(object sender, EventArgs e)
        {

        }
        private void lbPercOfTarSkillLevelText(object sender, EventArgs e)
        {

        }

        private void lbTrainingItemText(object sender, EventArgs e)
        {

        }

        private void lbTrainingPotionText(object sender, EventArgs e)
        {

        }

        private void lbRingText(object sender, EventArgs e)
        {

        }

        private void lbAmuletText(object sender, EventArgs e)
        {

        }

        private void lbprogressBarText(object sender, EventArgs e)
        {

        }

        //text labels

        private void lbText1Text(object sender, EventArgs e)
        {

        }

        private void lbText2Text(object sender, EventArgs e)
        {

        }
        private void lbText3Text(object sender, EventArgs e)
        {

        }
        private void lbResultsText(object sender, EventArgs e)
        {

        }

        //COMBO BOXES

        private void cboxProfessionChoice(object sender, EventArgs e)
        {
            var selectedValue = (sender as ComboBox).SelectedItem;
            tboxResults.Text += selectedValue;
        }

        private void cboxWeaponChoice(object sender, EventArgs e)
        {

        }

        private void cboxTrainingItemChoice(object sender, EventArgs e)
        {

        }

        private void cboxTrainingPotionChoice(object sender, EventArgs e)
        {

        }

        private void cboxRingChoice(object sender, EventArgs e)
        {

        }

        private void cboxAmuletChoice(object sender, EventArgs e)
        {

        }

        //TEXT BOXES

        private void tboxLevelAdd(object sender, EventArgs e)
        {

        }

        private void tboxSkillLevelAdd(object sender, EventArgs e)
        {

        }

        private void tboxPercOfActSkillLevelAdd(object sender, EventArgs e)
        {

        }

        private void tboxSkillLevelTargetAdd(object sender, EventArgs e)
        {

        }

        private void tboxPercOfTargetSkillAdd(object sender, EventArgs e)
        {

        }

        private void progressBarLoad(object sender, EventArgs e)
        {

        }

        private void tboxResultsView(object sender, EventArgs e)
        {
            _skillLevelTarget = tboxSkillLevel.Text;

            //tb1Screen.Text = sender.ToString();
        }

        //CHECK BOXES

        private void checkBoxFoodClick(object sender, EventArgs e)
        {

        }

        private void checkBoxDoubleSkillClick(object sender, EventArgs e)
        {

        }

        private void checkBoxExeDummyClick(object sender, EventArgs e)
        {

        }

        private void checkBoxPromotionClick(object sender, EventArgs e)
        {

        }

        //BUTTONS

        private void buttonClearClick(object sender, EventArgs e)
        {
            cboxProfession.Text = null;
            tboxLevel.Text = "";
            cboxWeapon.Text = null;
            tboxSkillLevel.Text = "";
            tboxPercOfActSkillLevel.Text = "";

            tboxSkillLevelTarget.Text = "";
            tboxPercOfTargetSkill.Text = "";

            cboxTrainingItem.Text = null;
            cboxTrainingPotion.Text = null;
            cboxRing.Text = null;
            cboxAmulet.Text = null;

            checkBoxFood.Checked = false;
            checkBoxDoubleSkill.Checked = false;
            checkBoxExeDummy.Checked = false;
            checkBoxPromotion.Checked = false;

            tboxResults.Text = "";
        }

        private void buttonExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tboxPercOfTargetSkill_TextChanged(object sender, EventArgs e)
        {
             
            //var clickedValue = (sender as TextBox).Text;


        }

        private void tb2ScreenEnter(object sender, EventArgs e)
        {
            if (tboxSkillLevelTarget.Text == "skill you want")
            {
                tboxSkillLevelTarget.Text = "";
                tboxSkillLevelTarget.ForeColor = Color.Black;
            }
        }

        private void tb2ScreenLeave(object sender, EventArgs e)
        {
            if (tboxSkillLevelTarget.Text == "")
            {
                tboxSkillLevelTarget.Text = "skill you want";
                tboxSkillLevelTarget.ForeColor = Color.Silver;
            }
        }

        //przycisk calculate
        private void OnBtnResultClick(object sender, EventArgs e)
        {
            string operation = cboxProfession.Text;
            _currentOperation = operation switch
            {
                "Knight" => Operation.professionRatioK,
                "Paladin" => Operation.professionRatioP,
                "Sorcerer" => Operation.professionRatioDS,
                "Druid" => Operation.professionRatioDS,
            };

            _skillLevelTarget = tboxSkillLevel.Text; //skill lvl
            /* _secondValue = tboxSkillLevelTarget.Text; *////target skill
            _skillLevel = tboxSkillLevelTarget.Text;

            var firstNumber = double.Parse(_skillLevelTarget);
            var secondNumber = double.Parse(_skillLevel);
            var yml = double.Parse(_skillLevel);
            var potêga = double.Parse(_skillLevel);
            var potêga1 = double.Parse(_skillLevel);
            var potêga2 = double.Parse(_skillLevel);


            var result = Calculate(potêga, potêga1, potêga2, yml);
            double sum = firstNumber + secondNumber;
            tboxResults.Text = result.ToString();

            //var operation = (sender as ComboBox).Text; //SelectedItem

            //tboxResults.Text += $" {operation} ";

            //_currentOperation = operation switch
            //{
            //    "knight" => Operation.professionRatioK,
            //    "Paladin" => Operation.professionRatioP,
            //    "Sorcerer" => Operation.professionRatioDS,
            //    "Druid" => Operation.professionRatioDS,
            //    _ => Operation.none
            //};

            //var firstNumber = double.Parse(_skillLevelTarget);
            //var secondNumber = double.Parse(_secondValue);
            //var result = Calculate(firstNumber, secondNumber);
            //int no1, no2, sum;
            //no1 = Convert.ToInt32(tb1Screen.Text);
            //no2 = Convert.ToInt32(tboxSkillLevelTarget.Text);
            //sum = no1 + no2;
            //tboxResults.Text = sum.ToString();


            //Skills
            if (cboxWeapon.Text == "Sword Fighting")
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
            else if (cboxWeapon.Text == "Club Fighting")
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
            else if (cboxWeapon.Text == "Distance Fighting")
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
            else if (cboxWeapon.Text == "Magic Level")
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
            else if (cboxWeapon.Text == "Fist Fighting")
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
            else if (cboxWeapon.Text == "Axe Fighting")
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
            else if (cboxWeapon.Text == "Fishing")
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
            else if (cboxWeapon.Text == "Shielding")
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
            else if (cboxWeapon.Text == "None")
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

            //Profession
            if (cboxProfession.Text == "Knight")
            {
                picBox1.Visible = true;
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox4.Visible = false;
            }
            else if (cboxProfession.Text == "Paladin")
            {
                picBox1.Visible = false;
                picBox2.Visible = true;
                picBox3.Visible = false;
                picBox4.Visible = false;
            }
            else if (cboxProfession.Text == "Druid")
            {
                picBox1.Visible = false;
                picBox2.Visible = false;
                picBox3.Visible = true;
                picBox4.Visible = false;
            }
            else if (cboxProfession.Text == "Sorcerer")
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

            //Potions
            if (cboxTrainingPotion.Text == "Mana Potion")
            {
                picBox13.Visible = true;
                picBox14.Visible = false;
                picBox15.Visible = false;
                picBox16.Visible = false;
            }
            else if (cboxTrainingPotion.Text == "Strong Mana Potion")
            {
                picBox13.Visible = false;
                picBox14.Visible = true;
                picBox15.Visible = false;
                picBox16.Visible = false;
            }
            else if (cboxTrainingPotion.Text == "Great Mana Potion")
            {
                picBox13.Visible = false;
                picBox14.Visible = false;
                picBox15.Visible = true;
                picBox16.Visible = false;
            }
            else if (cboxTrainingPotion.Text == "Ultimate Mana Potion")
            {
                picBox13.Visible = false;
                picBox14.Visible = false;
                picBox15.Visible = false;
                picBox16.Visible = true;
            }
            else if (cboxTrainingPotion.Text == "None")
            {
                picBox13.Visible = false;
                picBox14.Visible = false;
                picBox15.Visible = false;
                picBox16.Visible = false;
            }

            //Rings
            if (cboxRing.Text == "Life Ring")
            {
                picBox18.Visible = true;
                picBox19.Visible = false;
            }
            else if (cboxRing.Text == "Ring of Healing")
            {
                picBox18.Visible = false;
                picBox19.Visible = true;
            }
            else if (cboxRing.Text == "None")
            {
                picBox18.Visible = false;
                picBox19.Visible = false;
            }

            //Amulets
            if (cboxAmulet.Text == "Collar of Green Plasma")
            {
                picBox22.Visible = true;
            }
            if (cboxAmulet.Text == "None")
            {
                picBox22.Visible = false;
            }

            //Training items
            if (cboxTrainingItem.Text == "Training Axe")
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
            else if (cboxTrainingItem.Text == "Training Bow")
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
            else if (cboxTrainingItem.Text == "Training Club")
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
            else if (cboxTrainingItem.Text == "Training Rod")
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
            else if (cboxTrainingItem.Text == "Training Sword")
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
            else if (cboxTrainingItem.Text == "Training Wand")
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
            else if (cboxTrainingItem.Text == "Exercise Axe")
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
            else if (cboxTrainingItem.Text == "Exercise Bow")
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
            else if (cboxTrainingItem.Text == "Exercise Club")
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
            else if (cboxTrainingItem.Text == "Exercise Rod")
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
            else if (cboxTrainingItem.Text == "Exercise Sword")
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
            else if (cboxTrainingItem.Text == "Exercise Wand")
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
            else if (cboxTrainingItem.Text == "Durable Exercise Axe")
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
            else if (cboxTrainingItem.Text == "Durable Exercise Bow")
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
            else if (cboxTrainingItem.Text == "Durable Exercise Club")
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
            else if (cboxTrainingItem.Text == "Durable Exercise Rod")
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
            else if (cboxTrainingItem.Text == "Durable Exercise Sword")
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
            else if (cboxTrainingItem.Text == "Durable Exercise Wand")
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
            else if (cboxTrainingItem.Text == "Lasting Exercise Axe")
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
            else if (cboxTrainingItem.Text == "Lasting Exercise Bow")
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
            else if (cboxTrainingItem.Text == "Lasting Exercise Club")
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
            else if (cboxTrainingItem.Text == "Lasting Exercise Rod")
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
            else if (cboxTrainingItem.Text == "Lasting Exercise Sword")
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
            else if (cboxTrainingItem.Text == "Lasting Exercise Wand")
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
            else if (cboxTrainingItem.Text == "None")
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
            if (checkBoxFood.Checked)
            {
                picBox20.Visible = true;
            }
            else
            {
                picBox20.Visible = false;
            }
            //Double skill
            if (checkBoxDoubleSkill.Checked)
            {
                picBox17.Visible = true;
            }
            else
            {
                picBox17.Visible = false;
            }
            //Exercise Dummy
            if (checkBoxExeDummy.Checked)
            {
                picBox21.Visible = true;
            }
            else
            {
                picBox21.Visible = false;
            }
            //Promotion
            if (checkBoxPromotion.Checked)
            {
                picBox47.Visible = true;
            }
            else
            {
                picBox47.Visible = false;
            }
        }

        private double Calculate(double potêga, double potêga1, double potêga2, double yml)
        {

            double constantnr = 1.600;
            //double result;

            switch (_currentOperation)
            {
                //case Operation.none:
                //    result = firstNumber;
                //    return result;

                case Operation.professionRatioK:

                    double professionRatioK = 1.6;
                    potêga = Math.Pow(professionRatioK, yml - 1);
                    //result = constantnr * potêga;
                    //return result;
                    return constantnr * potêga;

                case Operation.professionRatioP:

                    double professionRatioP = 1.4;
                    potêga1 = Math.Pow(professionRatioP, yml - 1);
                    //result =  constantnr * potêga1;
                    //return result;
                    return constantnr * potêga1;

                case Operation.professionRatioDS:

                    double professionRatioDS = 1.1;
                    potêga2 = Math.Pow(professionRatioDS, yml - 1);
                    //result = constantnr * potêga2;
                    //return result;
                    return constantnr * potêga2;
            }
            return 0;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picBox19_Click(object sender, EventArgs e)
        {

        }

        private void lbAmulet_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblValue3_Click(object sender, EventArgs e)
        {

        }

        private void lblValue2_Click(object sender, EventArgs e)
        {

        }


        private void lbText1_Click(object sender, EventArgs e)
        {

        }
    }
}