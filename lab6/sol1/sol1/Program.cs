using System;

namespace sol1
{
    class Program
    {
        class String
        {
            private int length; // Длина строки
            public string[] data;

            public int Length //свойства
            {
                get => length;
                set => length = value;
            }
            public string[] Data
            {
                get => data;
                set => data = value;
            }

            public double ToDouble()
            {
                double outDouble;
                string dcopy = "";

                for (int i = 0; i < length; i++)
                {
                    dcopy += data[i];
                }
                double.TryParse(dcopy, out outDouble);
                return outDouble;
            }

            public String ToString()
            {
                String outString;
                string dcopy = "";

                for (int i = 0; i < length; i++)
                {
                    dcopy += data[i];
                }
                outString = Num.ToString();
                return outString;
            }

            public String(bool rand = false, int length = 10)
            {
                this.length = length;

                bool flag = false;
                data = new string[length];

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
                                data[i] = Convert.ToString(Console.ReadLine());
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
                    Random rnd = new Random();
                    for (int i = 0; i < length; i++)
                    {
                        data[i] = Convert.ToString(rnd.Next('a', 'a' + 26)); //рандомный символ от 'a' до 'z'
                    }
                }

            }

            public String(String exData, int n = 5) //конструктор копирования. n - сколько прибавить к симыолу
            {
                length = exData.length;

                data = new string[length];

                for (int i = 0; i < n; i++)
                {
                    data[i] = Convert.ToString(exData.data[i]);
                }
            }

            ~String() => Console.WriteLine("Сработал деструктор");
            //сборщик мусора сделает всю работу и нет необходимости явно освобождать память

            public void output() //вывод матрицы
            {
                Console.Write("String: ");
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine();
                    Console.Write("{0}", data[i]);

                }

            }

            static void Main()
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
