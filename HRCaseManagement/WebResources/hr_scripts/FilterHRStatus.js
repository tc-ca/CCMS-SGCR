"use strict";
var CCMS;
(function (CCMS) {
    var HRCase;
    (function (HRCase) {
        var Form;
        function FilterHRStatus(eContext) {
            Form = eContext.getFormContext();
            var control = Form.getControl("header_hr_casestatus");
            control.removeOption(315840002 /* Saved */);
        }
        HRCase.FilterHRStatus = FilterHRStatus;
        function ShowCloseCaseConfirmation(eContext) {
            Form = eContext.getFormContext();
            var statusfield = Form.getAttribute("hr_casestatus");
            var resolutionField = Form.getAttribute("hr_resolution");
            var closedonField = Form.getAttribute("hr_closedon");
            //When case status is set to closed
            if (statusfield.getValue() != 315840004 /* Closed */) {
                return;
            }
            if (closedonField.getValue() != null) {
                return;
            }
            var globalContext = Xrm.Utility.getGlobalContext();
            var confirmStrings = {
                text: "Are you sure you want to close this case?",
                title: "Close case confirmation",
            };
            if (globalContext.userSettings.languageId == 1036) {
                confirmStrings.text = "Are you sure you want to close this case? (fr)";
                confirmStrings.title = "Close case confirmation (fr)";
            }
            var confirmOptions = { height: 200, width: 450 };
            Xrm.Navigation.openConfirmDialog(confirmStrings, confirmOptions).then(function (success) {
                if (success.confirmed) {
                    console.log("Dialog closed using OK button.");
                    closedonField.setValue(new Date());
                    Form.data.save();
                }
                else {
                    //do nothing
                }
            });
        }
        HRCase.ShowCloseCaseConfirmation = ShowCloseCaseConfirmation;
    })(HRCase = CCMS.HRCase || (CCMS.HRCase = {}));
})(CCMS || (CCMS = {}));
