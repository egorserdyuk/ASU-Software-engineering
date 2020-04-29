using System;

namespace sol1
{
    class Program
    {
        class MyString
        {
            private int length; // Длина строки
            public char[] data;

            public int Length //свойства
            {
                get => length;
                set => length = value;
            }
            public char[] Data
            {
                get => data;
                set => data = value;
            }

            

            public MyString(bool rand = false, int length = 10)
            {
                this.length = length;

                bool flag = false;
                data = new char[length];

                if (rand == false) //ввод с клавиатуры
                {
                    do //если введена некорректная переменная, то начинается ввод заного
                    {
                        try //ловим исключение
                        {
                            Console.Write("Input the string: ");
                            for (int i = 0; i < length; i++)
                            {
                                Console.Write("String: [{0}] : ", i);
                                //data[i] = Convert.ToString(Console.ReadLine());
                            }
                        }
                        catch
                        {
                            Console.Write("Введена переменная не того типа\n");
                            continue; //все плохо - начинаем новую итерацию
                        }

                        flag = true; //если все ок, то выходим из цикла
                    } while (flag != true);
                }
                else //рандомный ввод
                {
                    Random rand = new Random();
                    for (int i = 0; i < length; i++)
                    {
                        data[i] = Convert.ToString(rand.Next('a', 'a' + 26)); //рандомный символ от 'a' до 'z'
                    }
                }

            }

            public MyString(MyString exData, int n = 5) //конструктор копирования. n - сколько прибавить к симыолу
            {
                length = exData.length;

                data = new char[length];

                for (int i = 0; i < n; i++)
                {
                    data[i] = Convert.ToString(exData.data[i]);
                }
            }

            ~MyString() => Console.WriteLine("Сработал деструктор");
            //сборщик мусора сделает всю работу и нет необходимости явно освобождать память

            public void output() //вывод матрицы
            {
                Console.Write("String: ");
                for (int i = 0; i < length; i++)
                {
                    Console.Write("{0}", data[i]);

                }

            }

            static void Main()
            {
                MyString str1 = new MyString(true, 10); //создаем объект класса
                MyString str2 = new MyString(str1, 5); //создаем копию объекта класса, все элементы больше на 2
                str1.output();
                Console.WriteLine();
                str2.output(); //выводим объект и его копию
                Console.ReadKey();

            }
        }
    }
}
