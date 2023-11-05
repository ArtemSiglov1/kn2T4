//string st = "";

//int l = st.Length;

//string s = "";

//for (int i = 0; i < 5; i++) 

//{

//    Console.Write($"Введите {i + 1}-е слово");

//    string st1 = Console.ReadLine();

//    if(st1.Length>l)

//    {

//        l = st1.Length;

//        s = st1;

//    }

//    Console.WriteLine($"Самоее длинное слово {s} имеет {l} символов");

//}

//Задача 2

//string st = Console.ReadLine();

//for (int i = 0; i < st.Length; i++)

//{

//    if (st[i] == 'e')

//    {

//        st = st.Replace("e", "");

//    }

//    if (st[i] == 'E')

//    {

//        st = st.Replace("E", "");

//    }

//}





//Console.Write(st);

//Задача 3

//string st = Console.ReadLine();

//int s = 0;

//for (int i = 0; i < st.Length; i++)

//{

//    if (st[i] == 'А' || st[i] == 'а')

//    {

//        s++;



//    }



//}

//Console.WriteLine(s);

//задача 4

//string st = Console.ReadLine();

//int i;

//for (i = 0; st[i] != ' '; i++)

//{



//}
//Задача 6
//string s = Console.ReadLine();
//for (int i = 0; i < s.Length; i++)
//{
//    if (s[i] == 'а' || s[i] == 'А')
//    {
//        s = s.Replace("А", "О");
//        s = s.Replace("а", "о");

//    }
//}
//Console.WriteLine($"{s}");

//Задача 7
//Console.WriteLine("Введите строку:");
//string s = Console.ReadLine();
//string r= "";
//for (int i = s.Length - 1; i >= 0; i--)
//{
//    r += s[i];
//}
//Console.WriteLine("Реверсированная строка:"+r);
Console.ReadKey();