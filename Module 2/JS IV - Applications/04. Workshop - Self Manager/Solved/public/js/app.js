(function(){
  var sammyApp = Sammy('#content', function(){
    this.get('#/', function(){
      this.redirect('#/home')
    });

    this.get('#/home', homeController.all);
	this.get('#/home/login', loginController.all);
  });

  $(function(){
    sammyApp.run('#/');
  })

}());
