'use strict';
function addStageOnChange(eContext) {
    var formContext = eContext.getFormContext();
    //Whenever the stage changes trigger an onchange function
    formContext.data.process.addOnStageChange(function() {
        stageOnChange(eContext);
    });
}
  
function stageOnChange(eContext) {
    var formContext = eContext.getFormContext();
    stageName = formContext.data.process.getActiveStage().getName();
    if (stageName == "Assign") {

        formContext.getAttribute('hr_casestatus').setValue(315840000)
        
    } else if (stageName == "In-Progress") {

        formContext.getAttribute('hr_casestatus').setValue(315840003)

    } else if (stageName == "Complete") {

        formContext.getAttribute('hr_casestatus').setValue(315840004)

    }
}