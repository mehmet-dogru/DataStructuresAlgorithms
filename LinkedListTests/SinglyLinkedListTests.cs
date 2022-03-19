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
    }
}
