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

            string str5 = Console.ReadLine();
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
            }



            #endregion
        }
    }
}
