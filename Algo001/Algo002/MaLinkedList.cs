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
<<<<<<< HEAD
<<<<<<< HEAD
            

            if (TotalCount < 1)
            {
                Start.Value = value;
                End.Value = value;

                Start.NextNode = End;
                Start.PrevNode = null;

=======
            if (TotalCount == 0)
=======
            

            if (TotalCount < 1)
>>>>>>> parent of fbd803a (DZ Done)
            {
                Start.Value = value;
                End.Value = value;

                Start.NextNode = End;
                Start.PrevNode = null;

<<<<<<< HEAD
                End.Value = value;
>>>>>>> parent of 936ac31 (Deleted)
=======
>>>>>>> parent of fbd803a (DZ Done)
                End.NextNode = null;
                End.PrevNode = Start;

                ++TotalCount;
<<<<<<< HEAD
<<<<<<< HEAD
            }
            else
=======
                return;
            }
            if(TotalCount > 1)
>>>>>>> parent of 936ac31 (Deleted)
=======
            }
            else
>>>>>>> parent of fbd803a (DZ Done)
            {
                Node TempoNode = new Node();
                TempoNode.Value = value;
                TempoNode.PrevNode = null;
                TempoNode.NextNode = null;

                End.NextNode = TempoNode;
                TempoNode.PrevNode = End;

                End = TempoNode;

                ++TotalCount;
<<<<<<< HEAD
<<<<<<< HEAD
=======
                return;
>>>>>>> parent of 936ac31 (Deleted)
=======
>>>>>>> parent of fbd803a (DZ Done)
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
<<<<<<< HEAD
<<<<<<< HEAD

            Node Previous = Start;
            Node TempoIterator = Start;

            for (int i = 0; i < Index; ++i)
            {
                Previous = TempoIterator;
                TempoIterator = TempoIterator.NextNode;
            }

            Previous.NextNode = TempoIterator.NextNode;
=======
           
=======

            Node Previous = Start;
>>>>>>> parent of fbd803a (DZ Done)
            Node TempoIterator = Start;

            for (int i = 0; i < Index; ++i)
            {
                Previous = TempoIterator;
                TempoIterator = TempoIterator.NextNode;
            }

<<<<<<< HEAD
            TempoIterator.PrevNode.NextNode = TempoIterator.NextNode;
            TempoIterator.NextNode.PrevNode = TempoIterator.PrevNode;
>>>>>>> parent of 936ac31 (Deleted)
=======
            Previous.NextNode = TempoIterator.NextNode;
>>>>>>> parent of fbd803a (DZ Done)
        }

        public void RemoveNode(Node node)
        {
            Node Previous = Start;
            Node TempoIterator = Start;

            while (TempoIterator != null)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                if (TempoIterator == node)
=======
                if (TempoIterator.Value == node.Value)
>>>>>>> parent of 936ac31 (Deleted)
=======
                if (TempoIterator == node)
>>>>>>> parent of fbd803a (DZ Done)
                {
                    Previous.NextNode = TempoIterator.NextNode;
                }
                Previous = TempoIterator;
                TempoIterator = TempoIterator.NextNode;
            }
        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
        /*
        public void Show()
        {
            Node TempoIterator = Start;

            while (TempoIterator != null)
            {
                Console.WriteLine(TempoIterator.Value);
                TempoIterator = TempoIterator.NextNode;
            }
        }*/
>>>>>>> parent of 936ac31 (Deleted)
=======
>>>>>>> parent of fbd803a (DZ Done)

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
