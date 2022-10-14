using System;
using System.Diagnostics.Tracing;

namespace Exercise_1
{
    class Program
    {
        // Deklarasikan array int dengan ukuran 20
        private int[] maulana = new int[109];
        // Deklarasikan Variabel int untuk menyimpan banyaknya data pada array
        private int n;
        // Fungsi / Methode untuk menerima masukan 
        public void read()
        {
            //menerima angka untuk mentukan banyaknya data uang disimpan dalam array
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen dalam Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 109)
                    break;
                else
                Console.WriteLine("\n Array dapat mempunyai maksimal 109 element \n");

            }
            Console.WriteLine("");
            Console.WriteLine("============================================");
            Console.WriteLine(" Masukkan Element Array");
            Console.WriteLine("============================================");

            //pengguna memasukkan element pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                maulana[i] = Int32.Parse(s1);
            }

        }
        public void display()
        {
            //menampilkan array tersusun
            Console.WriteLine("");
            Console.WriteLine("============================================");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("============================================");
            for (int MF = 0; MF < n; MF++)
            {
                Console.WriteLine(maulana[MF]);
            }
            Console.WriteLine("");
        } 
        public void ExerciseSortArray1()
        {
            for (int i = 1; i < n; i++) // For n-1 passes
            {
                //pada pass i,bandingkan n-i elemen pertama dengan element selanjutnya
                for (int MF = 0; MF < n; MF++)
                {
                    if (maulana[MF] > maulana[MF + 1])//jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = maulana[MF];
                        maulana[MF] = maulana[MF + 1];
                        maulana[MF + 1] = temp;

                    }
                }
            }
            
        }
       
        static void Main(string[]args)
        {
            //Creating the object of the Exercise class
            Program mylist = new Program();

            // Memanggil fungsi untuk menerima elemen array
            mylist.read();

            // Memanggil fungsi untuk mengurutkan array n-1
            mylist.ExerciseSortArray1();

            // Memanggil fungsi untuk menampilkan array tersusun
            mylist.display();

            //Exit
            Console.WriteLine("\n\n Silahkan Tekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }


}
