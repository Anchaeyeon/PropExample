using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOver(3L);

            // 생성자
            //Product p = new Product(); // 기본 생성자 (기정 생성자)는 생성자가 없을 경우에만 자동으로 생성
            //Product p = new Product("김석진", 1500);
            
            // 팩토리 메서드 패턴 : private 생성자 사용
            Product p = Product.getInstance("전정국", 1000);

            // 정적 생성자 예제 1
            //Console.WriteLine("첫 번째 위치");
            //Console.WriteLine(Sample.value); // Sample.value 값 조회 전에 생성자 호출
            //Console.WriteLine("두 번째 위치");
            //Sample sample = new Sample();
            //Console.WriteLine("세 번째 위치");

            // 정적 생성자 패턴 2
            Console.WriteLine("첫 번째 위치");
            Sample sample2 = new Sample(); // Sample 객체 생성 전, 레퍼런스 변수 생성 전에 정적 생성자 호출
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세번째 위치");


            //const vs readonly
            Item item1 = new Item("고구마", 1500);
            Item item2 = new Item("감자", 1000);
            Item item3 = new Item("옥수수", 2000);
            Item item4 = new Item("토란", 2500);
            Console.WriteLine(item1.id);
            //item1.id = 11;
            Console.WriteLine(item2.id);
            Console.WriteLine(item3.id);
            Console.WriteLine(item4.id);

            Console.WriteLine(Item.ApplicationName);

            Box box = new Box(100, 100);
            //Console.WriteLine(box.getHeight());
            //box.setWidth(200);
            //Console.WriteLine(box.Area());

            Console.WriteLine(box.Height);
            box.Width = 200;
            Console.WriteLine(box.Area);

            // 값 복사 vs 참조 복사 비교
            // 값 복사 (value) - 값이 매개변수로 복사되어 넘어가서 원본에 영향 X
            int a = 10;
            Change(a);
            Console.WriteLine(a);

            // 참조 복사 (reference) - 객체의 레퍼런스(주소값)이 넘어가서 원본에 영향 O
            Test test = new Test();
            test.value = 10;
            Change(test);
            Console.WriteLine(test.value); // test를 바로 출력하면 ToString()이 호출됨

            Test testA = new Test();
            Test testB = testA;
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine(testA.value);
        }

        static void Change(int input)
        {
            input = 20;
        }

        static void Change(Test input )
        {
            input.value = 20;
        }

        class Test
        {
            public int value = 5;
            public override string ToString()
            {
                return value.ToString();
            }
        }

        // 오버로딩
        //public static int TestOver(int input) { return 0; }
        public static bool TestOver(float input) { return true; }
    }
}
