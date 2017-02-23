function solve() {
    validator = (function() {
        function validateString(str, name) {
            if(str && (typeof str !== 'string')) {
                throw Error();
            }

            if (str && typeof str === 'string' && str.length < 1) {
                throw Error();
            }
        }

        function validateLength1_24(str, name) {
            if(str && (str.length < 1 || str.length > 24)) {
                throw Error();
            }
        }

        function validateLength1_32(str, name) {
            if(str && typeof str === 'string' && (str.length < 1 || str.length > 32)) {
                throw Error();
            }
        }

        function validateAlphaNumericWithWhiteSpace(str, name) {
            if(str && str.match(/[^a-zA-Z0-9 ]/)) {
                throw Error();
            }
        }

        function validatePositiveInteger(num, name) {       
            if(num && (typeof num !== 'number' || !(num > 0) || num !== (num | 0))) {
                throw Error();
            }
        }

        function validateNumber1_10(num, name) {
            if(num && (typeof num !== 'number' || (num < 1) || (num > 10))) {
                throw Error();
            }
        }

        function validateArrayOfApps(arr, name) {
            if (arr && typeof arr !== 'object') {
                throw Error();
            }

            for (item in arr) {
                validator.validateApp(item, 'Potential app');
            }
        }

        function validateApp(item, name) {
            if (item) {
                // validate name
                validator.validateString(item.name, 'Name');
                validator.validateLength1_24(item.name, 'Name');
                validator.validateAlphaNumericWithWhiteSpace(item.name, 'Name');

                // validate description
                validator.validateString(item.description, 'Description');

                // validate version
                validator.validatePositiveInteger(item.version, 'Version');

                // validate rating
                validator.validateNumber1_10(item.rating, 'Rating');
            }
        }

        function validateVersion(system, version, name) {
            if (system.version >= version) {
                throw Error();
            }
        }

        return {
            validateString: function(str, name) {
                validateString(str, name);
            },
            validateLength1_24: function(str, name)	{
                validateLength1_24(str, name)
            },
            validateLength1_32: function(str, name) {
                validateLength1_32(str, name)
            },
            validateAlphaNumericWithWhiteSpace: function(str, name) {
                validateAlphaNumericWithWhiteSpace(str, name);
            },
            validatePositiveInteger: function(num, name) {
                validatePositiveInteger(num, name);
            },
            validateNumber1_10: function(num, name) {
                validateNumber1_10(num, name);
            },
            validateArrayOfApps: function(arr, name) {
                validateArrayOfApps(arr, name);
            },
            validateApp: function(item, name) {
                validateApp(item, name);
            },
            validateVersion: function(system, version, name) {
                validateVersion(system, version, name) 
            }
        }
    }()); 

    App = (function(Parent) {
        function App(name, description, version, rating) {
            validator.validateString(name, 'Name');
            validator.validateLength1_24(name, 'Name');
            validator.validateAlphaNumericWithWhiteSpace(name, 'Name');
            this.name = name;

            validator.validateString(description, 'Description');
            this.description = description;

            validator.validatePositiveInteger(version, 'Version');
            this.version = version;

            validator.validateNumber1_10(rating, 'Rating');
            this.rating = rating;
        }
        App.prototype = Object.create(Parent.prototype);

        Object.defineProperty(App.prototype, '_name', {
            get: function() {
                return this._name;
            },		
            set: function (nameValue) {
                validator.validateString(nameValue, 'Name');
                validator.validateLength1_24(nameValue, 'Name');
                validator.validateAlphaNumericWithWhiteSpace(nameValue, 'Name');

                this.name = nameValue;
            }		
        });

        Object.defineProperty(App.prototype, '_description', {
            get: function() {
                return this.description;
            },
            set: function(descriptionValue){
                validator.validateString(descriptionValue, 'Description');

                this.description = descriptionValue;
            }
        });

        Object.defineProperty(App.prototype, '_version', {
            get: function() {
                return this.version;
            },
            set function(versionValue) {
                validator.validatePositiveInteger(versionValue, 'Version');

                this.version = versionValue;
            }
        });

        Object.defineProperty(App.prototype, '_rating', {
            get: function() {
                return this.rating;
            },
            set: function(ratingValue) {
                validator.validateNumber1_10(ratingValue, 'Rating');

                this.rating = ratingValue
            }
        });

        App.prototype.release = function(releaseParameter) {
            if (typeof releaseParameter === 'number') {
                // version parameter
                let versionValue = releaseParameter;
                validator.validateVersion(this, versionValue, 'Version');

                this.version = versionValue;
            } else if (typeof releaseParameter.version === 'number') {
                // options parameter - mandatory version
                let optionsValue = releaseParameter;
                validator.validateVersion(this, optionsValue.version, 'Version');

                this.version = optionsValue.version;

                // optional description
                if (releaseParameter.hasOwnProperty('description')) {
                    this.description = releaseParameter.description;
                }

                // optional rating
                if (releaseParameter.hasOwnProperty('rating ')) {
                    this.rating = releaseParameter.rating;
                }
            } else {
                // invalid parameter
                throw Error();
            }
        }

        return App;
    }(function () {}));

    Store = (function(Parent) {
        function Store(name, description, version, rating) {
            Parent.call(this, name, description, version, rating);            

            this._apps = [];
        }
        Store.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Store.prototype, 'apps', {
            get: function() {
                return this._apps;
            },
            set: function(appsValue) {
                validator.validateArrayOfApps(appsValue, 'Apps array');

                this._apps = appsValue.slice(); 
            }
        });

        Store.prototype.uploadApp = function(app) {
            validator.validateApp(app, 'Potential app');

            let matchingAppFound = this._apps.find(appFromList => appFromList.name === app.name);
            if(matchingAppFound === undefined) {
                // new app, name not found among existing apps
                let newApp = new App(matchingAppFound.name, matchingAppFound.description, matchingAppFound.version, matchingAppFound.rating);
                this._apps.push(newApp);
            } else {
                // app with same name exists already
                validator.validateVersion(this, matchingAppFound.version, 'Existing app');

                matchingAppFound.description = app.description;
                matchingAppFound.rating = app.rating;
            }

            return this;
        }

        Store.prototype.takedownApp = function(name) {
            let matchingAppFound = this._apps.find(listedApp => listedApp.name === name);
            if(matchingAppFound === undefined) {
                // cannot find existing app by this name
                throw Error();
            } else {
                // app for removal successfully found
                let index = this._apps.indexOf(matchingAppFound);
                this._apps.splice(index, 1);
            }

            return this;
        }

        Store.prototype.search = function(pattern) {
            let caseInsensitivePattern = ('/' + pattern.toLower() + '/');
            let results = this._apps.filter(appItem => appItem.name.toLower().match(caseInsensitivePattern));
            results.sort((a, b) => a.name - b.name);
            return results;
        }

        Store.prototype.listMostRecentApps = function(count) {
            //
        }

        Store.prototype.listMostPopularApps = function(count) {
            let c,
                result;
            if (arguments.length === 0) {
                c = 10;
            } else {
                c = count;
            }

            result = this.apps.sort((a, b) => a.rating - b.rating).slice(0, c - 1);
            return result;
        }

        return Store;
    }(App));

    Device = (function(Parent) {
        function Device(hostName, arrayOfApps) {

            validator.validateString(hostName, 'Hostname');
            validator.validateLength1_32(hostName, 'Hostname');            
            this.hostname = hostName;

            validator.validateArrayOfApps(arrayOfApps, 'Apps array');
            this.apps = arrayOfApps;
        }
        Device.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Device.prototype, '_hostname', {
            get: function() {
                return this.hostname;
            },
            set function(hostnameValue) {
                validator.validateString(hostnameValue, 'Name');
                validator.validateLength1_32(hostnameValue, 'Hostname');

                this.hostname = hostnameValue;
            }
        });

        Object.defineProperty(Device.prototype, '_apps', {
            get: function() {
                return this.apps;
            },
            set: function(appsValue) {
                validator.validateArrayOfApps(appsValue, 'Apps array');

                this.apps = appsValue; 
            }
        });

        Device.prototype.search = function(pattern) {
            //
        }

        Device.prototype.install = function(name) {
            //
        }

        Device.prototype.uninstall = function(name) {
            //
        }

        Device.prototype.listInstalled = function() {
            //
        }

        Device.prototype.update = function() {
            //
        }

        return Device;
    }(function () {}));

    // return statement for solve()

    return {
        createApp(name, description, version, rating) {            
            let newApp = new App(name, description, version, rating);
            return newApp;
        },
        createStore(name, description, version, rating) {
            let newStore = new Store(name, description, version, rating);
            return newStore;
        },
        createDevice(hostname, apps) {
            let newDevice = new Device(hostname, apps);
            return newDevice;
        }
    };
}

// Submit the code above this line in bgcoder.com
module.exports = solve;

var module = solve();
var store = module.createStore('da store', 'so online, wow', 1, 2);
var newApp_01 = module.createApp('app', 'desc', 1, 5);
var appsArray = [];
appsArray.push(newApp_01);
var device = module.createDevice('host of fire', appsArray);


