using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;

            //Node ditambahkan sebagai node pertama
            if (START == null || nim <= START.noMhs)
            {
                if ((START == null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan  ");
                }
                nodeBaru.next = START;
                START = nodeBaru;
                return;
            }
            //Menemukan lokasi node baru didalam list
            Node previous, current;
            previous = START;
            current = START;

            while((current != null) && (nim >= current.noMhs))
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nNomer mahasiswa sama tidak diizinkan  ");
                }
                previous = current;
                current = current.next;
            }
            //Node baru akan ditempatkan di antara previous dan current
            nodeBaru.next = current;
            previous.next = current;
        }
        //method untuk mmenghapus node tertentu didalam list 
        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;
            //check apakah node yang dimaksud ada didalam list atau tidak
            if (Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
            
                START = START.next;
                return true;
            
        }
        //Method untuk mengecek apakah node yang dimaksud ada didalam list atau tidak
        public bool Search (int nim, ref Node previous, ref Node current)
        {
            previous = current;
            while((current != null) && (nim >= current.noMhs))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return (false);
            else
                return(true);
        }
        

    }
   
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
