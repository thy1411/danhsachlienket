using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DánhachLienKetDon
{
    class Node
    {
        private int info;
        private Node next;
        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }
    class SingLeLinkList
    {
        private Node Head;
        public SingLeLinkList()
        {
            Head = null;
        }
        public void AddHead(int x)
        {
            Node p = new Node(x);
            if (Head == null)
            {
                Head = p;
            }    
            else
            {
                Node q = Head;
                while (q.Next != null)
                {
                    q = q.Next;
                }
                q.Next = p;
            }
        }
        public void ProcessList()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{p.Info}    ");
                p = p.Next;
            } 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SingLeLinkList l = new SingLeLinkList();
            NhapDanhSach(l);
            Console.WriteLine("Danh sach lien ket: ");
            l.ProcessList();
            Console.ReadLine();
        }
        static void NhapDanhSach(SingLeLinkList l)
        {
            string chon = "y";
            int x;
            while (true)
            {
                Console.Write("Nhap gia tri nut: ");
                x = int.Parse(Console.ReadLine());
                l.AddHead(x);
                Console.Write("Tiep tuc? (y/n)");
                chon = Console.ReadLine();
                if (chon == "n")
                    break;
            }
        }
    }
}
