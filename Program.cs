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
        }

        // 오버로딩
        //public static int TestOver(int input) { return 0; }
        public static bool TestOver(float input) { return true; }
    }
}
