using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity4LL
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        //Method untuk menambahkan sebuah node kedalam list
        public void addNoote()
        {
            int nim;
            string nm;
            Console.WriteLine("\nMasukkan nomer mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nMasukkan nama mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();

            //Node ditambahkan sebagai node pertama
            if (START == null || nim <= START.noMhs)
            {
                if ((START == null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nMasukkan mahasiswa sama tidak diizinkan  ");
                }
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
