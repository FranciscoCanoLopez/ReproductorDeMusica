using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorDeMusica
{
    internal class DoubleLinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }
        public Node Current { get; set; }

        public DoubleLinkedList()
        {
            First = null!;
            Last = null!; 
            Current = null!;
        }

        public void AggNode(string name, string rute)
        {
            Node New = new(name, rute);
            if (First == null)
            {
                First = New;
                Last = New;
            }
            else
            {
                Last.Next = New;
                New.Prev = Last;
                Last = New;
            }
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
            Current = First;
        }
    }
}
