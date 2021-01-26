using System;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plaka = new MyDictionary<int, string>();
            plaka.Add(61, "Trabzon");
            plaka.Add(44, "Malatya");
            plaka.Add(35, "İzmir");
            plaka.Add(34, "İstanbul");

            Console.WriteLine("Plaka : " + plaka.Items1[0] + "  " + "Şehir : " + plaka.Items2[0] );
            Console.WriteLine("Plaka : " + plaka.Items1[1] + "  " + "Şehir : " + plaka.Items2[1]);
            Console.WriteLine("Plaka : " + plaka.Items1[2] + "  " + "Şehir : " + plaka.Items2[2]);
            Console.WriteLine("Plaka : " + plaka.Items1[3] + "  " + "Şehir : " + plaka.Items2[3]);

        }
    }
}
