using System;
using System.Collections.Generic;
using System.Text;

namespace Algo002
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }

    public interface ILinkedList
    {
        //Количество эелементов
        int GetCount();
        //Добавить элемент
        void AddNode(int value);
        //Добавить элемент после индекса
        void AddNodeAfter(Node node, int value);
        //Удалить элемент по индексу
        void RemoveNode(int index);
        //Удалить совпавший элемент
        void RemoveNode(Node node);
        //Найти элемент по значению
        Node FindNode(int searchValue);
    }
}
