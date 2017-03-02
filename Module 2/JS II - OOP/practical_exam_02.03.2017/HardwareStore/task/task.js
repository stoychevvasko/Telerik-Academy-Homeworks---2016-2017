function solve() {
    const getNextId = (function() {
        let counter = 0;
        return function() {
            counter += 1;
            return counter;
        };
    })();

    validator = (function(){
        function _validateProductManufacturer(value) {
            // string with length between 1 and 20 symbols (inclusive)
            if (!value || typeof value !== 'string' || value.length < 1 || value.length > 20) {
                throw new Error();
            }
        }

        function _validateProductModel(value) {
            // string with length between 1 and 20 symbols (inclusive)
            if (!value || typeof value !== 'string' || value.length < 1 || value.length > 20) {
                throw new Error();
            }
        }

        function _validateProductPrice(value) {
            // positive, non-zero number
            if (!value || typeof value !== 'number' || value < 0 || value === 0) {
                throw new Error();
            }
        }

        function _validateSmartPhoneScreenSize(value) {
            // positive, non-zero number
            if (!value || typeof value !== 'number' || value < 0 || value === 0) {
                throw new Error();
            }
        }

        function _validateSmartPhoneOperatingSystem(value) {
            // string with length between 1 and 10 symbols (inclusive)
            if (!value || typeof value !== 'string' || value.length < 1 || value.length > 10) {
                throw new Error();
            }
        }

        function _validateChargerOutputVoltage(value) {
            // number between 5 and 20 (inclusive)
            if (!value || typeof value !== 'number' || value < 5 || value > 20) {
                throw new Error();
            }
        }

        function _validateChargerOutputCurrent(value) {
            // number between 100 and 3000 (inclusive)
            if (!value || typeof value !== 'number' || value < 100 || value > 3000) {
                throw new Error();
            }
        }

        function _validateRouterWifiRange(value) {
            // positive, non-zero number
            if (!value || typeof value !== 'number' || value < 0 || value === 0) {
                throw new Error();
            }
        }

        function _validateRouterLanPorts(value) {
            // positive, non-zero integer number
            if (!value || typeof value !== 'number' || value < 0 || value === 0 || value % 1 !== 0) {
                throw new Error();
            }
        }

        function _validateHeadphonesQuality(value) {
            // string, should be either high, mid or low
            if (!value || typeof value !== 'string' || (value !== 'high' && value !== 'mid' && value !== 'low')) {
                throw new Error();
            }
        }

        function _validateHardwareStoreName(value) {
            // string with length between 1 and 20 symbols (inclusive)
            if (!value || typeof value !== 'string' || value.length < 1 || value.length > 20) {
                throw new Error();
            }
        }        

        function _validateHardwareStoreStockProduct(value) {
            // should be a valid Product instance - valid properties id, manufacturer, model, price, method getLabel()
            if (!value || typeof value !== 'object' || 
                !value.hasOwnProperty('_id') || !value.hasOwnProperty('_model') || 
                    !value.hasOwnProperty('_manufacturer') || !value.hasOwnProperty('_price')) {
                        throw new Error();
                    }

            if (typeof value._id !== 'number') {
                throw new Error();
            }

            validator.validateProductModel(value.model);
            validator.validateProductManufacturer(value.manufacturer);
            validator.validateProductPrice(value.price);
        }

        function _validateHardwareStoreStockQuantity(value) {
            // should be a positive, non-zero integer number
            if (!value || typeof value !== 'number' || value < 0 || value === 0 || value % 1 !== 0) {
                throw new Error();
            }
        }

        return {
            validateProductManufacturer: function(value) {
                _validateProductManufacturer(value);
            },
            validateProductModel: function(value) {
                _validateProductModel(value);
            },
            validateProductPrice: function(value) {
                _validateProductPrice(value);
            },
            validateSmartPhoneScreenSize: function(value) {
                _validateSmartPhoneScreenSize(value);
            },
            validateSmartPhoneOperatingSystem: function(value) {
                _validateSmartPhoneOperatingSystem(value);
            },
            validateChargerOutputVoltage: function(value) {
                _validateChargerOutputVoltage(value);
            },
            validateChargerOutputCurrent: function(value) {
                _validateChargerOutputCurrent(value);
            },
            validateRouterWifiRange: function(value) {
                _validateRouterWifiRange(value);
            },
            validateRouterLanPorts: function(value) {
                _validateRouterLanPorts(value);
            },
            validateHeadphonesQuality(value) {
                _validateHeadphonesQuality(value);
            },
            validateHardwareStoreName(value) {
                _validateHardwareStoreName(value);
            },
            validateHardwareStoreStockProduct(value) {
                _validateHardwareStoreStockProduct(value);
            },
            validateHardwareStoreStockQuantity(value) {
                _validateHardwareStoreStockQuantity(value);
            }
        }
    }());

    // Product class definition
    Product = (function(Parent){
        function Product(manufacturer, model, price) {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this._id = getNextId();
            this._label = 'Product';
        }
        Product.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Product.prototype, 'id', {
            get: function() {
                return this._id;
            },
            set: function(idValue) {
                this._id = idValue;
            }
        });

        Object.defineProperty(Product.prototype, 'manufacturer', {
            get: function() {
                return this._manufacturer;
            },
            set: function(manufacturerValue) {
                validator.validateProductManufacturer(manufacturerValue);
                this._manufacturer = manufacturerValue;
            }
        });

        Object.defineProperty(Product.prototype, 'model', {
            get: function() {
                return this._model;
            },
            set: function(modelValue) {
                validator.validateProductModel(modelValue);
                this._model = modelValue;
            }
        });

        Object.defineProperty(Product.prototype, 'price', {
            get: function() {
                return this._price;
            },
            set: function(priceValue) {
                validator.validateProductPrice(priceValue);
                this._price = priceValue;
            }
        });

        Product.prototype.getLabel = function(){
            return (this._label + ' - ' + this._manufacturer.toUpperCase() + ' ' + this._model.toUpperCase() + ' - **' + this._price.toString().toUpperCase() + '**');
        }

        return Product;
    }(function(){}));

    // SmartPhone class definition
    SmartPhone = (function(Parent) {
        function SmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
            Parent.call(this, manufacturer, model, price, screenSize, operatingSystem);
            this.screenSize = screenSize;
            this.operatingSystem = operatingSystem;
            this._label = 'SmartPhone';
        }
        SmartPhone.prototype = Object.create(Parent.prototype);

        Object.defineProperty(SmartPhone.prototype, 'screenSize', {
            get: function() {
                return this._screenSize;
            },
            set: function(screenSizeValue) {
                validator.validateSmartPhoneScreenSize(screenSizeValue);
                this._screenSize = screenSizeValue;
            }
        });

        Object.defineProperty(SmartPhone.prototype, 'operatingSystem', {
            get: function() {
                return this._operatingSystem;
            },
            set: function(operatingSystemValue) {
                validator.validateSmartPhoneOperatingSystem(operatingSystemValue);
                this._operatingSystem = operatingSystemValue;
            }
        });

        return SmartPhone;
    }(Product));

    // Charger class definition
    Charger = (function(Parent) {
        function Charger(manufacturer, model, price, outputVoltage, outputCurrent) {
            Parent.call(this, manufacturer, model, price);
            this.outputVoltage = outputVoltage;
            this.outputCurrent = outputCurrent;
            this._label = 'Charger';
        }
        Charger.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Charger.prototype, 'outputVoltage', {
            get: function() {
                return this._outputVoltage;
            },
            set: function(outputVoltageValue) {
                validator.validateChargerOutputVoltage(outputVoltageValue);
                this._outputVoltage = outputVoltageValue;
            }
        });

        Object.defineProperty(Charger.prototype, 'outputCurrent', {
            get: function() {
                return this._outputCurrent;
            },
            set: function(outputCurrentValue) {
                validator.validateChargerOutputCurrent(outputCurrentValue);
                this._outputCurrent = outputCurrentValue;
            }
        });

        return Charger;
    }(Product));

    // Router class definition
    Router = (function(Parent) {
        function Router(manufacturer, model, price, wifiRange, lanPorts) {
            Parent.call(this, manufacturer, model, price);
            this.wifiRange = wifiRange;
            this.lanPorts = lanPorts;
            this._label = 'Router';
        }
        Router.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Router.prototype, 'wifiRange', {
            get: function() {
                return this._wifiRange;
            },
            set: function(wifiRangeValue) {
                validator.validateRouterWifiRange(wifiRangeValue);
                this._wifiRange = wifiRangeValue;
            }
        });

        Object.defineProperty(Router.prototype, 'lanPorts', {
            get: function() {
                return this._lanPorts;
            },
            set: function(lanPortsValue) {
                validator.validateRouterLanPorts(lanPortsValue);
                this._lanPorts = lanPortsValue;
            }
        });

        return Router;
    }(Product));

    // Headphones class definition
    Headphones = (function(Parent) {
        function Headphones(manufacturer, model, price, quality, hasMicrophone) {
            Parent.call(this, manufacturer, model, price);
            this.quality = quality;
            this.hasMicrophone = hasMicrophone;
            this._label = 'Headphones';
        }
        Headphones.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Headphones.prototype, 'quality', {
            get: function() {
                return this._quality;
            },
            set: function(qualityValue) {
                validator.validateHeadphonesQuality(qualityValue);
                this._quality = qualityValue;
            }
        });

        Object.defineProperty(Headphones.prototype, 'hasMicrophone', {
            get: function() {
                return this._hasMicrophone;
            },
            set: function(hasMicrophoneValue) {
                this._hasMicrophone = !!hasMicrophoneValue;
            }
        });

        return Headphones;
    }(Product));

    // HardwareStore class definition
    HardwareStore = (function(Parent) {
        function HardwareStore(name) {
            this.name = name;
            this.products = [];
            this._sales = 0;
        }
        HardwareStore.prototype = Object.create(Parent.prototype);

        Object.defineProperty(Headphones.prototype, 'name', {
            get: function() {
                return this._name;
            },
            set: function(nameValue) {
                validator.validateHardwareStoreName(nameValue);
                this._name = nameValue;
            }
        });

        Object.defineProperty(Headphones.prototype, 'products', {
            get: function() {
                return this._products;
            },
            set: function(productsValue) {

                this._products = productsValue;
            }
        });

        HardwareStore.prototype.stock = function(product, quantity) {
            validator.validateHardwareStoreStockProduct(product);
            validator.validateHardwareStoreStockQuantity(quantity);

            if (!this.products.some(p => p._product._id === product._id)) {
                // new product id 
                let newBulkBatch = {
                    _product: product,
                    _quantity: quantity
                };

                this.products.push(newBulkBatch);
            } else {
                // existing product id
                let existingBulkBatch = this.products.filter(p => p._product._id === product._id)[0];
                existingBulkBatch._quantity += quantity;
            }

            return this;
        }

        HardwareStore.prototype.sell = function(productId, quantity) {
            if (!productId || typeof productId !== 'number') {
                throw new Error();
            }

            validator.validateHardwareStoreStockQuantity(quantity);

            let existingBulkBatch = this.products.filter(p => p._product._id === productId)[0];

            if (existingBulkBatch === undefined || existingBulkBatch._quantity < quantity) {
                throw new Error();
            }

            existingBulkBatch._quantity -= quantity;
            this._sales += existingBulkBatch._product._price * quantity;
            return this;
        }

        HardwareStore.prototype.getSold = function() {
            return this._sales;
        }

        HardwareStore.prototype.search = function(parameter) {

            if (typeof parameter === 'string') {
                // pattern chosen
                let result = [],
                    pattern = new RegExp(parameter.toLowerCase());

                let selection = this.products.filter(p => (pattern.test(p._product._model.toLowerCase()) || pattern.test(p._product._manufacturer.toLowerCase())));
                selection.forEach(item => {
                    let element = {
                        product: item._product,
                        quantity: item._quantity
                    };

                    result.push(element);
                });

                return result;
            } else if (typeof parameter === 'object') {
                // options chosen
                let option = parameter,
                    result = [],
                    types = [ 'SmartPhone', 'Charger', 'Router', 'Headphones' ],
                    minPrice = 0,
                    maxPrice = Number.MAX_SAFE_INTEGER;

                if (option.hasOwnProperty('manufacturerPattern')) {
                    let pattern = new RegExp(parameter.manufacturerPattern),
                        selection = this.products.filter(p => pattern.test(p._product._manufacturer));

                    selection.forEach(item => {
                        let element = {
                            product: item._product,
                            quantity: item._quantity
                        };

                        result.push(element);
                    });
                }

                if (option.hasOwnProperty('modelPattern')) {
                    let pattern = new RegExp(parameter.modelPattern),
                        selection = this.products.filter(p => pattern.test(p._product._model));

                    selection.forEach(item => {
                        let element = {
                            product: item._product,
                            quantity: item._quantity
                        };

                        result.push(element);
                    });
                }

                if (option.hasOwnProperty('type')) {
                    result = result.filter(p => p.product._label === option.type);
                }

                if (option.hasOwnProperty('minPrice')) {
                    result = result.filter(p => p.product._price >= option.minPrice);
                }

                if (option.hasOwnProperty('maxPrice')) {
                    result = result.filter(p => p.product._price <= option.maxPrice);
                }

                return result;
            }

            //TODO
        }

        return HardwareStore;
    }(function(){}));

    return {
        getSmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
            return new SmartPhone(manufacturer, model, price, screenSize, operatingSystem);
        },
        getCharger(manufacturer, model, price, outputVoltage, outputCurrent) {
            return new Charger(manufacturer, model, price, outputVoltage, outputCurrent);
        },
        getRouter(manufacturer, model, price, wifiRange, lanPorts) {
            return new Router(manufacturer, model, price, wifiRange, lanPorts);
        },
        getHeadphones(manufacturer, model, price, quality, hasMicrophone) {
            return new Headphones(manufacturer, model, price, quality, hasMicrophone);
        },
        getHardwareStore(name) {
            return new HardwareStore(name);
        }
    };
}

