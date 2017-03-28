function solve() {
  return function(selector, defaultLeft, defaultRight) {
    function addItem(event) {
      var target = event.target;
      var input = target.previousElementSibling.value.trim();
      if (typeof input === 'string' && input !== '') {
        var isLeftColumnSelected = document.getElementById('select-left-column').checked;
        var columnOl;
        if (isLeftColumnSelected) {
          columnOl = document.querySelector('#left-ol');        
        } else {
          columnOl = document.querySelector('#right-ol');        
        }

        var newLiEntry = document.createElement('li');
        newLiEntry.className = 'entry';      

        var newImgIcon = document.createElement('img');
        newImgIcon.className = 'delete';
        newImgIcon.src = 'imgs/Remove-icon.png';
        newImgIcon.addEventListener('click', deleteItem);           
        newLiEntry.appendChild(newImgIcon);
        newLiEntry.innerHTML += input.toString();
        columnOl.appendChild(newLiEntry);
      }

      target.previousElementSibling.value = '';
    }

    function deleteItem(event) {
      console.log('test');
    }

    var root = document.querySelector(selector);
    var fragment = document.createDocumentFragment();

    if (typeof defaultLeft === 'undefined') {
      defaultLeft = [];
    }

    if (typeof defaultRight === 'undefined') {
      defaultRight = [];
    }

    // column container
    var newColumnContainer = document.createElement('div');
    newColumnContainer.className = 'column-container';    

    // left column
    var newLeftColumn = document.createElement('div');
    newLeftColumn.className = 'column';

    var newRadioButtonContainer = document.createElement('div');
    newRadioButtonContainer.className = 'select';

    var newRadioButton = document.createElement('input');
    newRadioButton.type = 'radio';
    newRadioButton.name = 'column-select';
    newRadioButton.id = 'select-left-column';
    newRadioButton.checked = 'checked';
    newRadioButtonContainer.appendChild(newRadioButton);

    var newLabel = document.createElement('label');
    newLabel.htmlFor = 'select-left-column';
    newLabel.innerHTML = 'Add here';
    newRadioButtonContainer.appendChild(newLabel);

    newLeftColumn.appendChild(newRadioButtonContainer);

    var newLeftOl = document.createElement('ol');
    newLeftOl.id = 'left-ol';

    for (var i = 0, len = defaultLeft.length; i < len; i += 1) {      
      if (typeof defaultLeft[i] === 'string' && defaultLeft[i] !== '') {
        var newLi = document.createElement('li');
        newLi.className = 'entry';      

        var newImg = document.createElement('img');
        newImg.className = 'delete';
        newImg.src = 'imgs/Remove-icon.png';    
        newImg.addEventListener('click', deleteItem);           
        newLi.appendChild(newImg);      
        newLi.innerHTML += defaultLeft[i];
        newLeftOl.appendChild(newLi);
      }
    }

    newLeftColumn.appendChild(newLeftOl);

    newColumnContainer.appendChild(newLeftColumn);

    // right column
    var newRightColumn = document.createElement('div');
    newRightColumn.className = 'column';

    var newRightRadioContainer = document.createElement('div');
    newRightRadioContainer.className = 'select';

    var newRightRadioButton = document.createElement('input');
    newRightRadioButton.type = 'radio';
    newRightRadioButton.name = 'column-select';
    newRightRadioButton.id = 'select-right-column';
    newRightRadioButton.checked = '';
    newRightRadioContainer.appendChild(newRightRadioButton);

    var newLabelRight = document.createElement('label');
    newLabelRight.htmlFor = 'select-right-column';
    newLabelRight.innerHTML = 'Add here';
    newRightRadioContainer.appendChild(newLabelRight);

    newRightColumn.appendChild(newRightRadioContainer);

    var newRightOl = document.createElement('ol');
    newRightOl.id = 'right-ol';

    for (var j = 0, lenRight = defaultRight.length; j < lenRight; j += 1) {
      if (typeof defaultRight[j] === 'string' && defaultRight[j] !== '') {
        var newLiRight = document.createElement('li');
        newLiRight.className = 'entry';
        newLiRight.innerHtml = defaultRight[j];

        var newImgRight = document.createElement('img');
        newImgRight.className = 'delete';
        newImgRight.src = 'imgs/Remove-icon.png'; 
        newImgRight.addEventListener('click', deleteItem);       
        newLiRight.appendChild(newImgRight);      
        newLiRight.innerHTML += defaultRight[j];
        newRightOl.appendChild(newLiRight);
      }
    }

    newRightColumn.appendChild(newRightOl);

    newColumnContainer.appendChild(newRightColumn);

    // column container input
    var newColumnContainerInput = document.createElement('input');
    newColumnContainerInput.size = '40';
    newColumnContainerInput.autofocus = 'autofocus';

    // column container button
    var newColumnContainerButton = document.createElement('button');
    newColumnContainerButton.innerHTML = 'Add';
    newColumnContainerButton.addEventListener('click', addItem);

    fragment.appendChild(newColumnContainer);
    fragment.appendChild(newColumnContainerInput);
    fragment.appendChild(newColumnContainerButton);

    root.appendChild(fragment);
  };
}

// SUBMIT THE CODE ABOVE THIS LINE

if(typeof module !== 'undefined') {
  module.exports = solve;
}
