using System;

namespace OOPHomework
{
    public class Book
    {
        private int pages;

        public string Title { get; set; }
        public string Author { get; set; }

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Pages),
                        "Pages must be greater than 0."
                    );
                }

                pages = value;
            }
        }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public string Info()
        {
            return $"{Title} by {Author}, {Pages} pages";
        }
    }
}