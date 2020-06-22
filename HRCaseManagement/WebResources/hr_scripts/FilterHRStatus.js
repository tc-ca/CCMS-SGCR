'use strict';
function FilterHRStatus(eContext, fieldName, value){
    var formContext = eContext.getFormContext();   

    var field = formContext.getAttribute(fieldName);
    if (field == null || field == 'undefined') return;

    formContext .getControl(fieldName).removeOption(value);
}