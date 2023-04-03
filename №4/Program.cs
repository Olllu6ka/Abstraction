using System;

namespace _4
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте программу, в которой создайте класс AbstractHandler.В теле класса создать методы
    //void Open(), void Create(), void Chenge(), void Save(). Создать производные классы XMLHandler,
    //TXTHandler, DOCHandler от базового класса AbstractHandler.Написать логику, которая будет
    //выполнять определение документа и для каждого формата должны быть методы открытия,
    //создания, редактирования, сохранения определенного формата документа.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать в редактор документа");
            Console.Write("\nВведите какого формата вы хотите документ"+ "\nXML - (1)"+ "\tTXT - (2)" + "\tDOC - (3)"+"\nВведите число: ");
            int Function = int.Parse(Console.ReadLine());
            switch (Function)
            {
                case 1:
                    XMLHandler xMLHandler = new XMLHandler();
                    xMLHandler.Create();
                    xMLHandler.Open();
                    xMLHandler.Save();
                    Console.Write("Вы хотите изменить документ:" + "\nДа - (1)" + "\tНет - (2)"+ "\nВведите число: ");
                    int Function1 = int.Parse(Console.ReadLine());
                    if (Function1 == 1){
                        xMLHandler.Chenge();
                        xMLHandler.Print();
                    }
                    else if (Function1 == 2){
                        xMLHandler.Print();
                    }
                    break;
                case 2:
                    TXTHandler tXTHandler = new TXTHandler();
                    tXTHandler.Create();
                    tXTHandler.Open();
                    tXTHandler.Save();
                    Console.Write("Вы хотите изменить документ:" + "\nДа - (1)" + "\tНет - (2)" + "\nВведите число: ");
                    int Function2 = int.Parse(Console.ReadLine());
                    if (Function2 == 1)
                    {
                        tXTHandler.Chenge();
                        tXTHandler.Print();
                    }
                    else if (Function2 == 2)
                    {
                        tXTHandler.Print();
                    }
                    break;
                case 3:
                    DOCHandler dOCHandler = new DOCHandler();
                    dOCHandler.Create();
                    dOCHandler.Open();
                    dOCHandler.Save();
                    Console.Write("Вы хотите изменить документ:" + "\nДа - (1)" + "\tНет - (2)" + "\nВведите число: ");
                    int Function3 = int.Parse(Console.ReadLine());
                    if (Function3 == 1)
                    {
                        dOCHandler.Chenge();
                        dOCHandler.Print();
                    }
                    else if (Function3 == 2)
                    {
                        dOCHandler.Print();
                    }
                    break;
            }
        }
    }
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        private string Text;
        public override void Open()
        {
            Console.Write("Введите текст документа: ");
            Text = Console.ReadLine();
        }

        public override void Chenge()
        {
            Console.Write("Введите изменения в тексте: ");
            Text = Console.ReadLine();
        }

        public override void Create()
        {
            Console.WriteLine("Создаем документ нужного формата");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранили документ");
        }
        public void Print()
        {
            Console.WriteLine(Text + " - Ваш текст");
        }
    }
    class TXTHandler : AbstractHandler
    {
        private string Text;
        public override void Chenge()
        {
            Console.WriteLine("Введите изменения в тексте: ");
            Text = Console.ReadLine();
        }

        public override void Create()
        {
            Console.WriteLine("Создаем документ нужного формата");
        }

        public override void Open()
        {
            Console.WriteLine("Введите текст документа: ");
            Text = Console.ReadLine();
        }

        public override void Save()
        {
            Console.WriteLine("Сохранили документ");
        }
        public void Print()
        {
            Console.WriteLine(Text + " - Ваш текст");
        }
    }
    class DOCHandler : AbstractHandler
    {
        private string Text;
        public override void Chenge()
        {
            Console.Write("Введите изменения в тексте: ");
            Text = Console.ReadLine();
        }

        public override void Create()
        {
            Console.WriteLine("Создаем документ нужного формата");
        }

        public override void Open()
        {
            Console.Write("Введите текст документа: ");
            Text = Console.ReadLine();
        }

        public override void Save()
        {
            Console.WriteLine("Сохранили документ");
        }
        public void Print()
        {
            Console.WriteLine(Text + " - Ваш текст");
        }
    }
}
