using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node<T>
    {
       public Node(T data) { Data = data; }
       public T Data { get; set; }
       public Node<T> Previous { get; set; }
       public Node<T> Next { get; set; }
    }
}
