using System;

namespace _2
{
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте программу, в которой создайте два интерфейса IPlayable и IRecodable.В каждом из
    //интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void
    //Pause() / void Stop() соответственно.Создайте производный класс Player от базовых интерфейсов
    //IPlayable и IRecodable.Написать программу, которая выполняет проигрывание и запись.
    class Program
    {
        interface IPlayable : IRecodable {
            void Play();
            void Pause();
            void Stop();
            
        }
        interface IRecodable {
            void Record();
            void Pause();
            void Stop();
        }
        class Player : IPlayable
        {
            public string Music { get; set; } 
            public void Pause()
            {
                Console.WriteLine($"Pause music {Music}");
            }

            public void Play()
            {
                Console.WriteLine($"Play music {Music}");
            }

            public void Record()
            {
                Console.WriteLine($"Record your voice {Music}");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"I record your voice through = {i}");
                }
                Console.WriteLine("I recorded your voice and I can say that you have a beautiful voice");
            }

            public void Stop()
            {
                Console.WriteLine($"Stop music {Music}");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите музыку которую вы хотите послушать: ");
            Player player = new Player();
            player.Music = Console.ReadLine();
            for (;;)
            {
                Console.Write(" Меню " + "\nСлушать музыку = (1)" + "\tОстановить прослушивание музыки = (2)" + "\tПауза = (3)" +
                    "\tПрослушивание вашего голоса = (4)" + "\nВведите свой выбор: ");
                int Function = int .Parse(Console.ReadLine());
                int Break1 = 1;
                switch (Function)
                {
                    case 1:
                        player.Play();
                        break;
                    case 2:
                        player.Stop();
                        Break1 = 0;
                        break;
                    case 3:
                        player.Pause();
                        break;
                    case 4:
                        player.Record();
                        break;
                }
                if (Break1 == 0)
                {
                    break;
                }
            }
        }
    }
}
