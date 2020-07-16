using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Drawing;
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
        /// <param name="book"></param>
        /// <returns></returns>
        public void RemoveBook(int bookIndex)
        {
            T[] newArray = new T[ bookCount - 1 ];
            
                for(int i = 0; i < bookCount; i++)
                {
                    if(i < bookIndex)
                    {
                        newArray[i] = bookshelf[i];
                    }
                    else if(i == bookIndex)
                    {
                    continue;
                    }
                    else
                    {
                        newArray[i - 1] = bookshelf[i];
                    }
                }
            bookshelf = newArray;
        }

        public int CountBooks()
        {
            return bookCount;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < bookCount; i++)
            {
                yield return bookshelf[i];
            }
        }
        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
