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
            Sample sample2 = new Sample();
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value); // Sample 객체 생성 전, 레퍼런스 변수 생성 전에 정적 생성자 호출
            Console.WriteLine("세번째 위치");

        }

        // 오버로딩
        //public static int TestOver(int input) { return 0; }
        public static bool TestOver(float input) { return true; }
    }
}
