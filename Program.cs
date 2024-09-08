using System;
using System.Dynamic;

namespace DoublyLinkedList{

    class Node<T> {
         T _value;
         Node<T>  _prev;
         Node<T> _next;

        public Node(T value){
            _value = value;
            _prev = null;
            _next = null;
        }

        public Node<T> Prev {
            get { return _prev; }
            set { _prev = value; }
        }

        public Node<T> Next {
            get { return _next;}
            set { _next = value;}
        }

        public T value {
            get { return _value;}
        }
    } //node

    class LinkedList<T>{
        Node<T> _head;
        Node<T> _tail;

        public LinkedList(){
            this._head = null;
            this._tail = null;
        }

        public void AddFirst(T value){
            Node<T> newNode = new Node<T>(value);

            if (_head == null){
                _head = _tail = newNode;

            } else {
                newNode.Next = _head;
                _head.Prev = newNode;
                _head = newNode;

            }
            Console.WriteLine("a node has been added");
        }

        public void RemoveFirst(){
            if(_head == null){
                Console.WriteLine("list is already empty");
            } else if (_head == _tail){
                _head = _tail = null;
                Console.WriteLine("head and tail are empty");
            } else {
                _head = _head.Next;
                _head.Prev = null;
                Console.WriteLine("first node has been removed");
            }
        }

        public void AddLast (T value){
            Node<T> newNode = new Node<T>(value);
            if(_head == _tail){
                _head = _tail = newNode;
                Console.WriteLine($"new node [{newNode.value}] has been added");
            }
            else{
                newNode.Prev =_tail; //node sebelum new node, dijadikan sebagai tail
                _tail.Next = newNode;//setelah itu, new node dijadikan sebagai next dari tail
                _tail = newNode;// selanjutnya, new node dijadikan sebagai tail
                Console.WriteLine("new node has been added");
            }
        }

        public void ShowAll(){
            if (_head == _tail){
                Console.WriteLine("list is still empty");
            }
        }
    } //linked list
    class Program{
        public static void Main (string[] args){
            LinkedList<int> LL = new LinkedList<int>();
            LL.AddFirst(1);
            LL.AddLast(2);
        }
    }//program
} //namespace

