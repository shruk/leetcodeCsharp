using System;

namespace leetcodeCsharp.Util
{
        public class Node<T>where T:IComparable{
        public T data;
        public Node<T> next;

        public Node():this(default(T)){}
        public Node(T value){
            data=value;
        }
    }

}