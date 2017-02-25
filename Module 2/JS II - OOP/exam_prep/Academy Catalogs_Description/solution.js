function solve(){
    var Validator,
        Item,
        Book,
        Media,
        Catalog,
        BookCatalog,
        MediaCatalog;

    Validator = (function(Parent) {
        function _validateThat_StringIsNotEmpty(str) {
            if (!str || typeof str !== 'string') {
                throw new Error(str + ' is not a non-empty string!');
            }
        }

        function _validateThat_StringIsBetween2And40CharactersLong(str) {
            if (!str || typeof str !== 'string' || str.length < 2 || str.length > 40) {
                throw new Error(str + ' is not a string between 2 and 40 characters long!');
            }
        }

        return {
            validateThat_StringIsNotEmpty: function(str) {
                _validateThat_StringIsNotEmpty(str);
            },
            validateThat_StringIsBetween2And40CharactersLong: function(str) {
                _validateThat_StringIsBetween2And40CharactersLong(str);
            }
        };
    })();

    Item = (function(Parent){
        var lastId = 0;
        function Item(description, name) {
            this.Id = lastId += 1;
            this.Description = description;
            this.Name = name;
        }
        Item.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Item.prototype, 'Id', {
            get: function() {
                return this.id;
            },
            set: function(i) {
                this.id = i;
            }
        });

        Object.defineProperty(Item.prototype, 'Description', {
            get: function() {
                return this.description;
            },
            set: function(d) {
                Validator.validateThat_StringIsBetween2And40CharactersLong(d);
                this.description = d;
            }
        });

        Object.defineProperty(Item.prototype, 'Name', {
            get: function() {
                return this.name;
            },
            set: function (n) {
                Validator.validateThat_StringIsNotEmpty(n);
                this.name = n;
            }
        });

        return Item;
    })(function(){});

    Book = (function(Parent){
        function Book(description, name, isbn, genre) {
            Parent.call(this, description, name);

            this.Isbn = isbn;
            this.Genre = genre;
        }
        Book.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Book.prototype, 'Isbn', {
            get: function() {
                return this.isbn;
            },
            set: function (i) {
                this.isbn = i;
            }
        });

        Object.defineProperty(Book.prototype, 'Genre', {
            get: function() {
                return this.genre;
            },
            set: function(g) {
                this.genre = g;
            }
        });

        return Book;
    })(Item);

    Media = (function(Parent) {
        function Media(description, name, duration, rating) {
            Parent.call(this, description, name);

            this.Duration = duration;
            this.Rating = rating;
        }
        Media.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Media.prototype, 'Duration', {
            get: function() {
                return this.duration;
            },
            set: function(d) {
                this.duration = d;
            }
        });

        Object.defineProperty(Media.prototype, 'Rating', {
            get: function() {
                return this.rating;
            },
            set: function(r) {
                this.rating = r;
            }
        });

        return Media;
    })(Item);

    Catalog = (function(Parent) {
        function Catalog(name, items) {
            Parent.call(this, 'catalog', name);

            this.Items = items;
        }
        Catalog.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Catalog.prototype, 'Items', {
            get: function() {
                return this.items;
            },
            set: function(i) {
                this.items = i;
            }
        });

        Catalog.prototype.add = function(itemOrItems) {
            // TODO - Complete method definition
            return this;
        }

        Catalog.prototype.find = function(idOrOptions) {
            // TODO - Complete method definition
        }

        Catalog.prototype.search = function(pattern) {
            // TODO - Complete method definition
        }

        return Catalog;
    })(Item);

    BookCatalog = (function(Parent) {
        function BookCatalog(name, items) {
            Parent.call(this, name, items);
        }
        BookCatalog.prototype = Object.create(Parent.prototype);

        BookCatalog.prototype.add = function(bookOrBooksArray) {
            // TODO - Complete method definition
        }

        BookCatalog.prototype.getGenres = function() {
            // TODO - Complete method definition
        }

        BookCatalog.prototype.find = function(options) {
            // TODO - Complete method definition
        }

        return BookCatalog;
    })(Catalog);

    MediaCatalog = (function(Parent) {
        function MediaCatalog(name, items) {
            Parent.call(this, name, items);
        }
        MediaCatalog.prototype = Object.create(Parent.prototype);

        MediaCatalog.prototype.add = function(mediaOrMediaArray) {
            // TODO - Complete method definition
        }

        MediaCatalog.prototype.getTop = function(count) {
            // TODO - Complete method definition
        }

        MediaCatalog.prototype.getSortedByDuration = function() {
            // TODO - Complete method definition
        }

        return MediaCatalog;
    })(Catalog);

    return {
        getBook: function(name, isbn, genre, description) {
            //return a book instance
            let newBook = new Book(name, description, isbn, genre);
            return newBook;
        },
        getMedia: function(name, rating, duration, description) {
            //return a media instance
            let newMedia = new Media(name, rating, duration, description);
            return newMedia;
        },
        getBookCatalog: function(name) {
            //return a book catalog instance
            let newBookCatalog = new BookCatalog(name, []);
            return newBookCatalog;
        },
        getMediaCatalog: function(name) {
            //return a media catalog instance
            let newMediaCatalog = new MediaCatalog(name, []);
            return newMediaCatalog;
        }
    };
}

var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');
// var catalog = module.getBookCatalog('');
// var catalog = module.getBookCatalog();

// catalog.Name = ''; // empty string NOK Expect throw
// catalog.Name = null; // null NOK, Expect throw
// catalog.Name = 'valid_name'; // OK
// console.log(catalog);

// catalog.Description = ''; // empty string NOK, Expect throw
// catalog.Description = null; // null NOK
// catalog.Description = new Array(2).join( '*' ); // 1 char NOK, Expect throw
// catalog.Description = new Array(3).join( '*' ); // 2 chars OK
// catalog.Description = new Array(41).join( '*' ); // 40 chars OK
// catalog.Description = new Array(42).join( '*' ); // 41 chars OK

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);
console.log(catalog);

// console.log(catalog.find(book1.id));
//returns book1

// console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

// console.log(catalog.search('js')); 
// returns book2

// console.log(catalog.search('javascript'));
//returns book1 and book2

// console.log(catalog.search('Te sa zeleni'))
//returns []
