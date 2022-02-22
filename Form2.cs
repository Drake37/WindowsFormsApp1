using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
        int _randomNum = new Random().Next(50);
        const string TITLE = "Угадай число";
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            string msg = "";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (int.TryParse(tbNum.Text, out int input))
            {
                if (input == _randomNum)
                {
                    msg = "Вы угадали!\nНачать заново?";
                    buttons = MessageBoxButtons.YesNo;
                    icon = MessageBoxIcon.Question;
                }
                else if (input < _randomNum) msg = "Мое число больше";
                else msg = "Мое число меньше";
            }
            else
            {
                msg = "Введите число!";
                icon = MessageBoxIcon.Exclamation;
            }
            var ansver = MessageBox.Show(msg, TITLE, buttons, icon);
            if (ansver == DialogResult.Yes)
                _Reset();
            else if(ansver == DialogResult.No)
                Close();
        }
        void _Reset()
        {
            _randomNum = new Random().Next(50);
            tbNum.Text = "";
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            _Reset();
        }
    }
}
