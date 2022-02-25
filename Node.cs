using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitaReto
{
    internal class Node
    {
        public String data; //Ya son package-private
        public Node next;
        public Node previous;



        public Node(String data)//Le puse el public
        {
            this.data = data;
        }

    }
}
