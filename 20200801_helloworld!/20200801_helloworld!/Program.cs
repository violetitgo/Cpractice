﻿using System;
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
        }
    }

    /* 기타 
    코드정렬 : ctrl + A  -> ctrl + K,F
    */
}
