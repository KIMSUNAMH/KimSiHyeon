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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("2*" + i + "=" + i * 2);
            }
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




            #endregion

        }
    }
}
