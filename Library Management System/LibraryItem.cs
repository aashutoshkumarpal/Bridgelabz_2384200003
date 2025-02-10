using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    // Abstract class LibraryItem
    abstract class LibraryItem
    {
        private string itemId;
        private string title;
        private string author;
        private string borrower; // Encapsulation: Borrower details secured

        public string ItemId
        {
            get { return itemId; }
            private set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }

        public string Author
        {
            get { return author; }
            private set { author = value; }
        }

        public bool IsBorrowed
        {
            get { return borrower != null; }
        }

        public LibraryItem(string itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
            this.borrower = null;
        }

        public abstract int GetLoanDuration(); // Abstract method

        public virtual void GetItemDetails()
        {
            Console.WriteLine($"ID: {itemId}, Title: {title}, Author: {author}, Loan Duration: {GetLoanDuration()} days");
        }

        public void BorrowItem(string borrowerName)
        {
            if (!IsBorrowed)
            {
                borrower = borrowerName;
                Console.WriteLine($"{title} borrowed by {borrower}.");
            }
            else
            {
                Console.WriteLine($"{title} is currently borrowed.");
            }
        }

        public void ReturnItem()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"{title} returned by {borrower}.");
                borrower = null;
            }
            else
            {
                Console.WriteLine($"{title} is not borrowed.");
            }
        }
    }

    // Interface IReservable
    interface IReservable
    {
        void ReserveItem(string user);
        bool CheckAvailability();
    }

    // Book subclass (Loan duration: 14 days)
    class Book : LibraryItem, IReservable
    {
        private bool reserved = false;

        public Book(string itemId, string title, string author)
            : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 14; // Books can be borrowed for 14 days
        }

        public void ReserveItem(string user)
        {
            if (!reserved)
            {
                reserved = true;
                Console.WriteLine($"{Title} has been reserved by {user}.");
            }
            else
            {
                Console.WriteLine($"{Title} is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return !IsBorrowed && !reserved;
        }
    }

    // Magazine subclass (Loan duration: 7 days)
    class Magazine : LibraryItem
    {
        public Magazine(string itemId, string title, string author)
            : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 7; // Magazines can be borrowed for 7 days
        }
    }

    // DVD subclass (Loan duration: 3 days, Reservable)
    class DVD : LibraryItem, IReservable
    {
        private bool reserved = false;

        public DVD(string itemId, string title, string author)
            : base(itemId, title, author) { }

        public override int GetLoanDuration()
        {
            return 3; // DVDs can be borrowed for 3 days
        }

        public void ReserveItem(string user)
        {
            if (!reserved)
            {
                reserved = true;
                Console.WriteLine($"{Title} DVD has been reserved by {user}.");
            }
            else
            {
                Console.WriteLine($"{Title} DVD is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return !IsBorrowed && !reserved;
        }
    }
}
