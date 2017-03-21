module.exports = function solve() {
  return function (element, contents) {
    var contentCount,        
      div,
      fragment,
      selection;

    if (typeof element === 'string') {
      selection = document.getElementById(element);
    } else if (element instanceof HTMLElement) {
      selection = element;
    } else {
      throw Error('invalid element!');
    }

    fragment = document.createDocumentFragment();

    for (var i = 0, contentCount = contents.length; i < contentCount; i += 1) {
      var item = contents[i];

      if (typeof item !== 'string' && typeof item !== 'number') {
        throw Error('invalid content item!');
      }

      div = document.createElement('div');
      div.innerHTML = item;
      fragment.appendChild(div);
    }

    selection.innerHTML = '';
    selection.appendChild(fragment);
  };
};
