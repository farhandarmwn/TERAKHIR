using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.WriteLine("\nNomor Menu [1..4] : ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();


            Console.WriteLine("\n PILIH MENU APLIKASI\n");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampil Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            Customer customer = new Customer();

            Console.WriteLine("Tambah Data Customer\n");

            Console.Write("Kode Customer : ");
            string Kode = Console.ReadLine();

            Console.Write("Nama Customer : ");
            string Nama = Console.ReadLine();

            Console.Write("Total Piutang : ");
            int Piutang = Convert.ToInt32(Console.ReadLine());

            Customer dataCust = new Customer();
            dataCust.Kode = Kode;
            dataCust.Nama = Nama;
            dataCust.Piutang = Piutang;

            daftarCustomer.Add(dataCust);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();
            Console.WriteLine("HAPUS DATA CUSTOMER\n");

            Console.Write("Kode Customer\n");
            string Kode = Console.ReadLine();

            bool found = false;
            int i = 0, indexHapus = -1;
            foreach (Customer dataCust in daftarCustomer)
            {
                if (dataCust.Kode == Kode)
                {
                    found = true;
                    indexHapus = i;
                }
                i++;
            }
            if (found)
            {
                daftarCustomer.RemoveAt(indexHapus);
                Console.WriteLine("DATA CUSTOMER BERHASIL DIHAPUS");
            }
            else
            {
                Console.WriteLine("DATA CUSTOMER TIDAK DITEMUKAN");
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            Console.WriteLine("-- DATA CUSTOMER--");

            int i = 1;
            foreach (Customer dataCust in daftarCustomer)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", i, dataCust.Kode, dataCust.Nama, dataCust.Piutang);
                i++;
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();

        }
    }
}
