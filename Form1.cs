namespace PermutationShifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choiseMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choiseMethod.SelectedIndex == 0)
            {
                dopYsl.Visible = false;
                labelDopYsl.Visible = false;
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 1)
            {
                dopYsl.Visible = false;
                labelDopYsl.Visible = false;
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 2)
            {
                dopYsl.Visible = false;
                labelDopYsl.Visible = false;
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 3)
            {
                dopYsl.Visible = true;
                labelDopYsl.Visible = true;
                labelDopYsl.Text = "Дополнительные данные: слово";
                labelDopYsl.Location = new Point(451, 111);
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 4)
            {
                dopYsl.Visible = false;
                labelDopYsl.Visible = false;
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 5)
            {
                dopYsl.Visible = false;
                labelDopYsl.Visible = false;
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 6)
            {
                dopYsl.Visible = false;
                labelDopYsl.Visible = false;
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 7)
            {
                dopYsl.Visible = false;
                labelDopYsl.Visible = false;
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 8)
            {
                dopYsl.Visible = true;
                labelDopYsl.Visible = true;
                labelDopYsl.Text = "Дополнительные данные: слово";
                labelDopYsl.Location = new Point(451, 111);
                dopYsl.Text = "";
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (choiseMethod.SelectedIndex == 0)
                itogEncrypt.Text = singleReplace.Decoding(entryMassenge.Text);

            else if (choiseMethod.SelectedIndex == 1)
                itogEncrypt.Text = blockSingleReplace.Decoding(entryMassenge.Text);

            else if (choiseMethod.SelectedIndex == 2)
                itogEncrypt.Text = tableReplace.Decoding(entryMassenge.Text);

            else if (choiseMethod.SelectedIndex == 3)
                itogEncrypt.Text = verticalReplace.Decoding(entryMassenge.Text, dopYsl.Text);

            else if (choiseMethod.SelectedIndex == 4)
                itogEncrypt.Text = rotaryGrid.Decoding(entryMassenge.Text);

            else if (choiseMethod.SelectedIndex == 5)
                itogEncrypt.Text = magicSquare.Decoding(entryMassenge.Text);

            else if (choiseMethod.SelectedIndex == 6)
                itogEncrypt.Text = doubleReplace.Decoding(entryMassenge.Text);
            
            else if (choiseMethod.SelectedIndex == 7)
                itogEncrypt.Text = crossroad.Decoding(entryMassenge.Text);

            else if (choiseMethod.SelectedIndex == 8)
                itogEncrypt.Text = tringle.Decoding(entryMassenge.Text, dopYsl.Text);
        }
    }
}