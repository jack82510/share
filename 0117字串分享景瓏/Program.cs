using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0117字串分享景瓏
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Replace(string1, string2) => string1的內容會被string2取代掉

            String str = "1 2 3 4 5 6 7 8 9";
            Console.WriteLine("Before string: \"{0}\"", str);
            Console.WriteLine("After  string: \"{0}\"", str.Replace(' ', ','));

            string strr = "我好率";
            Console.WriteLine("Before string: \"{0}\"", strr);
            Console.WriteLine("Before string: \"{0}\"", strr.Replace("我好率", "我好帥"));



            // 2.IndexOf()=> 報告這個執行個體中指定之 Unicode 字元或字串第一次出現時的所在索引 (以零為起始)。 如果在此執行個體中找不到該字元或字串，此方法會傳回 -1


            //string s1 = "Hello C#";  //從0開始
            //int index = s1.IndexOf('e');
            //Console.WriteLine(index);
            //Console.ReadKey();




            // 3. ToCharArray()=> 將這個執行個體中的字元複製到 Unicode 字元陣列中

            //string s = "AaBbCcDd";
            //char[] chars = s.ToCharArray();
            //Console.WriteLine("Original string: {0}", s);
            //Console.WriteLine("Character array:");
            //for (int ctr = 0; ctr < chars.Length; ctr++)
            //{
            //    Console.WriteLine($" {ctr}:{chars[ctr]}");
            //}
            //Console.ReadKey();



        }
    }
}
