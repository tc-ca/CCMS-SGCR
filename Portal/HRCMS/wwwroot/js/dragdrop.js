// UPLOAD CLASS DEFINITION
// ======================

var dropZone = $('#drop-zone');
var uploadForm = $('#js-upload-form');

var startUpload = function (files) {
  console.log(files)
}

uploadForm.on('submit', function (e) {
  var uploadFiles = $('#js-upload-files').files;
  e.preventDefault()

  startUpload(uploadFiles)
})

dropZone.on("drop", function (e) {
  e.preventDefault();
  var target = $(e.target);
  target.removeClass('drop');

  startUpload(e.originalEvent.dataTransfer.files)
});

dropZone.on("dragover", function (e) {
  var target = $(e.target);
  target.addClass('drop');
  return false;
});

dropZone.on("dragleave", function (e) {
  var target = $(e.target);
  target.removeClass('drop');
  return false;
});