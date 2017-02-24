function solve(){
    var Item,
        Book;

    return {
        getBook: function (name, isbn, genre, description) {
            //return a book instance
            let newBook = new Book(name, description, isbn, genre);
            return newBook;
        },
        getMedia: function (name, rating, duration, description) {
            //return a media instance
        }
        getBookCatalog: function (name) {
            //return a book catalog instance
        },
        getMediaCatalog: function (name) {
            //return a media catalog instance
        }
    };

    Item = (function(Parent){
        var lastId = 0;
        function Item(description, name) {
            this.id = lastId += 1;
            this.description = description;
            this.name = name;
        }
        Item.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Item.prototype, '_id', {
            get: function() {
                return this.id;
            }
        });

        Object.defineProperty(Item.prototype, '_description', {
            get: function() {
                return this.description;
            },
            set: function(d) {
                this.description = d;
            }
        });

        Object.defineProperty(Item.prototype, '_name', {
            get: function() {
                return this.name;
            },
            set: function (n) {
                this.name = n;
            }
        });

        return Item;
    })(function(){});

    Book = (function(Parent){
        function Book(description, name, isbn, genre) {
            Parent.call(this, description, name);

            this.isbn = isbn;
            this.genre = genre;
        }
        Book.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Book.prototype, '_isbn', {
            get: function() {
                return this.isbn;
            },
            set: function (i) {
                this.isbn = i;
            }
        });

        Object.defineProperty(Book.prototype, '_genre', {
            get: function() {
                return this.genre;
            },
            set: function(g) {
                this.genre = g;
            }
        });

        return Book;
    })(Item);
}

var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);

console.log(catalog.find(book1.id));
//returns book1

console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

console.log(catalog.search('js')); 
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'))
//returns []
