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
            //Arrange - Düzenleme
            var p1 = new RefType
            {
                X=10,
                Y=20
            };
            var p2 = p1;

            //Act - Eylem
            p1.X = 30;

            //Assert - Ýddia/Sonuç
            Assert.Equal(p1.X, p2.X);
        }
        [Fact]
        public void ValTypeTest()
        {
            //Arrange - Düzenleme
            var p1 = new ValueAndReferenceTypes.ValueType
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            //Act - Eylem
            p1.X = 30;

            //Assert - Ýddia/Sonuç
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
            Assert.Equal(p1, p2); // referanslarý farklý yalnýz deðerleri eþit.
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

            //Deðer tipli olduðu için Swap scopeunda deðiþiklikler kalýr globale uygulanmaz
        }

        [Fact]
        public void SwapByRef()
        {
            //Arrange 
            int a = 42, b = 55;
            var refType = new RefType();

            //Act
            refType.Swap(ref a, ref b);

            //Referans deðerini deðiþtirdiðimiz için yapýlan deðiþiklik globale uygulanýr.

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
