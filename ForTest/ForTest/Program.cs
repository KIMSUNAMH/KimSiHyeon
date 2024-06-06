using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 첫번째 문제

            /* 구구단
            시간 제한 메모리 제한 제출  정답 맞힌 사람 정답 비율
            1 초 128 MB  436292  218722  182156  50.659 %
            문제
            N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오.출력 형식에 맞춰서 출력하면 된다.

            입력
            첫째 줄에 N이 주어진다.N은 1보다 크거나 같고, 9보다 작거나 같다.

            출력
            출력형식과 같게 N*1부터 N*9까지 출력한다.

            예제 입력 1
            2
            예제 출력 1
            2 * 1 = 2
            2 * 2 = 4
            2 * 3 = 6
            2 * 4 = 8
            2 * 5 = 10
            2 * 6 = 12
            2 * 7 = 14
            2 * 8 = 16
            2 * 9 = 18
*/

            /*    for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("2*" + i + "=" + i * 2);
                }*/
            #endregion



            #region 두번째 문제

            /* A + B - 3
             시간 제한   메모리 제한  제출 정답  맞힌 사람   정답 비율
             1 초 256 MB  314766  183411  153227  58.383 %
             문제
             두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

             입력
             첫째 줄에 테스트 케이스의 개수 T가 주어진다.

             각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)

             출력
             각 테스트 케이스마다 A + B를 출력한다.

             예제 입력 1
             5
             1 1
             2 3
             3 4
             9 8
             5 2
             예제 출력 1
             2
             5
             7
             17
             7*/

            /* string str = Console.ReadLine();

             int T = int.Parse(str);

             int num1;

             int num2;


             for (int i = 0; i < T; i++)
             {
                 string[] strs = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None);

                 num1 = int.Parse(strs[0]);
                 num2 = int.Parse(strs[1]);

                 Console.WriteLine(num1 + num2);

             }
 */
            #endregion

            #region 세번째 문제

            /* 합 다국어
             시간 제한   메모리 제한  제출 정답  맞힌 사람   정답 비율
             1 초 128 MB  288875  184347  155830  64.045 %
             문제
             n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.

             입력
             첫째 줄에 n(1 ≤ n ≤ 10,000)이 주어진다.

             출력
             1부터 n까지 합을 출력한다.

             예제 입력 1
             3
             예제 출력 1
             6*/

            /* int n = int.Parse(Console.ReadLine());

             int sum = 0;

             for (int i = 1; i <= n; i++)
             {
                 sum += i;

             }*/
            /*Console.WriteLine(sum);*/

            #endregion

            #region 네번째 문제

            /* 문제
             준원이는 저번 주에 살면서 처음으로 코스트코를 가 봤다.정말 멋졌다. 그런데, 몇 개 담지도 않았는데 수상하게 높은 금액이 나오는 것이다! 준원이는 영수증을 보면서 정확하게 계산된 것이 맞는지 확인해보려 한다.

             영수증에 적힌,

             구매한 각 물건의 가격과 개수
             구매한 물건들의 총 금액
             을 보고, 구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하는지 검사해보자.

             입력
             첫째 줄에는 영수증에 적힌 총 금액
             $X$가 주어진다.

             둘째 줄에는 영수증에 적힌 구매한 물건의 종류의 수 
             $N$이 주어진다.

             이후
             $N$개의 줄에는 각 물건의 가격
             $a$와 개수 
             $b$가 공백을 사이에 두고 주어진다.

             출력
             구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하면 Yes를 출력한다.일치하지 않는다면 No를 출력한다.

             제한
  
             $1 ≤ X ≤ 1\,000\,000\,000$ 
  
             $1 ≤ N ≤ 100$ 
  
             $1 ≤ a ≤ 1\,000\,000$ 
  
             $1 ≤ b ≤ 10$ 
             예제 입력 1
             260000
             4
             20000 5
             30000 2
             10000 6
             5000 8
             예제 출력 1
             Yes
             영수증에 적힌 구매할 물건들의 목록으로 계산한 총 금액은 20000 × 5 + 30000 × 2 + 10000 × 6 + 5000 × 8 = 260000원이다.이는 영수증에 적힌 총 금액인 260000원과 일치한다. 

             예제 입력 2
             250000
             4
             20000 5
             30000 2
             10000 6
             5000 8
             예제 출력 2
             No*/
            /*
                        int X = int.Parse(Console.ReadLine());

                        int N = int.Parse(Console.ReadLine());

                        int a;

                        int b;

                        int sum = 0;

                        for (int i = 0; i < N; i++)
                        {
                            string[] strs = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None);

                            a = int.Parse(strs[0]);
                            b = int.Parse(strs[1]);

                            sum += a * b;

                        }

                        if (sum == X)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
            */
            #endregion

            #region 다섯번째 문제
            /*
                        코딩은 체육과목 입니다
                        시간 제한 메모리 제한 제출  정답 맞힌 사람 정답 비율
                        0.5 초(추가 시간 없음)    1024 MB(추가 메모리 없음) 84646   53751   48690   64.245 %
                        문제


                        오늘은 혜아의 면접 날이다. 면접 준비를 열심히 해서 앞선 질문들을 잘 대답한 혜아는 이제 마지막으로 칠판에 직접 코딩하는 문제를 받았다. 혜아가 받은 문제는 두 수를 더하는 문제였다.C++ 책을 열심히 읽었던 혜아는 간단히 두 수를 더하는 코드를 칠판에 적었다.코드를 본 면접관은 다음 질문을 했다. “만약, 입출력이
                        $N$바이트 크기의 정수라면 프로그램을 어떻게 구현해야 할까요 ?”

                        혜아는 책에 있는 정수 자료형과 관련된 내용을 기억해 냈다.책에는 long int는 
                        $4$바이트 정수까지 저장할 수 있는 정수 자료형이고 long long int는 
                        $8$바이트 정수까지 저장할 수 있는 정수 자료형이라고 적혀 있었다.혜아는 이런 생각이 들었다. “int 앞에 long을 하나씩 더 붙일 때마다
                        $4$바이트씩 저장할 수 있는 공간이 늘어나는 걸까? 분명 long long long int는 
                        $12$바이트, long long long long int는 
                        $16$바이트까지 저장할 수 있는 정수 자료형일 거야!” 그렇게 혜아는 당황하는 면접관의 얼굴을 뒤로한 채 칠판에 정수 자료형을 써 내려가기 시작했다.

                        혜아가
                        $N$바이트 정수까지 저장할 수 있다고 생각해서 칠판에 쓴 정수 자료형의 이름은 무엇일까?

                        입력
                        첫 번째 줄에는 문제의 정수 
                        $N$이 주어진다. 
                        $(4\le N\le 1\, 000$; 
                        $N$은
                        $4$의 배수
                        $)$ 

                        출력
                        혜아가 
                        $N$바이트 정수까지 저장할 수 있다고 생각하는 정수 자료형의 이름을 출력하여라.

                        예제 입력 1
                        4
                        예제 출력 1
                        long int
                        예제 입력 2
                        20
                        예제 출력 2
                        long long long long long int
            */

             int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N / 4;  i++)
            {
                Console.Write(" long");
            }
            Console.WriteLine(" int");

            #endregion



            #region 여섯번째 문제

            /*별 찍기 -1
            시간 제한   메모리 제한  제출 정답  맞힌 사람   정답 비율
            1 초 128 MB  336374  207259  171525  62.222 %
            문제
            첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

            입력
            첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.

            출력
            첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.

            예제 입력 1
            5
            예제 출력 1
            *
            **
            ***
            ****
            *****
*/

            /*    int N = int.Parse(Console.ReadLine());

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }*/

            #endregion


            #region 일곱번째 문제
            /*
                        별 찍기 -2
                        시간 제한   메모리 제한  제출 정답  맞힌 사람   정답 비율
                        1 초 128 MB  333282  185899  156734  55.995 %
                        문제
                        첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

                        하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.

                        입력
                        첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.

                        출력
                        첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다.

                        예제 입력 1
                        5
                        예제 출력 1
                            *
                           **
                          ***
                         ****
                        ******/


/*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j >= 0; j--)
                {
                    if (i<j)
                    {
                        Console.Write(" "); // 0<4 , 0<3 , 0<2 , 0<1 , (0<0)
                                             //1<4 , 1<3 , 1<2 ,(1<1),(0<0)                                             
                                             // 2<5 , 2<4 , 2<3 , (2<2), (2<1) , (2<0)
                    }
                    else
                    {
                        Console.WriteLine("*");
                    }
                }
               
            }*/


            #endregion

        }
    }
}
