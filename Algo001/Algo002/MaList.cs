using System;
using System.Collections.Generic;
using System.Text;

namespace Algo002
{
    public interface ILinkedList001<T>
    {
        //Добавить элемент
        void Push(int Index, T Value001);
        void PushUp(T Value001);
        void PushDown(T Value001);

        //Удалить элемент после индекса
        void Pop(int Index);
        void PopValue(T Value001);
        void PopUp();
        void PopDown();

        //Получить эелемент по индексу
        int Get(int Index);
        //Получить номер элемента
        T Find(T Value001);

        //Количество эелементов
        int GetCount();
    }

    class MaElement<T>
    {
        public T Value;
        public MaElement<T> NextNode;
        public MaElement<T> PrevNode;
    }

    class MaList<T> : ILinkedList001<T>
    {
        //Общее количество элементов
        int TotalCount = 0;

        //Первый элемент списка
        MaElement<T> Start = new MaElement<T>();
        //Последний элемент списка
        MaElement<T> End = new MaElement<T>();

        public void Pop(int Index)
        {
            if (!Checker(Index))
            {
                return;
            }

            MaElement<T> TempoIterator = Start;
            for (int i = 0; i < Index; ++i)
            {
                TempoIterator = TempoIterator.NextNode;
            }

            TempoIterator.PrevNode.NextNode = TempoIterator.NextNode;
            TempoIterator.NextNode.PrevNode = TempoIterator.PrevNode;
        }

        public void PopDown()
        {
            End = End.PrevNode;
            End.NextNode = null;
        }

        public void PopUp()
        {
            Start = Start.NextNode;
            Start.PrevNode = null;
        }

        public void PopValue(T Value001)
        {            
            MaElement<T> TempoIterator = Start;

            while (TempoIterator != null)
            {
                /*if (TempoIterator.Value == Value001 )
                {
                } */              
                TempoIterator = TempoIterator.NextNode;
            }
        }



        public void Push(int Index, T Value001)
        {
            if (!Checker(Index))
            {
                return;
            }

            MaElement<T> TempoIterator = Start;
            for (int i = 0; i < Index; ++i)
            {
                TempoIterator = TempoIterator.NextNode;
            }

            MaElement<T> TempoNode = new MaElement<T>();
            TempoNode.Value = Value001;

            TempoNode.PrevNode = TempoIterator;
            TempoNode.NextNode = TempoIterator.NextNode;

            TempoIterator.NextNode = TempoNode;
        }

        public void PushDown(T Value001)
        {
            if (TotalCount == 0)
            {
                Start.Value = Value001;
                Start.NextNode = null;
                Start.PrevNode = null;

                ++TotalCount;
                return;
            }
            if (TotalCount == 1)
            {
                Start.NextNode = End;
                Start.PrevNode = null;

                End.Value = Value001;
                End.NextNode = null;
                End.PrevNode = Start;

                ++TotalCount;
                return;
            }
            if (TotalCount > 1)
            {
                MaElement<T> TempoNode = new MaElement<T>();
                TempoNode.Value = Value001;
                TempoNode.PrevNode = null;
                TempoNode.NextNode = null;

                End.NextNode = TempoNode;
                TempoNode.PrevNode = End;

                End = TempoNode;

                ++TotalCount;
                return;
            }
        }

        public void PushUp(T Value001)
        {
            if (TotalCount == 0)
            {
                Start.Value = Value001;
                Start.NextNode = null;
                Start.PrevNode = null;

                ++TotalCount;
                return;
            }
            if (TotalCount == 1)
            {
                Start.NextNode = End;
                Start.PrevNode = null;

                End.Value = Value001;
                End.NextNode = null;
                End.PrevNode = Start;

                ++TotalCount;
                return;
            }
            if (TotalCount > 1)
            {
                MaElement<T> TempoNode = new MaElement<T>();
                TempoNode.Value = Value001;
                TempoNode.PrevNode = null;
                TempoNode.NextNode = null;

                Start.NextNode = TempoNode;
                TempoNode.PrevNode = Start;

                Start = TempoNode;

                ++TotalCount;
                return;
            }
        }



        public T Find(T Value001)
        {
            throw new NotImplementedException();
        }

        public int Get(int Index)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            return TotalCount;
        }



        bool Checker(int SomeIndex)
        {
            if (SomeIndex >= 0)
            {
                if (SomeIndex < TotalCount)
                {
                    return true;
                }
            }
            return false;
        }

        bool Compare<T>(T x, T y) where T : class
        {
            return x == y;
        }

        bool Compare<T>(T x, T y) where T : Type
        {
            return x == y;
        }
    }
}