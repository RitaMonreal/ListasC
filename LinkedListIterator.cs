using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitaReto
{
    internal class LinkedListIterator
    {
        public Node currentNode;//Le puse public



        public LinkedListIterator(Node startNode)//Le puse public
        {
            currentNode = startNode;
        }



        public Boolean hasNext()//Puse Boolean con mayuscula la primera letra
        {
            return currentNode != null;
        }



        public String next()
        {
            String data = currentNode.data;



            currentNode = currentNode.next;


            return data;
        }
    }
}
