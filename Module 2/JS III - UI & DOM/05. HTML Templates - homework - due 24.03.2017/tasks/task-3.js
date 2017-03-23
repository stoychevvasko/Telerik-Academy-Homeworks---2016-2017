function solve(){
  return function(){
    $.fn.listview = function(data){
      var $this = $(this);
      var id = '#' + $this.attr('data-template');
      var template = $(id).html();
      var html = handlebars.compile(template);
      for (var i = 0; i < data.length; i += 1)
      {
        $this.append(html(data[i]));
      }
    };
  };
}

module.exports = solve;
