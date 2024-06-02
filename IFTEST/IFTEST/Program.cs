using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFTEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 첫번째 문제
            /* 두 수 비교하기
             시간 제한 메모리 제한 제출  정답 맞힌 사람 정답 비율
             1 초 512 MB  465079  225033  184537  49.642 %
             문제
             두 정수 A와 B가 주어졌을 때, A와 B를 비교하는 프로그램을 작성하시오.

             입력
             첫째 줄에 A와 B가 주어진다. A와 B는 공백 한 칸으로 구분되어져 있다.

             출력
             첫째 줄에 다음 세 가지 중 하나를 출력한다.

             A가 B보다 큰 경우에는 '>'를 출력한다.
             A가 B보다 작은 경우에는 '<'를 출력한다.
             A와 B가 같은 경우에는 '=='를 출력한다.
             제한
             - 10,000 ≤ A, B ≤ 10,000
             예제 입력 1
             1 2
             예제 출력 1
             <
             예제 입력 2
             10 2
             예제 출력 2
             >
             예제 입력 3
             5 5
             예제 출력 3
             ==
             출처
             데이터를 추가한 사람: edecudo*/

            /*  string str = Console.ReadLine();
              string[] strs = str.Split();
              *//*
                          Console.WriteLine(strs[0]);
                          Console.WriteLine(strs[1]);
              *//*
              int str1 = int.Parse(strs[0]);
              int str2 = int.Parse(strs[1]);*/

            /*int a = str1;

            int b = str2;

            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (a < b)
            {
                Console.WriteLine("<");
            }
            else if (a == b)
            {
                Console.WriteLine("==");
            }*/
            #endregion

            #region 두번째 문제
            /*  시험 성적
              시간 제한   메모리 제한  제출 정답  맞힌 사람   정답 비율
              1 초 128 MB  413631  225524  189469  54.791 %
              문제
              시험 점수를 입력받아 90 ~100점은 A, 80 ~89점은 B, 70 ~79점은 C, 60 ~69점은 D, 나머지 점수는 F를 출력하는 프로그램을 작성하시오.

              입력
              첫째 줄에 시험 점수가 주어진다. 시험 점수는 0보다 크거나 같고, 100보다 작거나 같은 정수이다.

              출력
              시험 성적을 출력한다.

              예제 입력 1
              100
              예제 출력 1
              A
              출처
              문제를 만든 사람: baekjoon*/

            /* string str3 = Console.ReadLine();

             int num = int.Parse(str3);

             if (num >= 90 && num <= 100)
             {
                 Console.WriteLine("A");
             }
             else if (num >= 80 && num <= 89)
             {
                 Console.WriteLine("B");
             }
             else if (num >= 70 && num <= 79)
             {
                 Console.WriteLine("C");
             }
             else if (num >= 60 && num <= 69)
             {
                 Console.WriteLine("D");
             }
             else
             { 
                Console.WriteLine("F");
             }*/

            #endregion


            #region 세번째 문제
            /*   윤년
               시간 제한 메모리 제한 제출  정답 맞힌 사람 정답 비율
               1 초 128 MB  385606  200561  166929  51.765 %
               문제
               연도가 주어졌을 때, 윤년이면 1, 아니면 0을 출력하는 프로그램을 작성하시오.

               윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.

               예를 들어, 2012년은 4의 배수이면서 100의 배수가 아니라서 윤년이다. 1900년은 100의 배수이고 400의 배수는 아니기 때문에 윤년이 아니다. 하지만, 2000년은 400의 배수이기 때문에 윤년이다.

               입력
               첫째 줄에 연도가 주어진다.연도는 1보다 크거나 같고, 4000보다 작거나 같은 자연수이다.

               출력
               첫째 줄에 윤년이면 1, 아니면 0을 출력한다.

               예제 입력 1
               2000
               예제 출력 1
               1
               예제 입력 2
               1999
               예제 출력 2
               0*/
            /*
                        string str4 = Console.ReadLine();

                        int num = int.Parse(str4);

                        // 4의 배수 and (100의 배수가 아니거나 400의 배수)
                        if (num % 4 == 0 && (num % 100 != 0 || num % 400 == 0)) 
                        {
                            Console.Write("1");
                        }
                        else
                        {
                            Console.Write("0");
                        }*/

            #endregion


            #region 네번째 문제

            /*사분면 고르기 다국어
            시간 제한 메모리 제한 제출  정답 맞힌 사람 정답 비율
            1 초 512 MB  275889  166224  143578  60.940 %
            문제
            흔한 수학 문제 중 하나는 주어진 점이 어느 사분면에 속하는지 알아내는 것이다. 사분면은 아래 그림처럼 1부터 4까지 번호를 갖는다. "Quadrant n"은 "제n사분면"이라는 뜻이다.

            예를 들어, 좌표가 (12, 5)인 점 A는 x좌표와 y좌표가 모두 양수이므로 제1사분면에 속한다.점 B는 x좌표가 음수이고 y좌표가 양수이므로 제2사분면에 속한다.

            점의 좌표를 입력받아 그 점이 어느 사분면에 속하는지 알아내는 프로그램을 작성하시오.단, x좌표와 y좌표는 모두 양수나 음수라고 가정한다.

            입력
            첫 줄에는 정수 x가 주어진다. (−1000 ≤ x ≤ 1000; x ≠ 0) 다음 줄에는 정수 y가 주어진다. (−1000 ≤ y ≤ 1000; y ≠ 0)

            출력
            점(x, y)의 사분면 번호(1, 2, 3, 4 중 하나)를 출력한다.

            예제 입력 1
            12
            5
            예제 출력 1
            1
            예제 입력 2
            9
            - 13
            예제 출력 2
            4*/

            /* string str5 = Console.ReadLine();
             string str6 = Console.ReadLine();

             int x = int.Parse(str5);
             int y = int.Parse(str6);

             if (x > 0 && y > 0)
             {
                 Console.Write("1");
             }
             else if (x > 0 && y < 0)
             {
                 Console.Write("4");
             }
             else if (x < 0 && y > 0)
             {
                 Console.Write("2");
             }
             else if (y < 0 && x < 0)
             {
                 Console.Write("3");
             }*/

            #endregion

            #region 다섯번째 문제

            /* 문제
             상근이는 매일 아침 알람을 듣고 일어난다.알람을 듣고 바로 일어나면 다행이겠지만, 항상 조금만 더 자려는 마음 때문에 매일 학교를 지각하고 있다.

             상근이는 모든 방법을 동원해보았지만, 조금만 더 자려는 마음은 그 어떤 것도 없앨 수가 없었다.

             이런 상근이를 불쌍하게 보던 창영이는 자신이 사용하는 방법을 추천해 주었다.

             바로 "45분 일찍 알람 설정하기"이다.

             이 방법은 단순하다.원래 설정되어 있는 알람을 45분 앞서는 시간으로 바꾸는 것이다.어차피 알람 소리를 들으면, 알람을 끄고 조금 더 잘 것이기 때문이다. 이 방법을 사용하면, 매일 아침 더 잤다는 기분을 느낄 수 있고, 학교도 지각하지 않게 된다.

             현재 상근이가 설정한 알람 시각이 주어졌을 때, 창영이의 방법을 사용한다면, 이를 언제로 고쳐야 하는지 구하는 프로그램을 작성하시오.

             입력
             첫째 줄에 두 정수 H와 M이 주어진다. (0 ≤ H ≤ 23, 0 ≤ M ≤ 59) 그리고 이것은 현재 상근이가 설정한 알람 시간 H시 M분을 의미한다.

             입력 시간은 24시간 표현을 사용한다. 24시간 표현에서 하루의 시작은 0:0(자정)이고, 끝은 23:59(다음날 자정 1분 전)이다.시간을 나타낼 때, 불필요한 0은 사용하지 않는다.

             출력
             첫째 줄에 상근이가 창영이의 방법을 사용할 때, 설정해야 하는 알람 시간을 출력한다. (입력과 같은 형태로 출력하면 된다.)

             예제 입력 1
             10 10
             예제 출력 1
             9 25
             예제 입력 2
             0 30
             예제 출력 2
             23 45
             예제 입력 3
             23 40
             예제 출력 3
             22 55*/

            /*  String[] strs = Console.ReadLine().Split(new String[] {" "},StringSplitOptions.None);
                                                    //다중 공백 문자로 분리하기 (공백 문자열 배열 사용):
              int hour = int.Parse(strs[0]);
              int minute = int.Parse(strs[1]);

              if (minute >= 45)
              {
                  minute -= 45; // minute = minute - 45
                  Console.WriteLine(hour + " " + minute);
              }
              else
              {
                  hour--; // houl - 1;
                  minute += 60;// minute = minute + 60
                  minute -= 45; // minute = minute - 45

                  if (hour < 0)
                  {
                      hour += 24; // hour = hour + 24;
                  }
                  Console.WriteLine(hour + " " + minute);
              }*/

            #endregion

            #region 여섯번째 문제 어려워서 잘 이해안갔음

            /*   문제
               KOI 전자에서는 건강에 좋고 맛있는 훈제오리구이 요리를 간편하게 만드는 인공지능 오븐을 개발하려고 한다. 인공지능 오븐을 사용하는 방법은 적당한 양의 오리 훈제 재료를 인공지능 오븐에 넣으면 된다.그러면 인공지능 오븐은 오븐구이가 끝나는 시간을 분 단위로 자동적으로 계산한다.

               또한, KOI 전자의 인공지능 오븐 앞면에는 사용자에게 훈제오리구이 요리가 끝나는 시각을 알려 주는 디지털 시계가 있다.

               훈제오리구이를 시작하는 시각과 오븐구이를 하는 데 필요한 시간이 분단위로 주어졌을 때, 오븐구이가 끝나는 시각을 계산하는 프로그램을 작성하시오.

               입력
               첫째 줄에는 현재 시각이 나온다. 현재 시각은 시 A(0 ≤ A ≤ 23) 와 분 B(0 ≤ B ≤ 59)가 정수로 빈칸을 사이에 두고 순서대로 주어진다.두 번째 줄에는 요리하는 데 필요한 시간 C(0 ≤ C ≤ 1,000)가 분 단위로 주어진다.

               출력
               첫째 줄에 종료되는 시각의 시와 분을 공백을 사이에 두고 출력한다. (단, 시는 0부터 23까지의 정수, 분은 0부터 59까지의 정수이다.디지털 시계는 23시 59분에서 1분이 지나면 0시 0분이 된다.)

               예제 입력 1
               14 30
               20
               예제 출력 1
               14 50
               예제 입력 2
               17 40
               80
               예제 출력 2
               19 0
               예제 입력 3
               23 48
               25
               예제 출력 3
               0 13*/

          /*  string[] strs1 = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None);
            string strs2 = Console.ReadLine();

            int hour = int.Parse(strs1[0]);
            int minute = int.Parse(strs1[1]);
            int cooking = int.Parse(strs2);

            int sum = 0;

            sum = hour * 60 + minute + cooking;

            if (sum/60 >= 24)
            {
                sum -= 24 * 60;
            }

            Console.WriteLine(sum / 60 + " " + sum % 60);
*/

            #endregion

            #region 일곱번째 문제

            /* 문제
             1에서부터 6까지의 눈을 가진 3개의 주사위를 던져서 다음과 같은 규칙에 따라 상금을 받는 게임이 있다.

             같은 눈이 3개가 나오면 10,000원 + (같은 눈)×1,000원의 상금을 받게 된다.
             같은 눈이 2개만 나오는 경우에는 1,000원 + (같은 눈)×100원의 상금을 받게 된다.
             모두 다른 눈이 나오는 경우에는(그 중 가장 큰 눈)×100원의 상금을 받게 된다.
             예를 들어, 3개의 눈 3, 3, 6이 주어지면 상금은 1,000 + 3×100으로 계산되어 1,300원을 받게 된다.또 3개의 눈이 2, 2, 2로 주어지면 10,000 + 2×1,000 으로 계산되어 12,000원을 받게 된다. 3개의 눈이 6, 2, 5로 주어지면 그중 가장 큰 값이 6이므로 6×100으로 계산되어 600원을 상금으로 받게 된다.

             3개 주사위의 나온 눈이 주어질 때, 상금을 계산하는 프로그램을 작성 하시오.

             입력
             첫째 줄에 3개의 눈이 빈칸을 사이에 두고 각각 주어진다.

             출력
             첫째 줄에 게임의 상금을 출력 한다.

             예제 입력 1
             3 3 6
             예제 출력 1
             1300
             예제 입력 2
             2 2 2
             예제 출력 2
             12000
             예제 입력 3
             6 2 5
             예제 출력 3
             600*/

            string[] strs = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None);

            int dice1 = int.Parse(strs[0]);
            int dice2 = int.Parse(strs[1]);
            int dice3 = int.Parse(strs[2]);
            
            int price = 0;

            int max;

            if (dice1 == dice2 && dice2 == dice3)
            {
                price = 10000 + dice1 * 1000;
           
            }
            else if (dice1 == dice2)
            {
                price = 1000 + dice1 * 100;
            }
            else if (dice2 == dice3)
            {
                price = 1000 + dice2 * 100;
                Console.Write(dice2);
            }
            else
            {
                max = dice1;
               if( max < dice2)
                max = dice2;
               if(max < dice3)
                max = dice3;

                price = max * 100;

            }

            Console.Write(price);

            #endregion
        }
    }
}
