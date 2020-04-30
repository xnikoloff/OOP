using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    class GenericList<T>
    {
        private List<T> list = new List<T>();
        private T[] array;

        public GenericList(int count)
        {
            this.array = new T[count];
        }
        
        private void FillArray()
        {
            if(this.array != null)
            {
                Array.Clear(this.array, 0, this.array.Length);
            }

            for(int i = 0; i < this.list.Count; i++)
            {
                if(i >= this.array.Length)
                {
                    this.array = ReallocateArray(this.array);
                }

                this.array[i] = this.list[i];
            }
        }

        public T[] ReallocateArray(T[] arr)
        {
            T[] newArr = new T[arr.Length * 2];
            
            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = this.array[i];
            }
            return newArr;
        }

        public void PrintArray()
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void AddElement(T element)
        {
            list.Add(element);
            FillArray();
        }

        public void InsertElement(T element, int index)
        {
            list.Insert(index, element);
            FillArray();
        }

        public void GetElement(int index)
        {
            try
            {
                Console.WriteLine(list[index]);
            }
            
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("No such index.");
            }
        }

        public void RemoveElement(int index)
        {
            try
            {
                for(int i = index; i < list.Count - 1; i++)
                {
                    list[i] = list[i + 1];
                }

                list.RemoveAt(list.Count - 1);
                FillArray();
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("No such index.");
            }

            
        }

        public void PrintList()
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public void Search(T element)
        {
            if (list.Contains(element))
            {
                int index = list.IndexOf(element);
                Console.WriteLine(list[index]);
            }

            else
            {
                Console.WriteLine("No results found!");
            }
        }

        

        //property
        public List<T> List
        {
            get { return this.list; }
            set { this.list = value; }
        }
    }
}
