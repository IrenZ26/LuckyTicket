using System;
using System.Collections.Generic;

namespace LuckyTicket
{
    class Program
    {
    /*    public int[] toIntegerArray(int number)
        {
            int a = number;
            List<int> l = new List<int>();
            while (a > 0)
            {
                l.Add(a % 10);
                a = a / 10;
            }
            return l.ToArray();
        }
    */
        static void Main(string[] args)
        {
            
            Console.WriteLine(Welcome());
            string ans = "Y";
            while ((ans == "Y")||(ans=="y"))
            {
                Console.WriteLine("If you want to continue enter Y/y");//если пользователь хочет продолжить работу
                ans = Console.ReadLine();
                if (ans == "Y") { Console.WriteLine(Welcome()); }
                else if (ans == "y") { Console.WriteLine(Welcome()); }
            }

        }
        public static string Welcome()
        {
            Console.WriteLine("Enter the ticket`s number:");
            string number = Console.ReadLine();
            bool f = false;
            string result="";
            //Проверяем длину номера
            if ((number.Length < 4) || (number.Length > 8)) { result = "Input Error, ticket must be 4 to 8 digits long"; } 
            //Добавляем 0 если нечетная
            if ((number.Length % 2) != 0) { number = "0" + number; f = true; }
            int k = 0;
            //Строку в число
            try
            {
                k = int.Parse(number);
            }
            catch (FormatException)
            {

                result = "Input Error, ticket number must contain only digits";
            }
            if (result == "")
            {
                int[] num = new int[number.Length];

                //Записываем числа в массив
                List<int> l = new List<int>();
                while (k > 0)
                {
                    l.Add(k % 10);
                    k = k / 10;
                }
                if (f) { l.Add(0); }
                num = l.ToArray();
                int n = num.Length / 2;
                int m = 0;
                int p = 0;
                //Cравниваем половины
                for (int i = 0; i < n; i++)
                {
                    m += num[i];
                    p += num[n + i];

                }
                //Выводим результат
                if (m == p) { result = "Your ticket is lucky!"; }
                else { result = "Your tichket isn`t lucky, try again"; }
            }
            return result;
        }   
    }
}
