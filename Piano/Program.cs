using System;
namespace Пианинка
{
    class Pianinka
    {
        static int[] tonalnost = new int[12];
        static ConsoleKey izmena = ConsoleKey.F2;
        static void Main(string[] args) 
        {
            Console.WriteLine("F1 - Переключиться на первую октаву");
            Console.WriteLine("F2 - Переключиться на вторую октаву");
            Console.WriteLine("F3 - Переключиться на третью октаву");
            Console.WriteLine("F4 - Выйти из пианино");
            Console.WriteLine("Кнопки управления: Z, X, C, S, D, V, B, N, G, H, J, M");
            do
            {
                tonalnost = Octave_izmena(izmena);
                Piano(tonalnost);
            }
            while (izmena != ConsoleKey.F4);
            Console.WriteLine("Вы вышли из пианино");
        }
        static ConsoleKey Piano(int[] tonalnost)
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.F1:
                        izmena = key.Key;
                        tonalnost = Octave_izmena(izmena);
                        break;
                    case ConsoleKey.F2:
                        izmena = key.Key;
                        tonalnost = Octave_izmena(izmena);
                        break;
                    case ConsoleKey.F3:
                       izmena = key.Key;
                        tonalnost = Octave_izmena(izmena);
                        break;
                    case ConsoleKey.F4:
                        izmena = key.Key;
                        return izmena;
                }
                switch (key.Key)
                {
                    case ConsoleKey.Z:
                        Console.Beep(tonalnost[0], 500);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(tonalnost[1], 500);
                        break;
                    case ConsoleKey.X:
                        Console.Beep(tonalnost[2], 500);
                        break;
                    case ConsoleKey.D:
                        Console.Beep(tonalnost[3], 500);
                        break;
                    case ConsoleKey.C:
                        Console.Beep(tonalnost[4], 500);
                        break;
                    case ConsoleKey.V:
                        Console.Beep(tonalnost[5], 500);
                        break;
                    case ConsoleKey.G:
                        Console.Beep(tonalnost[6], 500);
                        break;
                    case ConsoleKey.B:
                        Console.Beep(tonalnost[7], 500);
                        break;
                    case ConsoleKey.H:
                        Console.Beep(tonalnost[8], 500);
                        break;
                    case ConsoleKey.N:
                        Console.Beep(tonalnost[9], 500);
                        break;
                    case ConsoleKey.J:
                        Console.Beep(tonalnost[10], 500);
                        break;
                    case ConsoleKey.M:
                        Console.Beep(tonalnost[11], 500);
                        break;
                }
            }
        }
        static int[] Octave_izmena(ConsoleKey izmena)
        {
            int[] pervonach = new int[12];
            switch (izmena)
            {
                case ConsoleKey.F1:
                    pervonach = Octave_1();
                    break;
                case ConsoleKey.F2:
                    pervonach = Octave_2();
                    break;
                case ConsoleKey.F3:
                    pervonach = Octave_3();
                    break;        
            }
            return pervonach;
        }
        static int[] Octave_1()
        {
            Console.WriteLine("Включена первая октава");
            int[] firstOctave = new int[] { 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
            return firstOctave;
        }
        static int[] Octave_2()
        {
            Console.WriteLine("Включена вторая октава");
            int[] secondOctave = new int[] { 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987 };
            return secondOctave;
        }
        static int[] Octave_3()
        {
            Console.WriteLine("Включена третья октава");
            int[] thirdtOctave = new int[] { 1046, 1108, 1174, 1244, 1318, 1396, 1480, 1568, 1661, 1720, 1864, 1975 };
            return thirdtOctave;
        }
    }
}
