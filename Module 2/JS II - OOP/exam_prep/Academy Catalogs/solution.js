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

        function _validateThat_stringIsFrom2To40CharsLongIncl(str) {
            if (!str || typeof str !== 'string' || str.length < 2 || str.length > 40) {
                throw new Error(str + ' is not a string from 2 to 40 characters long!');
            }
        }

        function _validateThat_stringIsEither10Or13CharsLong(str) {
            if (!str || typeof str !== 'string' || (str.length !== 10 && str.length !== 13)) {
                throw new Error(str + ' is not a string either 10 or 13 characters long!');
            }
        }

        function _validateThat_stringContainsDigitsOnly(str) {
            if (!str || typeof str !== 'string' || !/[0-9]/.test(str)) {
                throw new Error(str + ' is not a string containing digits only!');
            }
        }

        function _validateThat_stringIsFrom2To20CharsLongIncl(str) {
            if (!str || typeof str !== 'string' || str.length < 2 || str.length > 20) {
                throw new Error(str + ' is not a string from 2 to 20 characters long!');
            }
        }

        function _validateThat_numberIsGreaterThanZero(num) {
            if (!num || typeof num !== 'number' || num < 0) {
                throw new Error(num + ' is not a number greater than zero!');
            }
        }

        function _validateThat_numberIsBetween1And5Incl(num) {
            if (!num || typeof num !== 'number' || num < 1 || num > 5) {
                throw new Error(num + ' is not a number between 1 and 5!');
            }
        }

        function _validateThat_itemOrItemsAreValid(itemOrItems) {
            if (!itemOrItems) {
                throw new Error('Missing item(s)!');
            }
        }

        function _validateThat_bookOrBooksArrayAreValid(bookOrBooksArray) {
            if (!bookOrBooksArray) {
                throw new Error('Missing book(s)!');
            }
        }

        return {
            validateThat_StringIsNotEmpty: function(str) {
                _validateThat_StringIsNotEmpty(str);
            },
            validateThat_stringIsFrom2To40CharsLongIncl: function(str) {
                _validateThat_stringIsFrom2To40CharsLongIncl(str);
            },
            validateThat_stringIsEither10Or13CharsLong: function(str) {
                _validateThat_stringIsEither10Or13CharsLong(str);
            },
            validateThat_stringContainsDigitsOnly: function(str) {
                _validateThat_stringContainsDigitsOnly(str);
            },
            validateThat_stringIsFrom2To20CharsLongIncl: function(str) {
                _validateThat_stringIsFrom2To20CharsLongIncl(str);
            },
            validateThat_numberIsGreaterThanZero: function(num) {
                _validateThat_numberIsGreaterThanZero(num)
            },
            validateThat_numberIsBetween1And5Incl: function(num) {
                _validateThat_numberIsBetween1And5Incl(num);
            },
            validateThat_itemOrItemsAreValid: function(itemOrItems) {
                _validateThat_itemOrItemsAreValid(itemOrItems);
            },
            validateThat_bookOrBooksArrayAreValid: function(bookOrBooksArray) {
                _validateThat_bookOrBooksArrayAreValid(bookOrBooksArray);
            }
        };
    })();

    Item = (function(Parent){
        var lastId = 0;
        function Item(description, name) {
            this.id = lastId += 1;
            this.description = description;
            this.name = name;
        }
        Item.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Item.prototype, 'id', {
            get: function() {
                return this._id;
            },
            set: function(i) {
                this._id = i;
            }
        });

        Object.defineProperty(Item.prototype, 'description', {
            get: function() {
                return this._description;
            },
            set: function(d) {
                Validator.validateThat_stringIsFrom2To40CharsLongIncl(d);
                this._description = d;
            }
        });

        Object.defineProperty(Item.prototype, 'name', {
            get: function() {
                return this._name;
            },
            set: function (n) {
                Validator.validateThat_StringIsNotEmpty(n);
                this._name = n;
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

        Object.defineProperty(Book.prototype, 'isbn', {
            get: function() {
                return this._isbn;
            },
            set: function (i) {
                Validator.validateThat_stringIsEither10Or13CharsLong(i);
                Validator.validateThat_stringContainsDigitsOnly(i);
                this._isbn = i;
            }
        });

        Object.defineProperty(Book.prototype, 'genre', {
            get: function() {
                return this._genre;
            },
            set: function(g) {
                Validator.validateThat_stringIsFrom2To20CharsLongIncl(g);
                this._genre = g;
            }
        });

        return Book;
    })(Item);

    Media = (function(Parent) {
        function Media(description, name, duration, rating) {
            Parent.call(this, description, name);

            this.duration = duration;
            this.rating = rating;
        }
        Media.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Media.prototype, 'duration', {
            get: function() {
                return this._duration;
            },
            set: function(d) {
                Validator.validateThat_numberIsGreaterThanZero(d);
                this._duration = d;
            }
        });

        Object.defineProperty(Media.prototype, 'rating', {
            get: function() {
                return this._rating;
            },
            set: function(r) {
                Validator.validateThat_numberIsBetween1And5Incl(r);
                this._rating = r;
            }
        });

        return Media;
    })(Item);

    Catalog = (function(Parent) {
        function Catalog(name, items) {
            Parent.call(this, 'catalog', name);

            this.items = items;
        }
        Catalog.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Catalog.prototype, 'items', {
            get: function() {
                return this._items;
            },
            set: function(i) {                
                this._items = i;
            }   
        });
        Catalog.prototype.add = function(itemOrItems) {
            // TODO - Complete method definition
            if (!arguments) {
                throw new Error('Cannot add missing item(s)!');
            }
            Validator.validateThat_itemOrItemsAreValid(itemOrItems);
            this._items.push(itemOrItems);
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
            if (!arguments) {
                throw new Error('Cannot add missing book(s)!');
            }
            Validator.validateThat_bookOrBooksArrayAreValid(bookOrBooksArray);
            this._items.push(bookOrBooksArray);
            return this;
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
// catalog.add(); // missing parameter NOK, Expect throw
// catalog.add(null); // null param NOK, Expect throw
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
