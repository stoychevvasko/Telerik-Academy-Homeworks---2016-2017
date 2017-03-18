function alertIsButtonClickedInMozilla(event, arguments) {
  var windowSelected = window,
    browserSelected = windowSelected.navigator.appCodeName,
    isMozilla = browserSelected == "Mozilla";
  if (isMozilla) {
    alert("yes Mozilla");
  } else {
    alert("not Mozilla");
  }
}
