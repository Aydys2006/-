using notebook;
dni den1 = new dni();
den1.data = new DateTime(2022, 10, 15);
den1.data1 = new DateTime(2022, 10, 17);
den1.data2 = new DateTime(2022, 10, 10);
den1.data3 = new DateTime(2022, 10, 20);
den1.data4 = new DateTime(2022, 10, 26);
den1.naz = "Сдать практическую";
den1.naz1 = "Сделать новую практическую";
den1.naz2 = "Поспать";
den1.naz3 = "Поесть";
den1.naz4 = "Отметить праздник";
den1.naz5 = "Написать о поздравлении праздника всем";
den1.naz6 = "Купить подарок на ДР мамы";
den1.naz7 = "Поздравить маму с ДР";
den1.naz8 = "Купить подарок на ДР сестры";
den1.naz9 = "Поздравить сестру с ДР";
DateTime date = new DateTime(2022, 10, 15);
Console.Clear();
Console.WriteLine("Выбранная дата: " + date);
Console.WriteLine("  1.Сдать практическую");
Console.WriteLine("  2.Сделать новую практическую");
ConsoleKeyInfo s;
while (true)
{
    if ((date.Day == 08) && (date.Month == 02) && (date.Year == 2023))
    {
        Console.Clear();
        Console.WriteLine("Выбранная дата: " + den1.data.ToShortDateString());
        Console.WriteLine("  1.Сдать практическую");
        Console.WriteLine("  2.Сделать новую практическую");
        s = Console.ReadKey();
        if ((s.Key == ConsoleKey.DownArrow) || (s.Key == ConsoleKey.UpArrow))
        {
            deny1();
        }
        if (s.Key == ConsoleKey.RightArrow)
        {
            date = date.AddDays(1);
            Console.Clear();
        }
        if (s.Key == ConsoleKey.LeftArrow)
        {
            date = date.AddDays(-1);
            Console.Clear();
        }
    }
    if ((date.Day == 14) && (date.Month == 02) && (date.Year == 2023))
    {
        Console.Clear();
        Console.WriteLine("Выбранная дата: " + den1.data2.ToShortDateString());
        Console.WriteLine("  1.Отметить праздник");
        Console.WriteLine("  2.Написать о поздравлении праздника всем");
        s = Console.ReadKey();
        if ((s.Key == ConsoleKey.DownArrow) || (s.Key == ConsoleKey.UpArrow))
        {
            deny3();
        }
        if (s.Key == ConsoleKey.RightArrow)
        {
            date = date.AddDays(1);
            Console.Clear();
        }
        if (s.Key == ConsoleKey.LeftArrow)
        {
            date = date.AddDays(-1);
            Console.Clear();
        }
    }
    if ((date.Day == 17) && (date.Month == 02) && (date.Year == 2023))
    {
        Console.Clear();
        Console.WriteLine("Выбранная дата: " + den1.data1.ToShortDateString());
        Console.WriteLine("  1.Поспать");
        Console.WriteLine("  2.Поесть");
        Console.WriteLine("  3.Пойти на пары");
        s = Console.ReadKey();
        if ((s.Key == ConsoleKey.DownArrow) || (s.Key == ConsoleKey.UpArrow))
        {
            deny2();
        }
        if (s.Key == ConsoleKey.RightArrow)
        {
            date = date.AddDays(1);
            Console.Clear();
        }
        if (s.Key == ConsoleKey.LeftArrow)
        {
            date = date.AddDays(-1);
            Console.Clear();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Выбранная дата: " + date.ToShortDateString());
        s = Console.ReadKey();
        if (s.Key == ConsoleKey.RightArrow)
        {
            date = date.AddDays(1);
        }
        if (s.Key == ConsoleKey.LeftArrow)
        {
            date = date.AddDays(-1);
        }
    }
}
static void deny1()
{
    dni den1 = new dni();
    den1.data = new DateTime(2023, 02, 08);
    den1.naz = "Сдать практическую";
    den1.naz1 = "Сделать новую практическую";
    den1.op = "Описание: Записаться в очередь";
    den1.op1 = "Посмотреть как делать практическую";
    Console.Clear();
    Console.WriteLine("Выбранная дата: " + den1.data.ToShortDateString());
    Console.WriteLine("  1.Сдать практическую");
    Console.WriteLine("  2.Сделать новую практическую");
    ConsoleKeyInfo a;
    int position = 1;
    Console.SetCursorPosition(0, position);
    Console.WriteLine("=>");
    do
    {
        a = Console.ReadKey();
        if (a.Key == ConsoleKey.UpArrow)
        {
            position--;
            if (position == 0)
            {
                position = 1;
            }
        }
        if (a.Key == ConsoleKey.DownArrow)
        {
            position++;
            if (position == 3)
            {
                position = 2;
            }
        }
        if (a.Key == ConsoleKey.LeftArrow)
        {
            break;
        }
        if (a.Key == ConsoleKey.RightArrow)
        {
            break;
        }
        Console.Clear();
        Console.WriteLine("Выбранная дата: " + den1.data.ToShortDateString());
        Console.WriteLine("  1.Сдать практическую");
        Console.WriteLine("  2.Сделать новую практическую");
        Console.SetCursorPosition(0, position);
        Console.WriteLine("=>");
    } while (a.Key != ConsoleKey.Enter);
    if ((position == 1) && (a.Key == ConsoleKey.Enter))
    {

        ConsoleKeyInfo cl;
        do
        {
            Console.Clear();
            Console.WriteLine(den1.naz);
            Console.WriteLine("---------------------------");
            Console.WriteLine(den1.op);
            Console.WriteLine("Дата: " + den1.data.ToLongDateString());
            cl = Console.ReadKey();
        } while (cl.Key != ConsoleKey.E);
        Console.WriteLine("Выбранная дата: " + den1.data.ToShortDateString());
        Console.WriteLine("  1.Сдать практическую");
        Console.WriteLine("  2.Сделать новую практическую");
    }
    if ((position == 2) && (a.Key == ConsoleKey.Enter))
    {

        ConsoleKeyInfo cl;
        do
        {
            Console.Clear();
            Console.WriteLine(den1.naz1);
            Console.WriteLine("---------------------------");
            Console.WriteLine(den1.op1);
            Console.WriteLine("Дата: " + den1.data.ToLongDateString());
            cl = Console.ReadKey();
        } while (cl.Key != ConsoleKey.E);
        Console.WriteLine("Выбранная дата: " + den1.data.ToShortDateString());
        Console.WriteLine("  1.Сдать практическую");
        Console.WriteLine("  2.Сделать новую практическую");
    }
}
static void deny2()
{
    int position = 1;
    dni den1 = new dni();
    den1.data1 = new DateTime(2023, 02, 17);
    den1.naz2 = "Поспать";
    den1.naz3 = "Поесть";
    den1.op2 = "Описание: Приготовиться к хорошему сну";
    den1.op3 = "Описание: Приготовить поесть";
    Console.Clear();
    Console.WriteLine("Выбранная дата: " + den1.data1.ToShortDateString());
    Console.WriteLine("  1.Поспать");
    Console.WriteLine("  2.Поесть");
    Console.SetCursorPosition(0, position);
    Console.WriteLine("=>");
    ConsoleKeyInfo a;
    do
    {
        a = Console.ReadKey();
        if (a.Key == ConsoleKey.UpArrow)
        {
            position--;
            if (position == 0)
            {
                position = 1;
            }
        }
        if (a.Key == ConsoleKey.DownArrow)
        {
            position++;
            if (position == 3)
            {
                position = 2;
            }
        }
        if (a.Key == ConsoleKey.LeftArrow)
        {
            break;
        }
        if (a.Key == ConsoleKey.RightArrow)
        {
            break;
        }
        Console.Clear();
        Console.WriteLine("Выбранная дата: " + den1.data1.ToShortDateString());
        Console.WriteLine("  1.Поспать");
        Console.WriteLine("  2.Поесть");
        Console.SetCursorPosition(0, position);
        Console.WriteLine("=>");
    } while (a.Key != ConsoleKey.Enter);
    Console.WriteLine("Выбранная дата: " + den1.data1.ToShortDateString());
    Console.WriteLine("  1.Поспать");
    Console.WriteLine("  2.Поесть");

    if ((position == 1) && (a.Key == ConsoleKey.Enter))
    {

        ConsoleKeyInfo cl;
        do
        {
            Console.Clear();
            Console.WriteLine(den1.naz2);
            Console.WriteLine("---------------------------");
            Console.WriteLine(den1.op2);
            Console.WriteLine("Дата: " + den1.data1.ToLongDateString());
            cl = Console.ReadKey();
        } while (cl.Key != ConsoleKey.E);
        Console.WriteLine("Выбранная дата: " + den1.data1.ToShortDateString());
        Console.WriteLine("  1.Поспать");
        Console.WriteLine("  2.Поесть");
    }
    if ((position == 2) && (a.Key == ConsoleKey.Enter))
    {

        ConsoleKeyInfo cl;
        do
        {
            Console.Clear();
            Console.WriteLine(den1.naz3);
            Console.WriteLine("---------------------------");
            Console.WriteLine(den1.op3);
            Console.WriteLine("Дата: " + den1.data1.ToLongDateString());
            cl = Console.ReadKey();
        } while (cl.Key != ConsoleKey.E);
        Console.WriteLine("Выбранная дата: " + den1.data1.ToShortDateString());
        Console.WriteLine("  1.Поспать");
        Console.WriteLine("  2.Поесть");
    }
}
static void deny3()
{
    int position = 1;
    dni den1 = new dni();
    den1.data2 = new DateTime(2023, 02, 14);
    den1.naz4 = "Отметить праздник";
    den1.naz5 = "Написать о поздравлении праздника всем";
    den1.op = "Описание: Порадоваться данному празднику";
    Console.Clear();
    Console.WriteLine("Выбранная дата: " + den1.data2.ToShortDateString());
    Console.WriteLine("  1.Отметить праздник");
    Console.WriteLine("  2.Написать о поздравлении праздника всем");
    Console.SetCursorPosition(0, position);
    Console.WriteLine("=>");
    ConsoleKeyInfo a;
    do
    {
        a = Console.ReadKey();
        if (a.Key == ConsoleKey.UpArrow)
        {
            position--;
            if (position == 0)
            {
                position = 1;
            }
        }
        if (a.Key == ConsoleKey.DownArrow)
        {
            position++;
            if (position == 3)
            {
                position = 2;
            }
        }
        if (a.Key == ConsoleKey.LeftArrow)
        {
            break;
        }
        if (a.Key == ConsoleKey.RightArrow)
        {
            break;
        }
        Console.Clear();
        Console.WriteLine("Выбранная дата: " + den1.data2.ToShortDateString());
        Console.WriteLine("  1.Отметить праздник");
        Console.WriteLine("  2.Написать о поздравлении праздника всем");
        Console.SetCursorPosition(0, position);
        Console.WriteLine("=>");

    } while (a.Key != ConsoleKey.Enter);
    if ((position == 1) && (a.Key == ConsoleKey.Enter))
    {

        ConsoleKeyInfo cl;
        do
        {
            Console.Clear();
            Console.WriteLine(den1.naz4);
            Console.WriteLine("---------------------------");
            Console.WriteLine(den1.op);
            Console.WriteLine("Дата: " + den1.data2.ToLongDateString());
            cl = Console.ReadKey();
        } while (cl.Key != ConsoleKey.E);
        Console.WriteLine("Выбранная дата: " + den1.data2.ToShortDateString());
        Console.WriteLine("  1.Отметить праздник");
        Console.WriteLine("  2.Написать о поздравлении праздника всем");
    }
    if ((position == 2) && (a.Key == ConsoleKey.Enter))
    {

        ConsoleKeyInfo cl;
        do
        {
            Console.Clear();
            Console.WriteLine(den1.naz5);
            Console.WriteLine("---------------------------");
            Console.WriteLine(den1.op1);
            Console.WriteLine("Дата: " + den1.data2.ToLongDateString());
            cl = Console.ReadKey();
        } while (cl.Key != ConsoleKey.E);
        Console.WriteLine("Выбранная дата: " + den1.data2.ToShortDateString());
        Console.WriteLine("  1.Отметить праздник");
        Console.WriteLine("  2.Написать о поздравлении праздника всем");
    }
}