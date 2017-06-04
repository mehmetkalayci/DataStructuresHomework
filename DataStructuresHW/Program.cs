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
            linkedList.Insert(new Student(269, "Gülcan", "Kara"));
            linkedList.Insert(new Student(186, "Nagehan", "Çelik"));
            linkedList.Insert(new Student(158, "Mustafa", "Yılmaz"));
            linkedList.Insert(new Student(189, "Hakan", "Yalçınoğlu"));
            linkedList.Insert(new Student(200, "Hakan", "Yalçınoğlu"));
            linkedList.Insert(new Student(241, "Adem", "Nur"));
            linkedList.Insert(new Student(269, "Gülcan", "Kara"));

            transaction:

            Console.WriteLine("Seçiminiz: Arama(1), Ekleme(2), Silme(3), Listeleme(4), Çıkış(5): 1");
            char selection = Console.ReadKey().KeyChar;
            Console.WriteLine("");

            switch (selection)
            {
                case '1':
                    Console.WriteLine("Arama Kriteriniz: Numara(1), Adı(2), Soyadı(3):");
                    char selectionForSerach = Console.ReadKey().KeyChar;
                    switch (selectionForSerach)
                    {
                        case '1':
                            Console.WriteLine("\nNumara Giriniz");
                            int number = Convert.ToInt32(Console.ReadLine());
                            int sQueue = -1;
                            Student a = linkedList.FindByStudentNumber(number, out sQueue);
                            if (sQueue != -1)
                            {
                                Console.WriteLine("Öğrenci numarası       Öğrenci Adı                Soyadı            Sıra No");
                                Console.WriteLine(a.Number + "                    " + a.Name + "                   " + a.Surname + "             " + sQueue);
                            }
                            else
                            {
                                Console.WriteLine("Aradığınız Kriterde Öğrenci Bulunmamaktadır.");
                            }
                            goto transaction;
                        case '2':
                            Console.WriteLine("\nÖğrenci Adı Giriniz:");
                            string name = Console.ReadLine();
                            string finded=linkedList.FindByStudentName(name, linkedList.ListCount());
                            if (!string.IsNullOrEmpty(finded))
                            {
                                Console.WriteLine("Öğrenci numarası       Öğrenci Adı                Soyadı            Sıra No");
                                Console.WriteLine(finded);

                            }
                            else
                            {
                                Console.WriteLine("Aradığınız Kriterde Öğrenci Bulunamadı");

                            }
                            break;
                        case '3':
                            Console.WriteLine("\nÖğrenci Soyadı Giriniz:"); 
                            string surName = Console.ReadLine();
                            string finded2 = linkedList.FindByStudentSurname(surName, linkedList.ListCount());
                            if (!string.IsNullOrEmpty(finded2))
                            {
                                Console.WriteLine("Öğrenci numarası       Öğrenci Adı                Soyadı            Sıra No");
                                Console.WriteLine(finded2);
                            }
                            else
                            {
                                Console.WriteLine("Aradığınız Kriterde Öğrenci Bulunamadı");

                            }
                            break;
                        default:
                            break;
                    }
                    goto transaction;

                case '2':
                    Console.WriteLine("Öğrenci Numarası Giriniz:");
                    int newStudentNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Öğrenci Adı Giriniz:");
                    string newStudentName = Console.ReadLine();
                    Console.WriteLine("Öğrenci Soyadı Giriniz:");
                    string newStudentSurname = Console.ReadLine();
                    linkedList.Insert(new Student(newStudentNumber, newStudentName, newStudentSurname));
                    linkedList.DisplayList();
                    goto transaction;

                case '3':
                    Console.WriteLine("Öğrenci Numarası Giriniz:");
                    int studentNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İlgili kaydı silmek istediğinize emin misiniz? (E/H):");
                    char answer = Console.ReadKey().KeyChar;
                    if (answer == 'E')
                    {
                        linkedList.Delete(studentNumber);
                    }
                    linkedList.DisplayList();

                    goto transaction;

                case '4':
                    linkedList.DisplayList();
                    goto transaction;
                case '5':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nHatalı seçim!");
                    goto transaction;

            }

            linkedList.DisplayList();


            linkedList.Delete(269);
            Console.WriteLine("Silme Yapıldı!");

            linkedList.DisplayList();


            Console.ReadKey();
        }


    }
}