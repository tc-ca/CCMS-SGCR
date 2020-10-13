namespace CCMS.HRCase {
  var Form: Form.hr_hrcase.Main.Information;

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
    var closedonField = Form.getAttribute("hr_closedon");

    //When case status is set to closed
    if (statusfield.getValue() != hr_casestatus.Closed && statusfield.getValue() != hr_casestatus.WithdrawnbyPay) {
      return;
    }

    if (closedonField.getValue() != null) {
      return;
    }

    var globalContext = Xrm.Utility.getGlobalContext();
    var confirmStrings = {
      text: "Are you sure you want to close this case?",
      title: "",
    };
    if (globalContext.userSettings.languageId == 1036) {
      confirmStrings.text = "Êtes-vous certain(e) de vouloir fermer ce cas?";
      confirmStrings.title = "";
    }
    var confirmOptions = { height: 200, width: 450 };
    Xrm.Navigation.openConfirmDialog(confirmStrings, confirmOptions).then(
      function (success) {
        if (success.confirmed) {
          closedonField.setValue(new Date());
          Form.data.save();
        } else {
          //do nothing
        }
      }
    );
  }
}
