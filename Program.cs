namespace Lesson2Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Цілі числа 1
            byte num1_1 = 255;//0 до 255;
            short num1_2_1 = 20354;//-32768 до 32767;
            ushort num1_2_2 = 65535;
            int number1_3_1 = 12;//-2147483648 до 2147483647;
            uint number1_3_2 = 123;
            long number1_4_1 = 55;//–9 223 372 036 854 775 808 до 9 223 372 036 854 775 807;
            ulong number1_4_2 = 60;

            //Числа з плаваючою комою2
            float num2_1 = 23.23f;//-3.4*1038 до 3.4*1038;
            double num2_2 = 23.005;//±4.9*10-324 до ±1.8*10308.
            decimal num2_3_3 = 23.07m;//1.0 x 10^-28 to approximately 7.9 x 10^28.

            //Інші типи даних
            bool flag = false;//true або false
            char symbol = 'a';//любий символ
            string newString = "Любий \nтекст";//рядок і рядок

            //Математичні дії
            int sum = 5;//додавання + 
            int subtraction = 5 - 7;//віднімання - 
            int multiply = 5 * 7;//множення * 
            int divide = 10 / 2;//ділення / 
            int residue = 18 % 4;//остача від діленя %

            sum++;//спочатку щось зробить, а потім збільшить на один
            ++sum;//спочатку збільшить на один, а потім щось зробить

            /*Оператори порівняння, умовні оператори та логічні оператори
             '>' - оператор більше
             '<' - оператор менше
             '==' - оператор дорівнює
             '!=' - оператор не дорівнює
             '>=' - оператор більше-дорівнює
             '<=' - оператор менше-дорівнює
             '&&' - оператор та (логічні оператори)
             '||' - оператор або (логічні оператори)
            'if' - якщо
            'else' - інакше
            '?:' - тринарний оператор
            */

            int test1 = 5;
            int test2 = 6;
            int test3 = 8;
            int test4 = 8;

            if (test1 != test2 || test3 == test4)
            {
                Console.WriteLine("Bebra");
            }
            else
            {
                Console.WriteLine("Not Bebra!");
            }
            int test5;

            test5 = (5 > 10) ? 5 : 10;

            Console.WriteLine(test5);

            Console.WriteLine("Введи перше число:");
            double inputNumber = double.Parse(Console.ReadLine());//Зчитуєм рядок з консолі

            Console.Write("Ти ввів - ");
            Console.Write(inputNumber);















        }
    }
}
