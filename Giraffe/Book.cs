using System;

namespace Giraffe
{
	class Book
	{
		// These variables are called class attributes

		public string title;
		public string author;
		public int pages;


		public Book(string aTitle, string aAuthor, int aPages)
		{
			title = aTitle;
			author = aAuthor;
			pages = aPages;
			
		}

		public Book()
		{

		}
	}
}
