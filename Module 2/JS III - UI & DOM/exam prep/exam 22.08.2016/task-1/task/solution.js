function solve() {
  return function (selector, tabs) {
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
        return document.createElement('p') 
      };

    var navUl = getNewUl();
    navUl.className += ' tabs-nav';

    var contentUl = getNewUl();
    contentUl.className += ' tabs-content';

    for (var i = 0, len = tabs.length; i < len; i += 1) {
      var navLi = getNewLi();
      var navLiA = getNewA();
      navLiA.className += ' tab-link';
      navLiA.innerHTML = tabs[i].title;
      navLi.appendChild(navLiA);
      navUl.appendChild(navLi);

      var contentLi = getNewLi();
      contentLi.className += ' tab-content';

    }

    fragment.appendChild(navUl);
    root.appendChild(fragment);
  }
}

if (typeof module !== 'undefined') {
  module.exports = solve;
}
