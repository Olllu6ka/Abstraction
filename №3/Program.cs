using System;

namespace _3
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте базовый абстрактный класс Document(документ), в котором создайте три метода void
    //Headline(Заголовок), DocumentСontent(Содержимое документ), Footer(подвал документа).
    //Реализуйте конкретный класс, который наследуется от производного класса Document, в теле
    //класса реализуйте все методы абстрактного класса. (Реализация может заключатся в простом
    //выводе информации о том какая это часть документа.)
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            document.Headline();
            document.DocumentСontent();
            document.Footer();
            document.PrintF();
        }
    }
    abstract class Base
    {
        public abstract void Headline();
        public abstract void DocumentСontent();
        public abstract void Footer();
    }
    class Document : Base
    {
        private string TextD;
        private string TextF;
        private string TextH;
        public override void DocumentСontent()
        {
            Console.Write("Введите основу вашего текста: ");
            TextD = Console.ReadLine();
        }

        public override void Footer()
        {
            Console.Write("Введите финал вашего текста: ");
            TextF = Console.ReadLine();
        }

        public override void Headline()
        {
            Console.Write("Введите заголовок вашего текста: ");
            TextH = Console.ReadLine();
        }
        public void PrintF()
        {
            Console.WriteLine(" Заголовок " + $"\n{TextH}");
            Console.WriteLine("  Основа " + $"\n{TextD}");
            Console.WriteLine(" Финал " + $"\n{TextF}");
        }
    }
}
