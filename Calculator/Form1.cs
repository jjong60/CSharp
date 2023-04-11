using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        // 연산자 열거형 정의 -> 정해진 범위에 있는 내용을 나타낼 때 주로 사용
        enum Operators
        {
            None,
            Add,
            Sub,
            Mul,
            Div,
            Res,
        }
        // 연산 종류, 연산버튼 클릭 여부, 두 피연산자 변수 선언 (초기 상태)
        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        // Boolean doubleCheck = false;
        int firstOperand = 0;
        int secondOperand = 0;
        // double firstDouble = 0;
        // double secondDouble = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonThree_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonFour_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonFive_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonEight_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonNine_Click(object sender, EventArgs e)
        {
            // 연산이 입력 되있는 상태일 때
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Sub;
            operatorChangeFlag = true;
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Mul;
            operatorChangeFlag = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Div;
            operatorChangeFlag = true;
        }

        private void buttonAllclear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            secondOperand = int.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Sub)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Mul)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Div)
            {
                if (firstOperand == 0 || secondOperand == 0)
                {
                    display.Text = "0으로 나눌수는 없습니다.";
                } else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }
        /*
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            firstDouble = Convert.ToDouble(firstOperand);
            doubleCheck = true;
        } */
    }
}