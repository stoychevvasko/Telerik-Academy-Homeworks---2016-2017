# JavaScript UI & DOM

## 01. DOM Operations


## 02. Event Model


## 03. jQuery Overview

* navigate and select DOM elements
* create animations
* handle events
* free, open-source

### Selections

jQuery uses CSS 3 selectors (analogous to querySelectorAll)

* select by tag

```javascript
$("div") // document.querySelectorAll("div");
```

* select by class

```javascript
$(".menu-item") // document.querySelectorAll(".menu-item");
```

* select by id

```javascript
$("#navigation") //  only by a combination of vanilla selectors
```

### Traversing DOM elements

```javascript
jQuery.next();
jQuery.prev();
```

Returns the next or previous HTML node. It is an HTML element, the content being in the ```javascript text``` node. 

```javascript
jQuery.first();
```

Returns the first element to match the selector.

tbc...