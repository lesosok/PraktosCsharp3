Console.WriteLine("Для переключения между октавами, используйте клавиши F1, F2, F3");
Console.WriteLine("Белые клавиши: Q, E, T, U, O, A");
Console.WriteLine("Чёрные клавиши: W, R, Y, I, P, S");

OctaveChoice();

static void OctaveChoice()
{
    int[] Octave1 = {440, 493, 523, 587, 659, 698, 783, 880, 987, 1046, 1174, 1318};
    int[] Octave2 = {880, 987, 1046, 1174, 1318, 1396, 1567, 1760, 1975, 2093, 2349, 2637};
    int[] Octave3 = {1760, 1975, 2093, 2349, 2637, 2793, 3135, 3520, 3951, 4186, 4699, 5274};
    int[] Choice = Octave1;

    ConsoleKeyInfo key;

    do
    {
        key = Console.ReadKey();

        if (key.Key == ConsoleKey.F1)
        {
            Console.Clear();
            Console.WriteLine("Первая октава");
            Choice = Octave1;
        }

        else if (key.Key == ConsoleKey.F2)
        {
            Console.Clear();
            Console.WriteLine("Вторая октава");
            Choice = Octave2;
        }

        else if (key.Key == ConsoleKey.F3)
        {
            Console.Clear();
            Console.WriteLine("Третья октава");
            Choice = Octave3;
        }

        else
        {
            BeepSound(key, Choice);
        }
    }
    while (key.Key != ConsoleKey.Escape);


}

static void BeepSound(ConsoleKeyInfo key, int[] Choice)
{
    switch (key.Key)
    {
        case ConsoleKey.Q:
            Console.Beep(Choice[0], 300);
            Console.Clear();
            break;

        case ConsoleKey.W:
            Console.Beep(Choice[1], 300);
            Console.Clear();
            break;

        case ConsoleKey.E:
            Console.Beep(Choice[2], 300);
            Console.Clear();
            break;

        case ConsoleKey.R:
            Console.Beep(Choice[3], 300);
            Console.Clear();
            break;

        case ConsoleKey.T:
            Console.Beep(Choice[4], 300);
            Console.Clear();
            break;

        case ConsoleKey.Y:
            Console.Beep(Choice[5], 300);
            Console.Clear();
            break;

        case ConsoleKey.U:
            Console.Beep(Choice[6], 300);
            Console.Clear();
            break;

        case ConsoleKey.I:
            Console.Beep(Choice[7], 300);
            Console.Clear();
            break;

        case ConsoleKey.O:
            Console.Beep(Choice[8], 300);
            Console.Clear();
            break;

        case ConsoleKey.P:
            Console.Beep(Choice[9], 300);
            Console.Clear();
            break;

        case ConsoleKey.A:
            Console.Beep(Choice[10], 300);
            Console.Clear();
            break;

        case ConsoleKey.S:
            Console.Beep(Choice[11], 300);
            Console.Clear();
            break;
    }
}