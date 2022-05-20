using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Application.Serivecs;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        private ICalculatorService _calculatorService;
        public Form1()
        {
            InitializeComponent();
            _calculatorService = new CalculatorService();
        }

        bool ValidInput()
        {
            bool isValid = true;
            if (txtFirstNumber.Value == 0)
            {
                isValid = false;
                MessageBox.Show("Please enter first number !");
            }else if (txtsecNumber.Value == 0)
            {
                isValid = false;
                MessageBox.Show("Please enter sec number !");
            }

            return isValid;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                int sum = _calculatorService.Puls(Convert.ToInt32(txtFirstNumber.Value),
                    Convert.ToInt32(txtsecNumber.Value));
                MessageBox.Show($"{txtFirstNumber.Value} + {txtsecNumber.Value} = {sum}");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                int minus = _calculatorService.Minus(Convert.ToInt32(txtFirstNumber.Value),
                    Convert.ToInt32(txtsecNumber.Value));
                MessageBox.Show($"{txtFirstNumber.Value} - {txtsecNumber.Value} = {minus}");
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                int Multiplication = _calculatorService.Multiplication(Convert.ToInt32(txtFirstNumber.Value),
                    Convert.ToInt32(txtsecNumber.Value));
                MessageBox.Show($"{txtFirstNumber.Value} * {txtsecNumber.Value} = {Multiplication}");
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                int Division = _calculatorService.Division(Convert.ToInt32(txtFirstNumber.Value),
                    Convert.ToInt32(txtsecNumber.Value));
                MessageBox.Show($"{txtFirstNumber.Value} / {txtsecNumber.Value} = {Division}");
            }
        }
    }
}
