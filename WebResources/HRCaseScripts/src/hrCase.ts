namespace CCMS.HRCase {
  var Form: Form.hr_hrcase.Main.Information;
  var saveInProgress=false;
  
  export function FilterHRStatus(eContext: Xrm.ExecutionContext<any, any>) {
    Form = <Form.hr_hrcase.Main.Information>eContext.getFormContext();

    var control = Form.getControl("header_hr_casestatus");
    control.removeOption(hr_casestatus.Saved);
  }

  export function ShowCloseCaseConfirmation(
    eContext: Xrm.ExecutionContext<any, any>
  ) {
    Form = <Form.hr_hrcase.Main.Information>eContext.getFormContext();
    var statusfield = Form.getAttribute("hr_casestatus");
    var resolutionField = Form.getAttribute("hr_resolution");

    //When case status is set to closed
    if (
      statusfield.getValue() != hr_casestatus.Closed &&
      statusfield.getValue() != hr_casestatus.WithdrawnbyPay
    ) {
      return;
    }

    var globalContext = Xrm.Utility.getGlobalContext();
    var confirmStrings = {
      text: "Are you sure you want to close this case?",
      title: "",
    };

    if (statusfield.getValue() == hr_casestatus.Closed) {
      if (globalContext.userSettings.languageId == 1036) {
        confirmStrings = {
          text: "Êtes-vous certain(e) de vouloir fermer ce cas?",
          title: "",
        };
      }
    } else if (statusfield.getValue() == hr_casestatus.WithdrawnbyPay) {
      if (globalContext.userSettings.languageId == 1033) {
        confirmStrings = {
          text: "Are you sure you want to withdraw this case?",
          title: "",
        };
      }
      else{
        confirmStrings = {
          text: "Etes-vous sûr de vouloir retirer ce cas?",
          title: "",
        };
      }
    }

    if (!saveInProgress){
      saveInProgress=true;
      eContext.getEventArgs().preventDefault();     
      var confirmOptions = { height: 200, width: 450 };
      Xrm.Navigation.openConfirmDialog(confirmStrings, confirmOptions).then(
      function (success) {
        if (success.confirmed) {
          //Do nothing
          Form.data.save().then(() => {saveInProgress=false;});
        } 
        else {
          //do nothing
          saveInProgress=false;
        }
      }
    );
    }
  }
}
