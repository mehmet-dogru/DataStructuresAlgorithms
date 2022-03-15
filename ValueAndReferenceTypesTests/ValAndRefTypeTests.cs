using System;
using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndReferenceTypesTests
{
    public class ValAndRefTypeTests
    {
        [Fact]
        public void RefTypeTest()
        {
            //Arrange - D�zenleme
            var p1 = new RefType
            {
                X=10,
                Y=20
            };
            var p2 = p1;

            //Act - Eylem
            p1.X = 30;

            //Assert - �ddia/Sonu�
            Assert.Equal(p1.X, p2.X);
        }
        [Fact]
        public void ValTypeTest()
        {
            //Arrange - D�zenleme
            var p1 = new ValueAndReferenceTypes.ValueType
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            //Act - Eylem
            p1.X = 30;

            //Assert - �ddia/Sonu�
            Assert.NotEqual(p1.X, p2.X);
        }

        [Fact]
        public void RecordTypeTest()
        {
            //Arrange
            var p1 = new RecordType(3,5);

            //Act
            var p2 = new RecordType(3, 5);

            //Assert
            Assert.Equal(p1, p2); // referanslar� farkl� yaln�z de�erleri e�it.
        }

        [Fact]
        public void SwapByVal()
        {
            //Arrange 
            int a = 42, b = 55;
            var valType = new ValueAndReferenceTypes.ValueType();
            
            //Act
            valType.Swap(a, b);

            //Assert
            Assert.Equal(42,a);
            Assert.Equal(55,b);

            //De�er tipli oldu�u i�in Swap scopeunda de�i�iklikler kal�r globale uygulanmaz
        }

        [Fact]
        public void SwapByRef()
        {
            //Arrange 
            int a = 42, b = 55;
            var refType = new RefType();

            //Act
            refType.Swap(ref a, ref b);

            //Referans de�erini de�i�tirdi�imiz i�in yap�lan de�i�iklik globale uygulan�r.

            //Assert
            Assert.Equal(42, b);
            Assert.Equal(55, a);
        }

        [Fact]
        public void CheckOutKeyword()
        {
            //Arrange
            var refType = new RefType();
            int b = 50;

            //act
            refType.CheckOut(out b);

            //Assert
            Assert.Equal(100, b);
        }
    }
}
