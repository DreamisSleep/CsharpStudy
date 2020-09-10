using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingApp
{
    class Even
    {
        int evenNumber; // 짝수
        public Even(int n) // 매개변수 1개짜리 생성자
        {
            evenNumber = (n % 2 == 0) ? n : n + 1;
        }
        // 연산자 중복

        public static Even operator ++(Even e)  {
            e.evenNumber += 2;  // e.evenNumber = e.evenNumber + 2;
            return e;
        }
        public static Even operator --(Even e)  {
            e.evenNumber -= 2;  // e.evenNumber = e.evenNumber - 2;
            return e;
        }
        public void PrintEven()  {
            Console.WriteLine("Even Number = " + evenNumber);
        }

    }   //Even 클래스의 끝


    class OperatorOverloadingAppTest
    {

        public static void Main(string[] args)
        {
            Even e = new Even(4); e.PrintEven(); // PrintEven() 메소드 호출
            ++e;     e.PrintEven(); // ++ 연산자 중복 호출
            --e;     e.PrintEven(); // -- 연산자 중복 호출
        }
    }
}
