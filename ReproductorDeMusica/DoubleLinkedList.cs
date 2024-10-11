using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorDeMusica
{
    internal class DoubleLinkedList
    {
        public Node Head { get; set; }
        public Node Last { get; set; }
        public Node Current { get; set; }
        public DoubleLinkedList()
        {
            Head = null!;
            Last = null!; 
            Current = null!;
        }
        public void AggNode(string name, string rute)
        {
            Node New = new(name, rute);
            if (Head == null)
            {
                Head = New;
                Last = New;
            }
            else
            {
                Last.Next = New;
                New.Prev = Last;
                Last = New;
            }
        }
        public bool Search(string name)
        {
            Node? current = Head;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void MoveNext()
        {
            if (Current != null && Current.Next != null)
            {
                Current = Current.Next;
            }
        }
        public void MoverAnterior()
        {
            if (Current != null && Current.Prev != null)
            {
                Current = Current.Prev;
            }
        }
        public void Inicializar()
        {
            Current = Head;
        }
        public void Clear()
        {
            Head = null;
            Last = null;
            Current = null;
        }

    }
}
