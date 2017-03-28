function solve(selector) {
  var data = {
    titles: 
      [ { text: "Tab 1", link: "tab-1" },
        { text: "Tab 2", link: "tab-2" },
        { text: "Tab 3", link: "tab-3" }
      ],
    contents: 
      [ { link: "tab-1", text: "Tab 1, no so special..." }, 
        { link: "tab-2", text: "<p>Some text in a p</p><a href=\"#\">a link</a>" }, 
        { link: "tab-3", text: "<strong>And a list</strong><ul><li>Just</li><li>a</li><li>regular</li><li>list</li></ul>" }
      ]
  };

  var template = [
    '<div id="tabs">',
        '<div class="tabs-control">',
          '<ul class="list list-titles">',
            '{{#titles}}',
              ('<li class="list-item"><label for="' + '{{link}}' + '" class="title">' + '{{text}}' + '</label></li>'),
            '{{/titles}}',
          '</ul>',
          '<ul class="list list-contents">',
            '{{#contents}}',
              '<li class="list-item">',
                '<input class="tab-content-toggle" id="{{link}}" name="tab-toggles" checked="checked/" type="radio">',
                '<div class="content">{{text}}</div>',
              '</li>',
            '{{/contents}}',
          '</ul>',
        '</div>',
    '</div>'
  ].join('');

return template;
}

if(typeof module !== 'undefined') {
  module.exports = solve;
}
