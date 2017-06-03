using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresHW
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            transaction:

            Console.WriteLine("Seçiminiz: Arama(1), Ekleme(2), Silme(3), Listeleme(4), Çıkış(5): 1");
            char selection = Console.ReadKey().KeyChar;

            switch (selection)
            {
                case '1':

                    break;
                case '2':

                    break;
                case '3':

                    break;
                case '4':

                    break;
                default:
                    Console.WriteLine("\nHatalı seçim!");
                    goto transaction;
                    break;
            }




            linkedList.Insert(new Student(269, "Gülcan", "Kara"));
            linkedList.Insert(new Student(186, "Nagehan", "Çelik"));
            linkedList.Insert(new Student(158, "Mustafa", "Yılmaz"));
            linkedList.Insert(new Student(189, "Hakan", "Yalçınoğlu"));
            linkedList.Insert(new Student(241, "Adem", "Nur"));

            linkedList.Insert(new Student(269, "Gülcan", "Kara"));
            linkedList.DisplayList();


            linkedList.Delete(269);
            Console.WriteLine("Silme Yapıldı!");

            linkedList.DisplayList();
            

            Console.ReadKey();
        }


    }
}