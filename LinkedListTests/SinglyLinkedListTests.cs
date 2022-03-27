using DataStructures.LinkedList.SinglyLinkedList;
using System;
using Xunit;

namespace LinkedListTests
{
    public class SinglyLinkedListTests
    {
        private SinglyLinkedList<int> _list;
        public SinglyLinkedListTests()
        {
            _list = new SinglyLinkedList<int>(new int[] { 6, 8 });
        }
        [Fact]
        public void Count_Test()
        {
            //Act
            int count = _list.Count;

            //Assert
            Assert.Equal(2, count);
        }
        
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(12)]
        [InlineData(42)]
        public void AddFirst_Test(int value)
        {
            //Act
            _list.AddFirst(value);

            //Assert
            Assert.Equal(value, _list.Head.Value);
        }

        [Theory]
        [InlineData(2)]
        public void AddLast_Test(int value)
        {
            //Act
            _list.AddLast(value);

            //Assert
            Assert.Collection(_list, 
                item => Assert.Equal(8,item),
                item => Assert.Equal(6,item),
                item => Assert.Equal(value,item)
                );
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(12)]
        [InlineData(42)]
        public void AddBefore_Test(int value)
        {
            //Act
            _list.AddBefore(_list.Head.Next, value);

            //Assert
            Assert.Collection(_list,
                    item => Assert.Equal(8, item),
                    item => Assert.Equal(value, item),
                     item => Assert.Equal(6, item));
        }

        [Fact]
        public void AddBefore_ArgumentException()
        {
            //Act
            var node = new SinglyLinkedListNode<int>(55);

            //Assert
            Assert.Throws<ArgumentException>(() => _list.AddBefore(node, 45));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(12)]
        [InlineData(42)]
        public void AddAfter_Test(int value)
        {
            //8 [value] 6 
            //Act
            _list.AddAfter(_list.Head, value);

            //Assert
            Assert.Collection(_list, 
               item => Assert.Equal(8,item),
               item => Assert.Equal(value,item),
               item => Assert.Equal(6,item));
        }

        [Fact]
        public void AddAfter_ArgumentException()
        {
            //Act
            var node = new SinglyLinkedListNode<int>(55);

            //Assert
            Assert.Throws<ArgumentException>(() => _list.AddAfter(node, 45));
        }

        [Fact]
        public void RemoveFirst_Test()
        {
            // 8 6
            //Act
            _list.RemoveFirst();

            //Assert
            Assert.Collection(_list, item => Assert.Equal(6, item));
        }

        [Fact]
        public void GetEnumerator_Test()
        {
            //Assert 
            Assert.Collection(_list,
                item => Assert.Equal(item, 8),
                item => Assert.Equal(item, 6)
                );
        }
    }
}