// Submit the code above this line in bgcoder.com
module.exports = solve; // DO NOT SUBMIT THIS LINE
const result = solve();

const phone = result.getSmartPhone('HTC', 'One', 903, 5, 'Android');
// console.log(phone);
// console.log(phone.getLabel()); // SmartPhone - HTC One - **903**

const charger = result.getCharger('DELL', 'standard_charger', 25, 10, 500);
// console.log(charger);
// console.log(charger.getLabel());

const router = result.getRouter('Logitech', 'some router', 150, 2, 3);
// console.log(router);
// console.log(router.getLabel());

const headphones = result.getHeadphones('Sennheiser', 'PXC 550 Wireless', 340, 'high', false);
// console.log(headphones);
// console.log(headphones.getLabel());

const store = result.getHardwareStore('Magazin');

store.stock(phone, 1)
    .stock(headphones, 15)
    .stock(phone, 2);

store.sell(phone.id, 3);
//console.log(store.getSold());
// console.log(store);

// console.log(store.search('senn'));
/*
[ { product:
     Headphones { ... },
    quantity: 15 } ]
    */

//console.log(store.search({type: 'SmartPhone', maxPrice: 1000}));
/*
[ { product:
     SmartPhone { ... },
    quantity: 1 } ]
    */

//console.log(store.search({type: 'SmartPhone', maxPrice: 900}));
/* [] */

//store.sell(headphones.id, 2);
//console.log(store.getSold()); // 680
