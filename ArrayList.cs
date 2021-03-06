using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitaReto
{
    internal class ArrayList
    {
        public const int DEFAULT_SIZE = 2;
        private String[] array;
        private int size;

        public static String getName()
        {
            return "ArrayList";
        }

        public ArrayList()
        {
            array = new String[DEFAULT_SIZE];
        }

        public ArrayList(int size)
        {
            array = new String[size];
        }

        public void addAtTail(String data)
        {

            if (size == array.Length)//LE PUSE MAYUSCULA AL LENGHT
            {
                increaseArraySize();
            }

            array[size] = data;
            size++;
        }

        public void addAtFront(String data)
        {

            if (size == array.Length)
            {
                increaseArraySize();
            }

            if (size >= 0)
            {
                Array.Copy(array, 0, array, 1, size);//AQUI LE MOVI Y LE PUSE MAYUSCULASSS
            }
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {

            if (index < 0 || index >= size)
            {
                return;
            }

            if (size - 1 - index >= 0)
            {
                Array.Copy(array, index + 1, array, index, size - 1 - index);
            }

            array[size - 1] = null;
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = null;
            }
            size = 0;
        }

        public void setAt(int index, String data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        public String getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : null;
        }

        public ArrayListIterator getIterator()
        {
            return new ArrayListIterator(this);
        }

        public int getSize()
        {
            return size;
        }

        private void increaseArraySize()
        {
            String[] newArray = new String[array.Length * 2];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

    }
}
