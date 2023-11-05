//Тема 7 Задача 1. Соответствие номера из таблицы Unicode символу

//Console.Title = "Соответствие номера из таблицы Unicode символу";

//for(int i=0;i<=256;i++)

//    {

//    Console.WriteLine($"Код {i} соотв. символу {(char)i}");

//    }

//Задача 2

//Console.Title = "Дан символ. Вывести его код";

//Console.Write("Введите символ: ");

//char ch = char.Parse(Console.ReadLine());

//Console.WriteLine($"Символ {ch} имеет код {(int)ch} ");

//Задача 3 

//Console.Title = "Вывести символ, который в кодовой таблице ASCII следует за этим символом";

//Console.Write("дите символ ");

//char ch = char.Parse(Console.ReadLine());

//int code = (int)ch;

//Console.WriteLine($"За символом {ch} следует {(char)(code+1)}");

//Задача 6

//Console.Title = "Дано название футбольного клуба. Напечатать его на экране «столбиком»";

//Console.Write("Введите название клуба ");

//string ch = Console.ReadLine();

//char[] omas = ch.ToCharArray();

//for(int i=0;i<omas.Length;i++)

//{

//    Console.WriteLine($"{omas[i]}");

//}

//Задача 7

//Console.Title = "Составить программу, которая печатает заданное слово, начиная с последней буквы";

//Console.Write("Введите название клуба ");

//string ch = Console.ReadLine();

//char[] omas = ch.ToCharArray();

//for (int i = omas.Length -1; i >= 0; i--)

//{

//    Console.WriteLine($"{omas[i]}");

//}

//Задача 8 

//Console.Title = "Преобразовать символы в строке из строчных в прописные и обратно";

//Console.Write("Введите строку:");

//string ch = Console.ReadLine();

//char[] s = ch.ToCharArray();

//for (int i = 0; i < s.Length; i++)

//{

//    Console.Write(char.ToUpper(s[i]));

//}

//Console.WriteLine();

//for (int i = 0; i < s.Length; i++)

//{

//    Console.Write(char.ToLower(s[i]));

//}

//Задача 4

//Console.Title = "Вывести символ, который в кодовой таблице ASCII следует за этим символом";

//Console.Write("дите символ ");

//char ch = char.Parse(Console.ReadLine());

//int code = (int)ch;

//Console.WriteLine($"За символом {ch} предшествуют символы {(char)(code - 1)} {(char)(code - 2)}");