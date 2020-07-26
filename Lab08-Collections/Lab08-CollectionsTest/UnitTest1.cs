using Lab08_Collections;
using System;
using Xunit;

namespace Lab08_CollectionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddBook()
        {
            //Arrange
            Library<Book> library = new Library<Book>();

            //Act
            Book test = new Book() { Title = "1984", Author = new Author() { FirstName = "George", LastName = "Orwell" }, Genre = Genre.Politics };

            library.AddBook(test);
            //Assert
            Assert.Equal((System.Collections.Generic.IEnumerable<char>)test, Library.Count());
        }
    }
}
