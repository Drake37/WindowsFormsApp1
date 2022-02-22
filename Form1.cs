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
        int _compNum;
        int _userNum = 1;
        int _steps;
        Random random = new Random();
        Stack<Undo> undos = new Stack<Undo>();
        public Form1()
        {
            InitializeComponent();
            _StartNewGame();
        }
        void _UpdGameState()
        {
            _CheckEndGame();
            lbUserNum.Text = $"Your number: {_userNum}";
            lbSteps.Text = $"Steps: {_steps}";
            
        }        

        private void btNewGame_Click(object sender, EventArgs e)
        {
            _StartNewGame();
        }

        private void btPlusOne_Click(object sender, EventArgs e)
        {
            _userNum++;
            _steps++;
            _UpdGameState();
            undos.Push(new Undo(_MinusOne));
        }

        private void btMultiTwo_Click(object sender, EventArgs e)
        {
            _userNum *= 2;
            _steps++;
            _UpdGameState();
            undos.Push(new Undo(_DivideBy2));
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
        void _CheckEndGame()
        {
            if (_userNum == _compNum) {
                if (MessageBox.Show($"Game over\nSteps = {_steps - 1}\nRetry?", "Удвоитель", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    _StartNewGame();
                else Close();
            }

        }
        void _MinusOne()
        {
            _userNum--;
            _steps--;
            _UpdGameState();
        }
        void _DivideBy2()
        {
            _userNum /= 2;
            _steps--;
            _UpdGameState();
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
    }
}
