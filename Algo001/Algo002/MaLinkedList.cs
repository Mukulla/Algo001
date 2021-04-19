using System;
using System.Collections.Generic;
using System.Text;

namespace Algo002
{
    class MaLinkedList : ILinkedList
    {
        //Общее количество элементов
        int TotalCount;
        //Итератор
        int Iterator;

        //Текущий элемент
        Node CurrentElement;

        //Первый элемент списка
        Node Start;
        //Последний элемент списка
        Node End;

        public void AddNode(int value)
        {
            Node TempoNode = new Node();
            TempoNode.Value = value;
            {
                Value = value
                NextNode = null
                PrevNode = End;
            };
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public Node FindNode(int searchValue)
        {
            Node TempoIterator = Start;
            bool Finded = false;

            while (TempoIterator != End)
            {                
                if(TempoIterator.Value == searchValue)
                {
                    Finded = true;
                    break;
                }
                TempoIterator = TempoIterator.NextNode;
            }

            if(!Finded)
            {
                return null;
            }

            return TempoIterator;
        }

        public int GetCount()
        {
            return TotalCount;
        }

        public void RemoveNode(int Index)
        {
            if(!Checker(Index))
            {
                return;
            }

            Node Previous = Start;
            Node TempoIterator = Start;

            for (int i = 0; i < Index; ++i)
            {
                Previous = TempoIterator;
                TempoIterator = TempoIterator.NextNode;
            }

            Previous.NextNode = TempoIterator.NextNode;
        }

        public void RemoveNode(Node node)
        {
            Node Previous = Start;
            Node TempoIterator = Start;

            while (TempoIterator != End)
            {
                if (TempoIterator == node)
                {
                    Previous.NextNode = TempoIterator.NextNode;
                }
                Previous = TempoIterator;
                TempoIterator = TempoIterator.NextNode;
            }
        }

        bool Checker(int SomeIndex)
        {
            if(SomeIndex >= 0)
            {
                if(SomeIndex < TotalCount)
                {
                    return true;
                }
            }
            return false;
        }

        Node GetNodeByIndex(int SomeIndex)
        {
            Node Returner = Start;
            for (int i = 0; i < SomeIndex; ++i)
            {
                Returner = Returner.NextNode;
            }

            return Returner;
        }
    }
}
