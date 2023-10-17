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
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (choiseMethod.SelectedIndex == 0)
                itogEncrypt.Text = singleReplace.Decoding(entryMassenge.Text);

            else if (choiseMethod.SelectedIndex == 1)
                itogEncrypt.Text = blockSingleReplace.Decoding(entryMassenge.Text);

            else if (choiseMethod.SelectedIndex == 2)
                itogEncrypt.Text = tableReplace.Decoding(entryMassenge.Text);
        }
    }
}