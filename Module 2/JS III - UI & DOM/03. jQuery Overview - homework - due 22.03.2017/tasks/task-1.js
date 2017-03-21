/* globals $ */

function solve() {
  return function (selector, count) {
    if (typeof selector !== 'string' || selector.length === 0) {
      throw Error('invalid selector!');
    }

    if (typeof count !== 'number' || count <= 0) {
      throw Error('invalid count!');
    }

    var element = $(selector);
    var ul = $('<ul />')
      .addClass('items-list')
      .appendTo(element);

    for (var index = 0; index < count; index += 1) {
      var li = $('<li />')
        .addClass('list-item')
        .text('List item #' + index);

      li.appendTo(ul);
    }
  };
};

module.exports = solve;
