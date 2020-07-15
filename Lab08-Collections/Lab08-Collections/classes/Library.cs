using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab08_Collections
{
    public class Library<T> : IEnumerable
    {
        T[] bookshelf = new T[6];
        int bookCount = 0;
        /// <summary>
        /// The below method adds a new item space to the total book list (bookshelf)
        /// </summary>
        /// <param name="newBook">The item added to the bookshelf list</param>
        public void AddBook(T newBook)
        {
            if (bookCount == bookshelf.Length)
            {
                Array.Resize(ref bookshelf, bookshelf.Length * 2);
            }
            bookshelf[bookCount++] = newBook;
        }
        /// <summary>
        /// The below method removes an item from the bookshelf list
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public T RemoveBook(T item)
        {
            int quarter = bookCount - 1;
            int tempCount = 0;
            T[] temp;
            T removedBook = default(T);

            if (item = true)
            {
                if (bookCount < bookshelf.Length / 2)
                {
                    temp = new T[quarter];
                }
                else
                {
                    temp = new T[bookshelf.Length];
                }
                for (int i = 0; i < bookCount; i++)
                {
                    if(bookshelf[i] != null)
                    {
                        tempCount++;
                    }
                    else
                    {
                        removedBook = bookshelf[i];
                    }
                }
            bookshelf = temp;
            tempCount--;
            }
        return removedBook; 
        }
        
        public int Count()
        {
            return bookCount;
        }
    }

   

    
}
