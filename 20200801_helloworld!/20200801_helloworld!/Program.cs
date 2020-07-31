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
        }
    }

    /* 기타 
    코드정렬 : ctrl + A  -> ctrl + K,F
    */
}
