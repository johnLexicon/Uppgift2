using System;
using Xunit;
using static Uppgift2.Console.Program;

namespace tests
{
    public class MenuOption1Should
    {
        [Fact]
        public void GetTicketPriceInfoForYoungAdult()
        {
            //Given
            int age = 19;
            //When
            (string TicketType, double Price) sut = GetTicketPriceInfo(age);
            //Then
            Assert.Equal("Young adult", sut.TicketType);
            Assert.Equal(80, sut.Price);
        }

        [Fact]
        public void GetTicketPriceInfoForMiddleAge()
        {
            //Given
            int age = 20;
            //When
            (string TicketType, double Price) sut = GetTicketPriceInfo(age);
            //Then
            Assert.Equal("Standard", sut.TicketType);
            Assert.Equal(120, sut.Price);
        }

        [Fact]
        public void GetTicketPriceInfoForSeniors()
        {
            //Given
            int age = 65;
            //When
            (string TicketType, double Price) sut = GetTicketPriceInfo(age);
            //Then
            Assert.Equal("Senior", sut.TicketType);
            Assert.Equal(90, sut.Price);
        }
    }
}
