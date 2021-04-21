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


    public interface ILinkedList001
    {
        //Добавить элемент
        void Push(int Index, int Value001);
        void PushUp(int Value001);
        void PushDown(int Value001);

<<<<<<< HEAD
        //Удалить элемент
=======
        //Удалить элемент после индекса
>>>>>>> parent of 847b4a0 (MaList version)
        void Pop(int Index);
        void PopValue(int Value001);
        void PopUp();
        void PopDown();

        //Получить эелемент по индексу
        int Get(int Index);
        //Получить номер элемента
        int Find(int Value001);
        
        //Количество эелементов
        int GetCount();
    }
}
