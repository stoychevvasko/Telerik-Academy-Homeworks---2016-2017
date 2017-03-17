function solve(){
  return function (selector) {
    function isSiblingOfButton(element) {
      return (element.nextElementSibling.className === 'button') ? true : false;
    }    

    function hasContent(element) {
      return (element.innerHtml && element.innerHtml.length > 0 && element.innerHtml !== 'hide') ? true : false;
    }

    function toggleContentDisplay(event) {
      var targetElement = event.target,
        nextSibling = targetElement.nextElementSibling,
        resultElement;

      while (nextSibling) {
        if (hasContent(targetElement)) {
          targetElement = nextSibling;
          nextSibling = targetElement.nextElementSibling;

          while (nextSibling) {
            if (isSiblingOfButton(targetElement)) {
              resultElement = targetElement;
              console.log(resultElement);
              resultElement.innerHTML = 'hide';
              resultElement.addEventListener('click', toggleContentDisplay(event)); 
              break;
            }
          }          
        } 

        if (typeof resultElement !== 'undefined') {
          break;
        }        
      }  
    }

    var selectedButtons,      
      selectedContents;

    if (typeof selector === 'string') {
      selectedButtons = document.getElementsByClassName('button');
      selectedContents = document.getElementsByClassName('content');

      for (var i = 0; i < selectedButtons.length; i += 1) {
        selectedButtons[i].innerHTML = 'hide';
        selectedButtons[i].addEventListener('click', toggleContentDisplay(event)); 
      }
    } else if (selector instanceof HTMLElement) {
      selection = element;
    } else {
      throw Error('invalid selector passed as parameter!');
    }

    if (selection === null) {
      throw Error('cannot select element with selector {' + selector + '}!');
    }
  };
};

module.exports = solve;
