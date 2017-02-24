function solve(){
    var Item,
        Book,
        Media;

    return {
        getBook: function (name, isbn, genre, description) {
            //return a book instance
            let newBook = new Book(name, description, isbn, genre);
            return newBook;
        },
        getMedia: function (name, rating, duration, description) {
            //return a media instance
            let newMedia = new Media(name, rating, duration, description);
            return newMedia;
        },
        getBookCatalog: function (name) {
            //return a book catalog instance
            let newBookCatalog = new BookCatalog(name, []);
            return newBookCatalog;
        },
        getMediaCatalog: function (name) {
            //return a media catalog instance
            let newMediaCatalog = new MediaCatalog(name, []);
            return newMediaCatalog;
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

    Media = (function(Parent) {
        function Media(description, name, duration, rating) {
            Parent.call(this, description, name);

            this.duration = duration;
            this.rating = rating;
        }
        Media.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Media.prototype, '_duration', {
            get: function() {
                return this.duration;
            },
            set: function(d) {
                this.duration = d;
            }
        });

        Object.defineProperty(Media.prototype, '_rating', {
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
        var lastId = 0;
        function Catalog(name, items) {
            this.id = lastId += 1;
            this.name = name;
            this.items = items;
        }
        Catalog.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Catalog.prototype, '_id', {
            get: function() {
                return this.id;
            }
        });

        Object.defineProperty(Catalog.prototype, '_name', {
            get: function() {
                return this.name;
            },
            set: function(n) {
                this.name = n;
            }
        });

        Object.defineProperty(Catalog.prototype, '_items', {
            get: function() {
                return this.items;
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
    })(function(){});
    
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
