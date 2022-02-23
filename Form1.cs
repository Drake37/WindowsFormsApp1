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
    public delegate void Undo();
    public partial class Form1 : Form
    {
        #region Main fields

        int _compNum;
        int _userNum = 1;
        int _steps;
        Random random = new Random();
        Stack<Undo> undos = new Stack<Undo>();

        #endregion

        #region Main methods
        public Form1()
        {
            InitializeComponent();
            // подписка для всех calc buttons
            foreach (Button control in Controls.OfType<Button>())
            {
                if (control.Tag != null && control.Tag.ToString() == "calc")
                {
                    control.Click += new EventHandler(btCalc_Click);
                }
            }
            _StartNewGame();
        }
        void _StartNewGame()
        {
            _userNum = 1;
            _steps = 0;
            _compNum = random.Next(10, 50);
            lbCompNum.Text = $"Generated number: {_compNum}";
            _UpdGameState();
            undos.Clear();
        }
        void _UpdGameState()
        {
            _CheckEndGame();
            lbUserNum.Text = $"Your number: {_userNum}";
            lbSteps.Text = $"Steps: {_steps}";

        }
        void _CheckEndGame()
        {
            if (_userNum == _compNum)
            {
                if (MessageBox.Show($"Game over\nSteps = {_steps - 1}\nRetry?", "Удвоитель", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    _StartNewGame();
                else Close();
            }

        } 
        #endregion

        #region Calc methods
        void _Calc()
        {
            _steps++;
            _UpdGameState();
        }
        void _CalcReverse()
        {
            _steps--;
            _UpdGameState();
        }
        void _MinusOne()
        {
            _userNum--;
            _CalcReverse();
        }
        void _DivideBy2()
        {
            _userNum /= 2;
            _CalcReverse();
        } 
        #endregion

        #region Click methods
        private void btNewGame_Click(object sender, EventArgs e)
        {
            _StartNewGame();
        }

        private void btPlusOne_Click(object sender, EventArgs e)
        {
            _userNum++;
            undos.Push(new Undo(_MinusOne));
        }

        private void btMultiTwo_Click(object sender, EventArgs e)
        {
            _userNum *= 2;
            undos.Push(new Undo(_DivideBy2));
        }
        private void btUndo_Click(object sender, EventArgs e)
        {
            Undo undo;
            if (undos.Count > 0)
            {
                undo = undos.Pop();
                undo();
            }
        }
        /// <summary>
        /// Общий метод для всех кнопок, считающих значение
        /// Подписка добавлена в конструктор
        /// </summary>
        void btCalc_Click(object sender, EventArgs e)
        {
            _Calc();
        } 
        #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Show();
        }
    }
}
