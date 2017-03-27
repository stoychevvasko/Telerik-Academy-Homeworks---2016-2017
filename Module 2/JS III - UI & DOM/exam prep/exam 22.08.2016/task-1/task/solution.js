function solve() {
  return function (selector, tabs) {
    function showContent(event) {
      var key = event.target.innerHTML;
      var liContents = document.getElementsByClassName('tab-content');        
      for (var i = 0, len = tabs.length; i < len; i += 1) {
        if (tabs[i].title === key) {
          liContents[i].className += ' visible';
        } else {
          liContents[i].className = liContents[i].className.split('visible').join('');
        }
      }    
    }

    function editContent(event) {
      var target = event.target;
      target.innerHTML = 'Save';
      target.removeEventListener('click', editContent);
      target.addEventListener('click', saveContent);

      var textBox = document.createElement('textarea');
      textBox.className = 'edit-content';
      textBox.innerHTML = target.previousElementSibling.innerHTML;
      target.parentElement.appendChild(textBox);
    }

    function saveContent(event) {
      var target = event.target;
      target.innerHTML = 'Edit';
      target.removeEventListener('click', saveContent);
      target.addEventListener('click', editContent);

      var textarea = target.nextElementSibling;
      target.previousElementSibling.innerHTML = textarea.value;
      target.parentElement.removeChild(textarea);
    }

    var root = document.querySelectorAll(selector)[0],
      fragment = document.createDocumentFragment(),
      getNewUl = function(){ 
        return document.createElement('ul'); 
      },
      getNewLi = function(){ 
        return document.createElement('li'); 
      },
      getNewA = function(){
        return document.createElement('a');
      },
      getNewP = function(){
        return document.createElement('p'); 
      },
      getNewButton = function(){
        return document.createElement('button'); 
      };

    var navUl = getNewUl();
    navUl.className = 'tabs-nav';

    var contentUl = getNewUl();
    contentUl.className = 'tabs-content';

    for (var i = 0, len = tabs.length; i < len; i += 1) {
      var navLi = getNewLi();
      var navLiA = getNewA();
      navLiA.className = 'tab-link';
      navLiA.innerHTML = tabs[i].title;
      navLiA.addEventListener('click', showContent);
      navLi.appendChild(navLiA);
      navUl.appendChild(navLi);

      var contentLi = getNewLi();
      contentLi.className = 'tab-content' + ((i === 0) ? ' visible' : '');
      var contentLiP = getNewP();
      contentLiP.innerHTML = tabs[i].content;
      contentLi.appendChild(contentLiP);
      var contentLiButton = getNewButton();
      contentLiButton.className = 'btn-edit';
      contentLiButton.innerHTML = 'Edit';
      contentLiButton.addEventListener('click', editContent);
      contentLi.appendChild(contentLiButton);
      contentUl.appendChild(contentLi);
    }

    fragment.appendChild(navUl);
    fragment.appendChild(contentUl);

    root.appendChild(fragment);    
  }
}

if (typeof module !== 'undefined') {
  module.exports = solve;
}
