using System;

namespace Abstraction
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте программу, в которой создайте интерфейс Printable, содержащий метод void print().
    //Далее создайте класс Book, класс Journal(журнал) реализующий интерфейс Printable.создайте
    //класс Magazine, реализующий интерфейс Printable.После создайте массив типа Printable,
    //который будет содержать книги и журналы и в цикле пройти по массиву и вызвать
    //метод print() для каждого объекта.Создать метод printMagazines(Printable[] printable) в
    //классе Magazine, кото.рый выводит на консоль названия только журналовСоздать
    //метод printBooks(Printable[] printable) в классе Book, который выводит на консоль названия
    //только книг.

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Magazine magazine = new Magazine();
            for (int h = 0; h < 5; h++)
            {
                Console.Write($"Введите название книги {h}: ");
                string BookM = Console.ReadLine();
                Console.Write($"Введите название журнала {h}: ");
                string JournalM = Console.ReadLine();
                book.PrintablesArray(BookM, JournalM, h);
                magazine.PrintablesArray(BookM, JournalM, h);
                Console.Clear();
            }
            Console.Write("Введи что вы хотите вывести: " + "\n1)Книги" + "\t2)Журнали" + "\nВведите: ");
            int Function = int.Parse(Console.ReadLine());
            switch (Function)
            {
                case 1:
                    book.printPrintable();
                    break;
                case 2:
                    magazine.printPrintable();
                    break;
            }
        }
    }
    interface IPrintable
    {
        void printPrintable();
    }
    class Book: IPrintable
    {
        string[,] printables = new string[5, 2];
        public void PrintablesArray(string BookArray, string JournalArray, int Inter)
        {
            for (int i = -1; i < Inter; i++)
            {
                printables[Inter, 0] = BookArray;
                for (int g = 1; g < 2; g++)
                {
                    printables[Inter, g] = JournalArray;
                }
            }
        }
        public void printPrintable()
        {
            for (int g = 0; g < printables.GetLength(0); g++)
            {
                Console.WriteLine(printables[g, 0]);
            }
        }
    }
    class Journal
    {
        //Я не понял для чего этот класс.
        //public void printPrintable()
        //{
        //    for (int g = 0; g < printables.GetLength(1); g++)
        //    {
        //        Console.WriteLine(printables[g, 1]);
        //    }
        //}
    }
    class Magazine : IPrintable
    {
        string[,] printables = new string[5, 2];
        public void PrintablesArray(string BookArray, string JournalArray, int Inter)
        {
            for (int i = -1; i < Inter; i++)
            {
                printables[Inter, 0] = BookArray;
                for (int g = 1; g < 2; g++)
                {
                    printables[Inter, g] = JournalArray;
                }
            }
        }
        public void printPrintable()
        {
            for (int g = 0; g < printables.GetLength(1); g++)
            {
                Console.WriteLine(printables[g, 1]);
            }
        }
    }
}
