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
        public Node NextNode;
        public Node PrevNode;
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
            throw new NotImplementedException();
        }

        public void PopDown()
        {
            throw new NotImplementedException();
        }

        public void PopUp()
        {
            throw new NotImplementedException();
        }

        public void PopValue(T Value001)
        {
            throw new NotImplementedException();
        }



        public void Push(int Index, T Value001)
        {
            throw new NotImplementedException();
        }

        public void PushDown(T Value001)
        {
            throw new NotImplementedException();
        }

        public void PushUp(T Value001)
        {
            throw new NotImplementedException();
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
    }
}
