using System;
using System.Collections.Generic;
using System.Text;

namespace Algo002
{
    class TesterList
    {
        public int Value;
        public int ExpectedValue;
        public Exception ExpectedException;

        public void TestAddNode(MaLinkedList MaList001, int Value001, int ExpectedValue001, Exception ExpectedException001)
        {
            MaList001.AddNode(Value001);

            TestFind(MaList001, Value001, ExpectedValue001, ExpectedException001, true);
        }

        public void TestAddNodeAfter(MaLinkedList MaList001, Node Node001, int Value001, int ExpectedValue001, Exception ExpectedException001)
        {
            MaList001.AddNodeAfter(Node001, Value001);

            TestFind(MaList001, Value001, ExpectedValue001, ExpectedException001, true);
        }

        public void TestFindNode(MaLinkedList MaList001, int Value001, int ExpectedValue001, Exception ExpectedException001)
        {
            TestFind(MaList001, Value001, ExpectedValue001, ExpectedException001, true);
        }

        public void TestGetCount(MaLinkedList MaList001, int ExpectedValue001, Exception ExpectedException001)
        {
            TestFind(MaList001, MaList001.GetCount(), ExpectedValue001, ExpectedException001, true);
        }

        public void TestRemoveNode(MaLinkedList MaList001, int Index001, int Value001, int ExpectedValue001, Exception ExpectedException001)
        {
            MaList001.RemoveNode(Index001);
            TestFind(MaList001, Value001, ExpectedValue001, ExpectedException001, false);
        }

        public void TestRemoveNode(MaLinkedList MaList001, Node Node001, int ExpectedValue001, Exception ExpectedException001)
        {
            MaList001.RemoveNode(Node001);
            TestFind(MaList001, Node001.Value, ExpectedValue001, ExpectedException001, false);
        }




        //Проверка на наличие элемента в списке
        void TestFind(MaLinkedList MaList002, int Value002, int ExpectedValue002, Exception ExpectedException002, bool ResultCompare001)
        {
            if (ResultCompare001)
            {
                try
                {
                    UtTestEventus(MaList002.FindNode(Value002).Value == ExpectedValue002);
                }
                catch (Exception Ex001)
                {
                    UtTestEventus(Ex001 == ExpectedException002);
                }
            }
            else
            {
                try
                {
                    UtTestEventus(MaList002.FindNode(Value002).Value != ExpectedValue002);
                }
                catch (NullReferenceException)
                {
                    UtTestEventus(true);
                }
            }
        }
        //Получить результат теста
        void UtTestEventus(bool Value001)
        {
            if (Value001)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
        }
    }
}