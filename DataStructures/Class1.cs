using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int length { get; set; }

        public DoublyLinkedList()
        {
        }

        public void Add(T data)//Add to the end.
        {
            Node<T> node = new Node<T>(data);

            if (head == null) { head = node; }
            else { tail.Next = node; node.Previous = tail; }
            tail = node;
            length++;
        }

        public bool Add(T data, int id)//Add to [id] place 
        {
            Node<T> node = new Node<T>(data);
            Node<T> current = head;
            int i = 0;
            if (id == 0)
            {
                node.Next = current;
                node.Previous = null;
                current.Previous = node;
                head = node;
                length++;
                return true;
            }
            if (id == length) { Add(data); return true; }
            if(id>0||id<length)
            {
                while (i < id)
                {
                    current = current.Next;
                    i++;
                }
                node.Previous = current.Previous;
                node.Next = current;
                current.Previous = node;
                node.Previous.Next = node;
                length++;
                return true;
            }
            return false;
        }

        public void Remove(T data)//Remove by data.
        {
            Node<T> current = head;
            while (!current.Data.Equals(data))
            {
                current = current.Next;
            }
            if (current.Previous == null)
            {
                current.Next.Previous = null;
            }
            if (current.Next == null)
            {
                current.Previous.Next = null;
            }
            else
            {
                current.Next.Previous = current.Previous;
                current.Previous.Next = current.Next;
            }
        }

        public bool Remove(int id)//Remove by id
        {
            Node<T> current = head;
            int i = 0;
            while (i < id)
            {
                current = current.Next;
                i++;
            }
            if (current.Previous == null)
            {
                current.Next.Previous = null;
                return true;
            }
            if (current.Next == null)
            {
                current.Previous.Next = null;
                return true;
            }
            if(current.Next!=null||current.Previous!=null)
            {
                current.Next.Previous = current.Previous;
                current.Previous.Next = current.Next;
                return true;
            }
            return false;
        }

        public void Edit(T data, T newData)//Edit with new data by old data;
        {
            Node<T> current = head;
            while (!current.Data.Equals(data))
            {
                current = current.Next;
            }
            current.Data = newData;
        }

        public void Edit(int id, T newData)//Edit with new data by id;
        {
            int i = 0;
            Node<T> current = head;
            while (i < id)
            {
                current = current.Next;
                i++;
            }
            current.Data = newData;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}
