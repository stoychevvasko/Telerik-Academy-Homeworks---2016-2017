function solve(){
  return function (selector) {
    var wrapper = $('<div />').addClass('dropdown-list');

    var options = $(selector).find('option');

    var div = $('<div />')
      .addClass('options-wrapper')
      .css({ 'position': 'absolute', 'display': 'none' });

    $(selector).css('display', 'none').appendTo(wrapper);

    $('<div class="current" data-value="">Option 1</div>').appendTo(wrapper);

    for (var i = 1; i < options.length + 1; i += 1) {
      var item = $(
        '<div class="dropdown-item" data-value="' + i + 
          '" data-index="' + i + 
          '">Option' + i + '</div>')
        .addClass('dropdown-item');

      item.appendTo(div);
    }

    div.appendTo(wrapper);

    $(document.body).append(wrapper);

    $('.current').on('click', function () {
      div.css('display', 'block');
      $(this).html('Select a value');
    });

    div.on('click', '.dropdown-item', function () {
      div.css('display', 'none');
      $(selector).val($(this).attr('data-value'));
      $('.current').html($(this).html());
    });
  };
}

module.exports = solve;
