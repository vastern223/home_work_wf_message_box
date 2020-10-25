using System;
using System.Windows.Forms;

namespace home_work_wf_message_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            int number = 50;
            bool exit = true;
            int min = 1, max = 100;
            int count = 0;
            do
            {
                DialogResult res1 = MessageBox.Show($"це твоє число {number} ?", "game!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res1 == DialogResult.Yes)
                {
                    DialogResult res2 = MessageBox.Show($"я вгадав твоє число {number}\nкількість спроб: {count}\nбажеєш продовжити гру", "game!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res2 == DialogResult.Yes)
                    {
                        number = 50;
                        count = 0;
                        min = 1;
                        max = 100;
                    }
                    if (res2 == DialogResult.No)
                    {
                        exit = false;
                    }
                }
                else if (res1 == DialogResult.No)
                {
                    count++;
                    if (min == max)
                    { MessageBox.Show($"лгун ето твое число признайся -->{ number}", "game!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    else
                    {
                        DialogResult res3 = MessageBox.Show($"Загаданное число меньше или равно {number}", "game!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res3 == DialogResult.Yes)
                        {
                            max = number;

                        }
                        else if (res3 == DialogResult.No)
                        {

                            min = number + 1;

                        }
                        number = (min + max) / 2;
                    }
                }
            } while (exit);
        }

    }
}
