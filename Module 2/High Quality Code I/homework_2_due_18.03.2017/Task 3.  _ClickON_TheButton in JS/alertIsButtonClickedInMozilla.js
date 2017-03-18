function alertIsButtonClickedInMozilla(event, arguments) {
  var windowSelected = window,
    browserSelected = windowSelected.navigator.appCodeName,
    isMozilla = browserSelected == "Mozilla";
  if (isMozilla) {
    alert("button clicked in Mozilla browser");
  } else {
    alert("another browser was used");
  }
}
