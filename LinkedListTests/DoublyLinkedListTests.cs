using LinkedList.DoblyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LinkedListTests
{
    public class DoublyLinkedListTests
    {
        private DoublyLinkedList<char> _list;
        public DoublyLinkedListTests()
        {
            _list = new DoublyLinkedList<char>(new char[] { 'a', 'z' });
        }

        [Theory]
        [InlineData('f')]
        [InlineData('e')]
        [InlineData('r')]
        public void AddFirst_Test(char value)
        {
            //Act
            _list.AddFirst(value);

            //Assert
            Assert.Equal(value, _list.Head.Value);
        }
    }
}
