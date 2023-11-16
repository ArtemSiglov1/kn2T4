 //Задача 1. Массив предназначен для хранения значений ростов двенадцати человек.С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.Вывести значения элементов с использованием цикла for. Найти средний рост.

        //static int[] Mas()

        //{

        //    int[] omas=new int[12];

        //    Random rnd = new Random();

        //    for (int i = 0;i<omas.Length;i++) 

        //    {

        //        omas[i]=rnd.Next(163,190);

        //    }

        //    return omas;

        //}

        //static int[] OutPut(int[] omas) 

        //{

        //for(int i = 0; i<omas.Length;i++) 

        //    {

        //        Console.WriteLine($"omas[{i}]={omas[i]}");

        //    }

        //return omas;

        //}

        //static double Srh(int[] omas)

        //{

        //    double sum = 0;

        //    for (int i = 0; i < omas.Length; i++)

        //    {

        //        sum +=omas[i] ;

        //    }

        //    return sum / omas.Length  ;

        //}

        //static void Main(string[] args)

        //{

        //    int[] omas = Mas();

        //    OutPut(omas);

        //    double z=Srh(omas);

        //    Console.WriteLine($"{z:f0}") ;

        //    Console.ReadLine();

        //}

        //Задача 2. Заполнить массив из восьми элементов следующими значениями с использованием явной инициализации: первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, восьмой —13. Найти максимальный и минимальный элементы массива.

        //static void Main()

        //{

        //    int[] omas = { 37, 0, 50, 46, 34, 46, 0, 13 };

        //   int a= Max(omas);

        //    int b=Min(omas);

        //    Console.WriteLine($"max={a} \n min={b}");

        //    Console.ReadKey();

        //}

        //static int Max(int[]omas)

        //{

        //   int max = omas[0];

        //    for(int i=1;i<omas.Length;i++)

        //    {

        //        if (omas[i] > max)

        //        {

        //            max = omas[i];

        //        }



        //    }

        //    return max;

        //}

        //static int Min(int[] omas)

        //{

        //     int min= omas[0];

        //    for (int i = 1; i < omas.Length; i++)

        //    {

        //        if (omas[i] < min)

        //        {

        //            min = omas[i];

        //        }



        //    }

        //    return min;

        //}

        //Задача 3. Заполнить одномерный массив с клавиатуры и вывести элементы массива на экран в обратном порядке.

        //static void Main(string[] args) 

        //{

        //    int [] omas=Mas();

        //    int []s = Rev(omas);

        //    Console.WriteLine(s);

        //    Console.ReadLine();

        //}

        //static int [] Mas()

        //{

        //    int[] omas=new int[5];

        //    for (int i = 0; i < omas.Length; i++) 

        //    {

        //        Console.Write($"omas[{i}]=");

        //        omas[i] = int.Parse( Console.ReadLine() );

        //    }

        //    return omas;

        //}

        //static int[] Rev(int[] omas) 

        //{

        //    for (int i = omas.Length-1;0<=i;i--)

        //    {

        //        Console.WriteLine($"omas[{i}]={omas[i]}");

        //    }

        // return omas;

        //}

        //4

        //static void Main(string[] args) 

        //{

        //    int[] omas = Mas();

        //     Double(omas);

        //    Console.ReadLine();

        //}

        //static int[] Mas() 

        //{

        //    Random rnd = new Random();

        //    int[] omas = new int[4];

        //    for (int i = 0; i < omas.Length; i++) 

        //    {

        //        omas[i] = rnd.Next(-5,5);

        //    }

        //    return omas;

        //}

        //static int[] Double(int[] omas)

        //{

        //    for(int i = 0;i < omas.Length;i++) 

        //    {

        //        Console.WriteLine($"omas[{i}]={omas[i]}");

        //        omas[i] = omas[i] * 2;

        //        Console.WriteLine($"omas[{i}]={omas[i]}");

        //    }

        //    return omas;

        //}

        //5

        //static void Main() 

        //{

        //    int[] omas = Mas();

        //    int z=Neud(omas);

        //    Console.WriteLine($"Количество неуспевающих={z}");

        //    Console.ReadLine();

        //}

        //static int[] Mas()

        //{

        //    Random rnd = new Random();

        //    int[] omas = new int[25];

        //    for (int i = 0; i < omas.Length; i++)

        //    {

        //        omas[i] = rnd.Next(2, 5);

        //    }

        //    return omas;

        //}

        //static int Neud(int[]omas)

        //{

        //    int s = 0;

        //    for(int i = 0; i < omas.Length; i++)

        //    {

        //        Console.WriteLine($"omas[{i}]={omas[i]}");

        //        if (omas[i] == 2)

        //        {

        //            s++;

        //        }

        //    }

        //    return s;

        //}

    }
