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

            string str3 = Console.ReadLine();

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
            }



            #endregion

        }
    }
}
