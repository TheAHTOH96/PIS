using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randnum = new Random();
            int a = 50, b = 30;
            string name;
            bool ng = true;
            // Console.SetWindowSize(a,b);
            // Console.SetWindowPosition(3, 5);
            for (int i = 0; i < 2; i++)
            {
                name = a > 10 ? "odin" : "dwa";
                Console.WriteLine(a.ToString() + " " + b.ToString());
                Console.WriteLine(name + "\n ok? \n");
                while (ng)
                {
                    try
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                        ng = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("FormatException");
                        ng = true;
                    }
                    finally
                    {
                        Console.WriteLine("pubum");
                    }
                }
                ng = true;
                b += randnum.Next(0, 11);
                name = a > 10 ? "odin" : "dwa";
                Console.WriteLine(name + "\n ok: \n");
                Console.Write(a.ToString() + " " + b.ToString() +"\n\n");
            }
            Console.WriteLine("end\n\n");
            List<string> mstr = new List<string>();
            mstr.Add("\nOne");
            mstr.Add("  Two ");
            mstr.Add("A");
            mstr.Add("T");
            mstr.Add("T");
            mstr.Add("    Three \n");
            mstr.Add(" Finish\n");
            for (int i = 0; i < mstr.Count(); i++)
            {
                Console.Write(mstr[i]);
            }
            char[] mch = mstr[1].ToCharArray();
            mstr.RemoveAt(2);
            while (mstr.Remove("T")) ;
            mstr[0].Insert(0,"bb");// не помог тут
            mstr[1].Remove(2);// не помог тут
            /* for (int i = 0; i < mstr.Count(); i++)
             {
                 Console.Write(mstr[i]);
             }*/
            foreach (string el in mstr)
            {
                if (el.Contains("T")) Console.Write(el.Replace("T","tt"));
                else
                Console.Write(el.ToUpper()/*.Insert(0, "oo")*/);
                if (el.StartsWith(" ")) Console.Write("  (.)(.)  ");
            }
            Console.WriteLine("\n str empty"+ String.IsNullOrEmpty(mstr[0]));

            Console.WriteLine("\n str 1 0   " + String.Compare(mstr[1],mstr[2])+" "+ String.Compare(mstr[1], mstr[1]) + " " + String.Compare(mstr[2], mstr[1]) +"\n");
            Console.ReadKey();
        }
    }
}
