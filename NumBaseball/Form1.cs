using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumBaseball
{
    public partial class Form1 : Form
    {
        // 사용할 변수들 초기화
        private int Strike = 0;
        private int Ball = 0;
        private int Out = 0;
        private Boolean Homerun = false;

        // 배열은 미리 크기를 설정해둬야함.
        private int[] array = new int[3];
        private int[] arrayNum = new int[3];

        // 디자이너 폼에서 필수로 필요한 함수
        public Form1()
        {
            InitializeComponent();
        }

        // 숫자 확인 함수
        private void Hit_Click(object sender, EventArgs e)
        {
            // 텍스트박스에 있는 String을 Int로 변경
            int InputNum = Int32.Parse(TextBox.Text);
            // 세 자리 수로 게임 진행 예정
            if (TextBox.Text == "")
            {
                Result.Text = "숫자를 입력해주세요.";
            } else if (InputNum < 100 || InputNum >= 1000)
            {
                Result.Text = "숫자 세자리만 입력하세요.";
            } else  // 숫자가 세자리일 때
            {
                // 다시 초기화
                Strike = 0;
                Ball = 0;
                Out = 0;
                Homerun = false;

                // 미리 선언해둔 배열에 각 자리수 숫자 넣기
                for (int i = 0; i < 3; i++)
                {
                    arrayNum[i] = InputNum % 10;
                    InputNum /= 10;
                }

                // 자리와 값까지 똑같으면 Strike
                for (int i = 0; i < 3; i++)
                {
                    if (arrayNum[i] == array[i])
                    {
                        Strike++;
                    }
                    // Array.IndexOf -> 지정한 개체를 검색하여 1차원 배열 또는 배열의 요소 범위에서 처음으로 일치하는 인덱스를 반환합니다.
                    // 지정한 객체 (array[i]), 1차원 배열 (arrayNum), 일치하는 자리의 인덱스 출력, 일치하지 않는다면 -1 출력
                    else if (Array.IndexOf(arrayNum, array[i]) != -1)
                    {
                        Ball++;
                    }
                    else
                    {
                        Out++;
                    }
                }
                // 3스트라이크는 홈런이죠
                if (Strike == 3)
                {
                    Result.Text = "HomeRun";
                }
                // 그 이외에는 결과값 출력
                else
                {
                    Result.Text = Strike + "S " + Ball + "B " + Out + "O";
                }
            }
        }

        // 숫자 재생성
        private void makeNum_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            // 랜덤한 숫자 배열 생성
            for (int i = 0; i < 3; i++)
            {
                array[i] = rand.Next(1, 10);
                // 중복되는 숫자 없애기
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            Result.Text = "0Strike 0Ball 0Out";
            TextBox.Text = "";
        }
    }
}
