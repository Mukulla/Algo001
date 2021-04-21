using System;
using System.Collections.Generic;
using System.Text;

namespace Algo002
{
    class MaLinkedList : ILinkedList
    {
        //Общее количество элементов
        int TotalCount = 0;        

        //Первый элемент списка
        Node Start = new Node();
        //Последний элемент списка
        Node End = new Node();

        public void AddNode(int value)
        {
            

            if (TotalCount < 1)
            {
                Start.Value = value;
                End.Value = value;

                Start.NextNode = End;
                Start.PrevNode = null;

                End.NextNode = null;
                End.PrevNode = Start;

                ++TotalCount;
            }
            else
            {
                Node TempoNode = new Node();
                TempoNode.Value = value;
                TempoNode.PrevNode = null;
                TempoNode.NextNode = null;

                End.NextNode = TempoNode;
                TempoNode.PrevNode = End;

                End = TempoNode;

                ++TotalCount;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            Node Previous = Start;
            Node TempoIterator = Start;

            while (TempoIterator != null)
            {
                if (Previous == node)
                {
                    Node Node001 = new Node();
                    Node001.Value = value;

                    Node001.PrevNode = Previous;
                    Previous.NextNode = Node001;

                    Node001.NextNode = TempoIterator;
                    TempoIterator.PrevNode = Node001;
                    
                    ++TotalCount;
                    break;
                }

                Previous = TempoIterator;
                TempoIterator = TempoIterator.NextNode;
            }
        }

        public Node FindNode(int searchValue)
        {
            Node TempoIterator = Start;
            bool Finded = false;

            while (TempoIterator != null)
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

            while (TempoIterator != null)
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
    }
}
