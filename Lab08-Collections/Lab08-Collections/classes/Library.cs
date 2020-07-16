using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        /// <returns>new bookshelf length based off of new book array length</returns>
        public void RemoveBook(int bookIndex)
        {
            // should we get rid of the array?
            // minimize the number of if checks?

            T[] newArray = new T[bookshelf.Length - 1];

            T[] temp;

            // it doesn't allow for multiple books (??)
            // Every time we remove a book, it's going to resize the array. 
            // ammorized efficiency 
            // What if the book doesn't exist? Error Handling?
            // continue? why is that here?
            // Book count decrament?

            // if count is less than half, then resize the array. 
            if (bookCount < (bookshelf.Length / 2))
            {
                // reize the array to something much smaller and efficient
                temp = new T[bookCount - 1];
            }
            else
            {
                temp = new T[bookshelf.Length];
            }


            // we need to do the transfer

            for (int i = 0; i < bookCount; i++)
            {
                if (i < bookIndex)
                {
                    newArray[i] = bookshelf[i];
                    bookCount--;
                }
                else if (i == bookIndex)
                {
                    continue;
                }
                else
                {
                    newArray[i - 1] = bookshelf[i];
                }
            }
            bookshelf = temp;
        }

        public int CountBooks()
        {
            return bookCount;
        }
        //below allows the IEnumerable to operate, specifically calls for the IEnumerator
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < bookCount; i++)
            {
                yield return bookshelf[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
