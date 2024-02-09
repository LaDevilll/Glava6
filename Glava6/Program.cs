using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava6
{
    class MyClass
    {
        // Целочисленное поле: 
        public int number;
        // Символьное поле: 
        public char symbol;
        // Метод: 
        public void show()
        {
            // Отображение значений полей: 
            Console.WriteLine("Целое число: " + number);
            Console.WriteLine("Символ: " + symbol);
        }
    }



    class MyClass2
    {
        // Целочисленное поле: 
        public int number;
        // Символьное поле: 
        public char symbol;
        // Метод: 
        public void show()
        {
            // Отображение значения целочисленного поля: 
            Console.WriteLine("Целочисленное поле: " + number);
            // Отображение значения символьного поля: 
            Console.WriteLine("Символьное поле: " + symbol);
        }
    }




    // Класс с главным методом: 
    class UsingObjsDemo
    {
        // Главный метод: 
        static void Main()
        {
            // Первый объект: 
            MyClass A = new MyClass();
            // Объектная переменная: 
            MyClass B;
            // Второй объект: 
            B = new MyClass();
            // Присваивание значений полям первого объекта: 
            A.number = 123;
            A.symbol = 'A';
            // Присваивание значений полям второго объекта: 
            B.number = 321;
            B.symbol = 'B';
            // Вызов методов: 
            Console.WriteLine("Первый объект");
            A.show();
            Console.WriteLine("Второй объект");
            B.show();
        }
    }




    // Описание класса: 
    class MyClass3
    {
        // Целочисленное поле: 
        public int number;
        // Метод для отображения значения поля: 
        public void show()
        {
            Console.WriteLine("Значение поля: " + number);
        }
    }
    // Класс с главным методом: 
    class AnotherObjsDemo
    {
        // Главный метод: 
        static void Main()
        {
            // Объектные переменные: 
            MyClass A, B;
            // Создание объекта: 
            A = new MyClass();
            // Присваивание объектных переменных: 
            B = A;
            // Присваивание значения полю через первую объектную переменную: 
            A.number = 123;
            // Вызов метода через вторую объектную переменную: 
            B.show();
            // Присваивание значения полю через вторую объектную переменную: 
            B.number = 321;
            // Вызов метода через первую объектную переменную: 
            A.show();
        }
    }



    // Описание класса: 
    class MyClass4
    {
        // Закрытое целочисленное поле: 
        private int number;
        // Закрытое символьное поле: 
        private char symbol;
        // Открытый метод для отображения значения полей: 
        public void show()
        {
            Console.WriteLine("Поля объекта: " + number + " и " + symbol);
        }
        // Открытый метод для присваивания значений полям. Версия с двумя аргументами: 
        public void set(int n, char s)
        {
            number = n;   // Значение целочисленного поля 
            symbol = s;   // Значение символьного поля 
        }
        // Открытый метод для присваивания значений полям. Версия с одним целочисленным аргументом: 
        public void set(int n)
        {
            number = n;       // Значение целочисленного поля 
            symbol = 'B';     // Значение символьного поля 
        }
        // Открытый метод для присваивания значений полям. Версия без аргументов: 
        public void set()
        {
            // Вызов версии метода с двумя аргументами: 
            set(100, 'A');
        }
    }





    // Описание класса с конструктором: 
    class MyClass5
    {
        // Закрытые поля: 
        public int num;              // Целочисленное поле 
        public char symb;         // Символьное поле 
        public string txt;     // Текстовое поле 
                               // Открытый метод для отображения значений полей: 
        public void show()
        {
            Console.WriteLine("Поля: {0}, \'{1}\' и \"{2}\"", num, symb, txt);
        }
        // Конструктор без аргументов: 
        public MyClass()
        {
            // Значения полей: 
            num = 100;
            symb = 'A';
            txt = "Красный";
        }
        // Конструктор с одним целочисленным аргументом: 
        public MyClass(int n)
        {
            // Значения полей: 
            num = n;
            symb = 'B';
            txt = "Желтый";
        }
        // Конструктор с двумя аргументами: 
        public MyClass(int n, char s)
        {
            // Значения полей: 
            num = n;
            symb = s;
            txt = "Зеленый";
        }
        // Конструктор с тремя аргументами: 
        public MyClass(int n, char s, string t)
        {
            // Значения полей: 
            num = n;
            symb = s;
            txt = t;
        }
        // Конструктор с одним текстовым аргументом: 
        public MyClass(string t)
        {
            // Значения полей: 
            num = 0;
            symb = 'Z';
            txt = t;
        }
    }




    // Класс с главным методом: 
    class ConstructorsDemo
    {
        // Главный метод: 
        static void Main()
        {
            // Создание объектов. 
            // Вызывается конструктор без аргументов: 
            MyClass A = new MyClass();
            // Проверяются значения полей объекта: 
            A.show();
            // Вызывается конструктор с целочисленным аргументом: 
            MyClass B = new MyClass(200);
            // Проверяются значения полей объекта: 
            B.show();
            // Вызывается конструктор с двумя аргументами: 
            MyClass C = new MyClass(300, 'C');
            // Проверяются значения полей объекта: 
            C.show();
            // Вызывается конструктор с тремя аргументами: 
            MyClass D = new MyClass(400, 'D', "Синий");
            // Проверяются значения полей объекта: 
            D.show();
            // Вызывается конструктор с символьным аргументом: 
            MyClass F = new MyClass('A');
            // Проверяются значения полей объекта: 
            F.show();
            // Вызывается конструктор с текстовым аргументом: 
            MyClass G = new MyClass("Серый");
            // Проверяются значения полей объекта: 
            G.show();
        }
    }




    // Класс с конструктором и деструктором: 
    class MyClass6
    {
        // Закрытое текстовое поле: 
        private string name;
        // Конструктор: 
        public MyClass(string txt)
        {
            // Присваивание значения полю: 
            name = txt;
            // Отображение сообщения: 
            Console.WriteLine("Создан объект \"{0}\"", name);
        }
        // Деструктор: 
        ~MyClass()
        {
            // Отображение сообщения: 
            Console.WriteLine("Удален объект \"{0}\"", name);
        }
    }

    // Класс с главным методом: 
    class DestructorDemo
    {
        // Статический метод: 
        static void maker(string txt)
        {
            // Создание анонимного объекта: 
            new MyClass(txt);
        }
        // Главный метод: 
        static void Main()
        {
            // Создание объекта: 
            MyClass A = new MyClass("Первый");
            // Создание анонимного объекта: 
            new MyClass("Второй");
            // Новый объект: 
            A = new MyClass("Третий");
            // Вызов статического метода: 
            maker("Четвертый");
            // Новый объект: 
            A = new MyClass("Пятый");
        }
    }



    // Класс со статическим полем и методом: 
    class MyClass7
    {
        // Статическое поле: 
        public static int code = 100;
        // Статический метод: 
        public static void show()
        {
            Console.WriteLine("Статическое поле: " + code);
        }
    }
    // Класс с главным методом: 
    class StaticDemo
    {
        // Главный метод: 
        static void Main()
        {
            // Вызов статического метода: 
            MyClass.show();
            // Обращение к статическому полю: 
            MyClass.code = 200;
            // Вызов статического метода: 
            MyClass.show();
        }
    }



    // Класс со статическими методами и полями: 
    class MyMath
    {
        // Константное поле (число "пи"): 
        public const double Pi = 3.141592;
        // Закрытое статическое поле (граница суммы): 
        private static int N = 100;
        // Статический метод для вычисления экспоненты: 
        public static double exp(double x)
        {
            // Сумма и добавка к сумме: 
            double s = 0, q = 1;
            // Вычисление суммы: 
            for (int k = 0; k <= N; k++)
            {
                s += q;              // Прибавление добавки к сумме 
                q *= x / (k + 1);    // Добавка для следующей итерации 
            }
            // Результат: 
            return s;
        }
        // Статический метод для вычисления синуса: 
        public static double sin(double x)
        {
            // Сумма и добавка к сумме: 
            double s = 0, q = x;
            // Вычисление суммы: 
            for (int k = 0; k <= N; k++)
            {
                s += q;            // Прибавление добавки к сумме 
                                   // Добавка для следующей итерации: 
                q *= (-1) * x * x / (2 * k + 2) / (2 * k + 3);
            }
            // Результат: 
            return s;
        }
    }

    // Главный класс: 
    class StaticDemo
    {
        // Главный метод: 
        static void Main()
        {
            // Аргумент для статических методов: 
            double z = 1;
            // Вычисление экспоненты: 
            Console.WriteLine($"exp({z}) = {MyMath.exp(z)}");
            // Контрольное значение: 
            Console.WriteLine($"Контрольное значение: {Math.Exp(z)}");
            // Новое значение аргумента: 
            z = MyMath.Pi / 4;
            // Вычисление синуса: 
            Console.WriteLine($"sin({z}) = {MyMath.sin(z)}");
            // Контрольное значение: 
            Console.WriteLine($"Контрольное значение: {Math.Sin(z)}");
        }
    }




    // Класс: 
    class MyClass8
    {
        // Закрытое целочисленное поле: 
        private int code;
        // Открытый метод: 
        public int get()
        {
            // Использовано ключевое слово this: 
            return this.code;
        }
        // Открытый метод: 
        public void set(int code)
        {
            // Использовано ключевое слово this: 
            this.code = code;
        }
        // Конструктор: 
        public MyClass(int code)
        {
            // Использовано ключевое слово this: 
            this.code = code;
            // Использовано ключевое слово this: 
            Console.WriteLine("Создан объект: " + this.get());
        }
    }


    // Класс с главным методом: 
    class UsingThisDemo
    {
        // Главный метод: 
        static void Main()
        {
            // Создание объекта: 
            MyClass obj = new MyClass(100);
            // Присваивание значения полю: 
            obj.set(200);
            // Проверка значения поля: 
            Console.WriteLine("Новое значение: " + obj.get());
        }
    }



    // Класс с перегрузкой конструкторов: 
    class MyClass9
    {
        // Целочисленные поля: 
        public int alpha;
        public int bravo;

        // Конструктор с одним аргументом: 
        public MyClass(int a)
        {
            // Сообщение в консольном окне: 
            Console.WriteLine("Конструктор с одним аргументом");
            // Значения полей: 
            alpha = a;
            bravo = alpha;
            // Отображение значений полей: 
            Console.WriteLine("Оба поля равны " + alpha);
        }

        // Конструктор с двумя аргументами: 
        public MyClass(int a, int b) : this(a)
        {
            // Сообщение в консольном окне: 
            Console.WriteLine("Конструктор с двумя аргументами");
            // Значение второго поля: 
            bravo = b;
            // Отображение значений полей: 
            Console.WriteLine("Поля " + alpha + " и " + bravo);
        }

        // Конструктор без аргументов: 
        public MyClass() : this(400, 500)
        {
            // Сообщение в консольном окне: 
            Console.WriteLine("Конструктор без аргументов");
            // Отображение значений полей: 
            Console.WriteLine("Значения " + alpha + " и " + bravo);
        }
    }

    // Класс с главным методом: 
    class ConstrAndThisDemo
    {
        // Главный метод: 
        static void Main()
        {
            // Вызов конструктора с одним аргументом: 
            MyClass A = new MyClass(100);
            Console.WriteLine();
            // Вызов конструктора с двумя аргументами: 
            MyClass B = new MyClass(200, 300);
            Console.WriteLine();
            // Вызов конструктора без аргументов: 
            MyClass C = new MyClass();
        }
    }






}