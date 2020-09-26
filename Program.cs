using System;// подключаемое пространство имен
using System.Text;
namespace _1lab// объявление нового пространства имен
{
    class Program // объявление нового класса
    {
        static void Main(string[] args) // объявление нового статического метода
        {
            bool a = true;        //1.a  
            byte b = 5;     
            sbyte c = 102;      
            short d = 50;      
            ushort e = 78;    
            int f = 10;     
            uint g = 26u;    
            long h = -389L;      
            ulong i = 458ul;      
            float j = 48.25f;
            double k = 57.4;
            decimal l = 7.9m;        
            char m = 'M';
            string n = "574";
            object o = 3.14;
            short p = b;            //1.b неявное приведение
            int q = b;
            long r = b;
            double s = b;
            ushort t = b;
            byte u = (byte)f;       //явное приведение
            short v = (short)f;
            string w = Convert.ToString(f);
            int x = Convert.ToInt32(k);
            int y = int.Parse(n);   //строка в число
            object z = f;           //1.c упаковка
            int aa = (int)z;        //распаковка
            var bb = new[] { 0, 1, 2 };            //1.b
            Console.WriteLine(bb.GetType());
            Console.WriteLine();
            int? cc = null;          //1.c
            int dd = cc ?? 1;
            Console.WriteLine("Результат сравнения: " + dd);
            string ee= "first";         //2.a
            string ff= "second";
            string gg= "third string";
            Console.WriteLine("результат сравнения: " + ee.Equals(ff));
            Console.WriteLine("результат сравнения: " + (ff == gg));
            string hh = "it was a " + ee + " string";             //2.b сцепление 
            Console.WriteLine(hh);
            Console.WriteLine(ff.Substring(2,3));               //выделение подстроки
            string[] words = gg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);      //разделение строки на слова
            foreach (string ii in words)
            {
                Console.WriteLine(ii);
            }
            Console.WriteLine(ff.Insert(3, ee));                                                 //вставка подстроки в заданную позицию
            Console.WriteLine(gg.Remove(1, 2));                                                   //удаление заданной подстроки
            string jj = "";                       //2.c пустая строка
            Console.WriteLine(jj.Insert(0, ee));
            string kk = null;                      //строка null
            Console.WriteLine("результат сравнения: " + ff.Equals(kk));
            StringBuilder ll = new StringBuilder(" creatted a new ");              //2.d
            Console.WriteLine(ll);
            Console.WriteLine(ll.Remove(5, 1));
            Console.WriteLine(ll.Insert(0,"I"));
            Console.WriteLine(ll.Append("wonderful string"));
            int[,] mm = { { 1, 2, 3 }, { 4, 5, 6 } };                  //3.a
            Console.WriteLine( mm);
            int rows = mm.GetUpperBound(0) + 1;                 //количество строк таблицы
            int columns = mm.Length / rows;                 //количество элементов в каждой строке
            for (int mi = 0; mi < rows; mi++)
            {
                for (int mj = 0; mj < columns; mj++)
                {
                    Console.Write($"{mm[mi, mj]} \t");
                }
                Console.WriteLine();
            }
            string[] nn = { "one", "two", "three" };                    //3.b
             foreach (string ni in nn)
             {
                 Console.WriteLine(ni);
             }
             Console.WriteLine("Длина массива: "+nn.Length);
             Console.Write("Введите номер элемента, который нужно заменить: ");                  //замена элемента
             int pos = Convert.ToInt32(Console.ReadLine());
             Console.Write("\nВведите элемент: ");
             string elem = Console.ReadLine();
             for (int nk = 0; nk < nn.Length; nk++)
             {
                 if (pos==nk)
                 {
                     nn[nk] = elem;
                 }
             }
             foreach (string ni in nn)
             {
                 Console.WriteLine(ni);
             }
            int[][] oo = { new int[2], new int[3], new int[4] };                    //3.c
            Console.WriteLine("Введите элементы массива ");
            for (int oi = 0; oi < oo.Length; oi++) 
            {
                for (int oj = 0; oj < oo[oi].Length; oj++) 
                {
                    oo[oi][oj] = int.Parse(Console.ReadLine());                
                }
                Console.WriteLine();
            }
            for (int oi = 0; oi < oo.Length; oi++)
            {
                for (int oj = 0; oj < oo[oi].Length; oj++)
                {
                    Console.Write(oo[oi][oj]+"\t" );

                }
                Console.WriteLine();
            }
            var pp = new[] { 5, 10, 23, 16, 8 };                    //3.d
            var qq = "string";
            (int, string, char, string, ulong) rr = (1, "first", 'F', "one", 45678UL);                  //4.a
            Console.WriteLine(rr);
            Console.WriteLine(rr.Item3);                    //4.b
            var (one, two, three, four,five) = rr;                  //4.c
            (int, string, char, string, ulong) ss = (2, "second", 'S', "two", 45678UL);                 //4.d
            Console.WriteLine(rr.Item3.Equals(ss.Item3));
            Console.WriteLine(rr.Item5.Equals(ss.Item5));


        }
    }
}
