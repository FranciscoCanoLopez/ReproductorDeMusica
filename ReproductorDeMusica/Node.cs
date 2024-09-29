using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorDeMusica
{
    internal class Node
    {
        public string Name { get; set; }
        public string Rute { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(string name, string rute)
        {
            Name = name;
            Rute = rute;
            Next = null!;
            Prev = null!;
        }
    }
}
