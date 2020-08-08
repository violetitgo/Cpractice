using System;
/* using : 네임스페이스 System을 사용하겠다. using을 사용하면 전체 이름을 참조하지 않고 선언된 네임스페이스 내부 개체들에 접근할 수 있어
 불필요한 타이핑을 막는다.*/

namespace _20200801_helloworld_
/* namespace : 네임스페이스는 관련된 구조체,클래스,델리게이트,인터페이스 등을 그룹화 한것. 예를들어 
System.Collections.Generic에는 제네릭 컬렉션을 정의하는 클래스와 인터페이스들이 들어가있다.
또 System.Linq에는, LINQ를 사용하는 쿼리를 지원하는 클래스와 인터페이스들이 들어가있다.
이처럼 네임스페이스는 사용하기 편리하게끔 성격이 비슷한 것들을 묶어놓는 것과 같다.*/
{
    class Program
    /* class : 필드와 메소드로 나누어짐. 필드는 정적인 상태를, 메소드는 동적인 상태를 표현함.
독립적으로 존재할 수 있는 최소단. C#프로그램을 구성하는 기본단위이며, 이 하나의 클래스를 가지고도 여러가지 객체를 만들어낼 수 있다.*/
    {
        static void Main(string[] args)
        /* 이 main메소드는 프로그램 최초의 진입점. */
        {
            Console.Write("C# 정말 자바랑 비슷한걸~");
            /* Console.WriteLine -> 출력 후 줄바꿈 */

            byte a = 200;
            sbyte b = -125;
            short c = 30000;
            ushort d = 65000;
            int e = 100000000;
            uint f = 1000000000;
            long g = 1000000000000000000;
            ulong h = 10000000000000000000;

            Console.WriteLine("a={0}, b={1}, c={2}, d={3}, e={4}, f={5}, g={6}, h={7}", a, b, c, d, e, f, g, h);
            /* 0번째 자리에 있는 변수를, 1번째 있는 변수를 ....... */
            Console.WriteLine("a=", a, " b=", b);
            /* 이런식으로 출력하면 내가 원하던 a=200 이런식으로 안나오네,,*/

            float i = 123.567891011f;
            double j = 1234.567878910111213;
            decimal k = 1234.56789101112131415161718m;
            /* float이랑 decimal 은 맨뒤에 f,m 접미사 붙음!*/

            Console.WriteLine("i={0}, j={1}, k={2}", i, j, k);

            char l = '안';
            string m = "녕하세용";

            Console.WriteLine("{0}{1}", l, m);

            bool n = true;
            bool o = false;

            Console.WriteLine("a={0}, b={1}", n, o);


            object p = 12345678910;
            object q = 12345.67891011;
            object r = true;
            object s = "안녕하세요";
            Console.WriteLine("p={0}, q={1}, r={2}, s={3}", p, q, r, s);

            /* Object는 모든 자료형의 최상의 부모클래스니까 모든 자료형을 다룰 수 있어!*/

            int t = 100, u = 200;

            Console.WriteLine("{0}+{1} = {2}", t, u, t + u);
            Console.WriteLine("{0}-{1} = {2}", t, u, t - u);

            int v = 12345678;
            double w = 12.345678;


/*-------------------수치 서식 문자열-----------------*/
            Console.WriteLine("통화 (C) -> {0:C}", v);
            Console.WriteLine("10진법 (D) -> {0:D}", v);
            Console.WriteLine("지수 표기법 (E) -> {0:E}", w);
            Console.WriteLine("고정 소수점 (F) -> {0:F}", w);
            Console.WriteLine("일반 (G) -> {0:G}", v);
            Console.WriteLine("숫자 (N) -> {0:N}", v);
            Console.WriteLine("16진법 (X) -> {0:X}", v);
            Console.WriteLine("백분율 (P) -> {0:P}", w);
            /*
            통화 (C) -> \12,345,678
            10진법 (D) -> 12345678
            지수 표기법 (E) -> 1.234568E+001
            고정 소수점 (F) -> 12.35
            일반 (G) -> 12345678
            숫자 (N) -> 12,345,678.00
            16진법 (X) -> BC614E
            백분율 (P) -> 1,234.57%
            */


            /*-------------------사용자 지정 수치 서식 문자열-----------------*/
            int x = 1234;
            double y = 12.345678;
            Console.WriteLine("0 자리 표시 (0) . . . .: {0:00000}", x);
            Console.WriteLine("10진수 자리 표시 (#) . : {0:#####}", x);
            Console.WriteLine("소수점 (.) . . . . . . : {0:0.00000}", y);
            Console.WriteLine("천 단위 자릿수 표시 (,): {0:0,0}", x);
            Console.WriteLine("백분율 자리 표시 (%) . : {0:0%}", y);
            Console.WriteLine("지수 표기법 (e) . . . .: {0:0.000e+0}", y);

            int z = 12345;


            Console.WriteLine("|{0,15}|", z);
            Console.WriteLine("|{0,-15}|", z);
            /* 15앞에 -를 붙이니 왼쪽부터 출력되게 나옴. 아무것도 붙이지 않으면 오른쪽부터 출력됨 ㄴ*/
            Console.WriteLine("|{0,15:N0}|", z);
            Console.WriteLine("|{0,-15:N0}|", z);
            /* 숫자를 알아서 , 찍어주던 N과 너비지정을 같이 설정한 것. 0번째 위치한 z변수를 15의 크기만큼 N의 수치서식문자열을
               사용하여오른쪽/왼쪽 부터 정렬하여라. */



            /*-------------------형식 변환-----------------*/

            int aa = 500;
            float bb = aa; // 정수 -> 실수는 데이터의 손실이 없으므로 암시적 변환이 이루어지기때문에 별도 구문 필요 X

            Console.WriteLine("aa={0}, bb={1}", aa, bb);

            double cc = 123.45;
            int dd = (int)cc; // 실수 -> 정수는 변환과정에서 소수점 이하가 모두 버려지는 데이터 손실이 일어나기 때문에 손실여부와 관계없이
                              // 형식변환을 하고 싶은 경우에는 명시적 변환을 사욯아여 바꿔줘야함. (int)cc 같이. 그러나 이렇게 하면 데이터 손실 일어남

            Console.WriteLine("cc={0}, dd={1}", cc, dd);


            int ee = 500;
            float ff = 60.44f;
            string gg = a.ToString();
            string hh = b.ToString();

            Console.WriteLine("ee={0}, ff={1}, gg={2}, hh={3}", ee, ff, gg, hh);

            /*-------------------상수-----------------*/

            const double wow = 3.24;
            const int age = 29;
            /* 상수값을 변경하려고 하면 오류가뜸 */


            /*-------------------조건문-----------------*/
            int su1 = 123;
            int su2 = 100;
            if(su1 < su2)
            {
                Console.WriteLine("안녕하시요");
            } else
            {
                Console.WriteLine("안녕히가시요");
            }

            switch(su2)
            {
                case 100: Console.WriteLine("100이요");
                    break;
                case 101: Console.WriteLine("하아암");
                    break;
            }

            /* 결론 : 자바와 조건문, 반복문이 똑같다! 다만 반복문에서 출력만 좀 신경쓰기!*/


            for (int iii = 1; iii < 10; iii++)
            {
                Console.WriteLine("구구단 {0}단", iii);
                for (int jjj = 1; jjj < 10; jjj++)
                {
                    Console.WriteLine("{0} X {1} = {2}", iii, jjj, iii * jjj);
                }
            }

        }
    }

    /* 기타 
    코드정렬 : ctrl + A  -> ctrl + K,F
    */
}
