//Toggles display of the BPF. Takes the formcontext and the the name of the twoOption field that was changed as a string.
'use strict';
function showHideBusinessProcessFlow(eContext, twoOptionFieldName) {
    var formContext = eContext.getFormContext(); 
    var twoOptionFieldValue = formContext.getAttribute(twoOptionFieldName).getValue();

    if (twoOptionFieldValue == null || twoOptionFieldValue == 'undefined') return;
    formContext.ui.process.setVisible(twoOptionFieldValue); //Shows BPF if twoOptionFieldValue is true, hides if false
}