/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		function validate(assertion, errorMessage) {
			if (assertion === true) {
				throw Error(errorMessage.toString());
			}
		}
	
		let errorMessages = {
			existingCategory: "it's OK", 
			existingISBN: "duplicate isbn", 
			existingTitle: "duplicate title", 
			titleTooShort: "book title too short",                 
			titleTooLong: "book title too long", 
			authorIsNullOrEmpty: "author is null or empty", 
			badISBN: "bad isbn", 
			categoryIsNullOrEmpty: "default_category (auto-generated)",
		};
	
		function getErrorMessage(assertion) {
			return errorMessages[assertion.toString()];
		}
		
        let books = [],
		    categories = [];
		
		function addBook(book) {
			let existingCategory = books && books.some(b => b.category && b.category === book.category),
			    existingISBN = book && books && books.some(b => b.isbn && b.isbn === book.isbn),
   			    existingTitle = book && books && books.some(b => b.title && b.title === book.title),
			    titleTooShort = book && book.title && book.title.length < 2,
			    titleTooLong = book && book.title && book.title.length > 100,
			    authorIsNullOrEmpty = !book.author || book.author.length === 0,
			    badISBN = book && book.isbn && !/[0-9]{10,13}/.test(book.isbn),
			    categoryIsNullOrEmpty = book && (!book.category || book.category.length === 0);

            validate(existingISBN, errorMessages.existingISBN);
            validate(existingTitle, errorMessages.existingTitle);
            validate(titleTooShort, errorMessages.titleTooShort);
            validate(titleTooLong, errorMessages.titleTooLong);
            validate(authorIsNullOrEmpty, errorMessages.authorIsNullOrEmpty);
            validate(badISBN, errorMessages.badISBN);

			if (categoryIsNullOrEmpty) {
				book.category = "default_category (auto-generated)";
			}

			book.ID = books.length + 1;
			books.push(book);

			if (!existingCategory) {
				categories.push(book.category);
			}
			
			return book;
		}

		function listBooks(preferred) {
		if (!books || books.length === 0) {
			return [];
		}

		let result = books.slice();

		if (preferred) {
			let categoryFound = books.some(b => b.hasOwnProperty('category') && b.category === preferred.category),
			    authorFound = books.some(b => b.hasOwnProperty('author') && b.author === preferred.author);

			if ((preferred.category && !categoryFound) || (preferred.author && !authorFound)) {
				return [];
			}
			
			if (preferred.hasOwnProperty('category') && categoryFound) {
				if (preferred.hasOwnProperty('author') && authorFound) {
					result = books.filter(b => b.category === preferred.category && b.author === preferred.author);
				}
				
				result = books.filter(b => b.category === preferred.category);
			}

			if (preferred.hasOwnProperty('author') && authorFound && !preferred.hasOwnProperty('category')) {
				result = books.filter(b => b.author === preferred.author);
			}
		}

		return result;
		}

		function listCategories() {
			return categories.slice();
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());

	return library;
}

module.exports = solve;
