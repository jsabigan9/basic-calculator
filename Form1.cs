using System;
using System.Windows.Forms;

namespace basic_calculator
{
    public partial class Form1 : Form
    {
        private string op;
        private double val;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNumberClick(object sender, EventArgs e)
        {
            // This prevents errors if clicked on empty space on form designer
            if (sender is Button btn)
            {
                if (txtNumber.Text == "0")
                {
                    txtNumber.Text = btn.Text;
                }
                else
                {
                    txtNumber.Text = $"{txtNumber.Text}{btn.Text}";
                }
            }

        }

        private void BtnOperationClick(object sender, EventArgs e)
        {

            var btn = (Button)sender;
            double newVal = Convert.ToDouble(txtNumber.Text);

            switch (btn.Text)
            {
                case "*":
                case "/":
                case "+":
                case "-":
                    val = newVal;
                    op = btn.Text;
                    txtNumber.Text = "0";
                    break;

                case ".":
                    if (!txtNumber.Text.Contains("."))
                    {
                        txtNumber.Text = $"{txtNumber.Text}.";
                    }
                    break;

                case "=":
                    val = op == "*" ? val *= newVal :
                          op == "/" ? val /= newVal :
                          op == "+" ? val += newVal :
                          op == "-" ? val -= newVal : val;

                    txtNumber.Text = $"{val:0.###}";
                    break;

                case "%":
                    txtNumber.Text = $"{newVal / 100}:0.###";
                    break;

                case "+/-":
                    txtNumber.Text = $"{-newVal:0.###}";
                    break;

                case "AC":
                    val = 0;
                    op = "";
                    txtNumber.Text = "0";
                    break;
            }

        }
    }
}
