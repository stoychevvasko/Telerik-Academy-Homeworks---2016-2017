function solve() {
    const Validator = {
        validateString(str, name) {
            if(typeof str !== 'string') {
                throw Error(`${name} is not a string`);
            }
        },
        validateLength1_24(str, name) {
            if(str.length < 1 || str.length > 24) {
                throw Error(`${name} must be between between 1 and 24 symbols long!`);
            }
        },
        validateLength1_32(str, name) {
            if(str.length < 1 || str.length > 32) {
                throw Error(`${name} must be between between 1 and 32 symbols long!`);
            }
        },
        validateAlphaNumericWithWhiteSpace(str, name) {
            if(str.match(/[^a-zA-Z0-9 ]/)) {
                throw Error(`${name} can contain only alpha-numeric symbols or whitespace!`);
            }
        },
        validatePositiveInteger(num, name) {       
            if(typeof num !== 'number' || !(num > 0) || num !== (num | 0)) {
                throw Error(`${name} must be a positive integer number!`);
            }
        },
        validateNumber1_10(num, name) {
            if(typeof num !== 'number' || (num < 1) || (num > 10)) {
                throw Error(`${name} must be an integer number between 1 and 10!`);
            }
        },
        validateArrayOfApps(arr, name) {
            if (typeof arr !== 'object') {
                throw Error(`${name} is not an array of apps!`);
            }

            for (item in arr) {
                Validator.validateApp(item, 'Potential app');
            }
        },
        validateApp(item, name) {
            // validate name
            Validator.validateString(item.name, 'Name');
            Validator.validateLength1_24(item.name, 'Name');
            Validator.validateAlphaNumericWithWhiteSpace(item.name, 'Name');

            // validate description
            Validator.validateString(item.description, 'Description');

            // validate version
            Validator.validatePositiveInteger(item.version, 'Version');

            // validate rating
            Validator.validateNumber1_10(item.rating, 'Rating');
        },
        validateVersion(system, version, name) {
            if (system.version >= version) {
                throw Error(`${name} ${version} must be greater than ${system.version}!`);
            }
        }
    }; 

    App = (function(Parent) {
        function App(name, description, version, rating) {
            this.name = name;
            this.description = description;
            this.version = version;
            this.rating = rating;
        }
        App.prototype = Object.create(Parent.prototype);

        Object.defineProperty(App.prototype, 'name', {
            get: function() {
                return this._name;
            },		
            set: function (nameValue) {
                Validator.validateString(nameValue, 'Name');
                Validator.validateLength1_24(nameValue, 'Name');
                Validator.validateAlphaNumericWithWhiteSpace(nameValue, 'Name');

                this._name = nameValue;
            }		
        });

        Object.defineProperty(App.prototype, 'description', {
            get: function() {
                return this._description;
            },
            set: function(descriptionValue){
                Validator.validateString(descriptionValue, 'Description');

                this._description = descriptionValue;
            }
        });

        Object.defineProperty(App.prototype, 'version', {
            get: function() {
                return this._version;
            },
            set function(versionValue) {
                Validator.validatePositiveInteger(versionValue, 'Version');

                this._version = versionValue;
            }
        });

        Object.defineProperty(App.prototype, 'rating', {
            get: function() {
                return this._rating;
            },
            set: function(ratingValue) {
                Validator.validateNumber1_10(ratingValue, 'Rating');

                this._rating = ratingValue
            }
        });

        App.prototype.release = function(releaseParameter) {
            if (typeof releaseParameter === 'number') {
                // version parameter
                let versionValue = releaseParameter;
                Validator.validateVersion(this, versionValue, 'Version');

                this.version = versionValue;
            } else if (typeof releaseParameter.version === 'number') {
                // options parameter - mandatory version
                let optionsValue = releaseParameter;
                Validator.validateVersion(this, optionsValue.version, 'Version');

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
                throw Error(`Invalid parameter ${releaseParameter}!`);
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
                Validator.validateArrayOfApps(appsValue, 'Apps array');

                this._apps = appsValue.slice(); 
            }
        });

        Store.prototype.uploadApp = function(app) {
            Validator.validateApp(app, 'Potential app');

            let matchingAppFound = this._apps.find(appFromList => appFromList.name === app.name);
            if(matchingAppFound === undefined) {
                // new app, name not found among existing apps
                let newApp = new App(matchingAppFound.name, matchingAppFound.description, matchingAppFound.version, matchingAppFound.rating);
                this._apps.push(newApp);
            } else {
                // app with same name exists already
                Validator.validateVersion(this, matchingAppFound.version, 'Existing app');

                matchingAppFound.description = app.description;
                matchingAppFound.rating = app.rating;
            }

            return this;
        }

        Store.prototype.takedownApp = function(name) {
            let matchingAppFound = this._apps.find(listedApp => listedApp.name === name);
            if(matchingAppFound === undefined) {
                // cannot find existing app by this name
                throw Error(`App by the name of ${name} cannot be found for removal!`);
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


        }

        Store.prototype.listMostRecentApps = function(count) {
            //
        }

        Store.prototype.listMostPopularApps = function(count) {
            //
        }

        return Store;
    }(App));

    Device = (function(Parent) {
        function Device(hostname, arrayOfApps) {
            this.hostname = hostname;
            this.apps = arrayOfApps;
        }
        Device.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Device.prototype, 'hostname', {
            get: function() {
                return this._hostname;
            },
            set function(hostnameValue) {
                Validator.validateString(hostnameValue, 'Name');
                Validator.validateLength1_32(hostnameValue, 'Hostname');

                this._hostname = hostnameValue;
            }
        });

        Object.defineProperty(Device.prototype, 'apps', {
            get: function() {
                return this._apps;
            },
            set: function(appsValue) {
                Validator.validateArrayOfApps(appsValue, 'Apps array');

                this._apps = appsValue; 
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
