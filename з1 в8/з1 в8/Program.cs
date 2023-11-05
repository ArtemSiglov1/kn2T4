using System.Text;


 StringBuilder sb = new StringBuilder(Console.ReadLine());

char[] arr = new char[sb.Length];

sb.CopyTo(0, arr, 0, sb.Length);

for (int i = arr.Length - 1; i >= 0; i--)

{

    Console.WriteLine("arrc[{0}] = {1}", i, arr[i]);

}

