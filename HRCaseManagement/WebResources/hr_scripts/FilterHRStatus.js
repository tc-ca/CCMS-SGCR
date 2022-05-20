"use strict";
var CCMS;
(function (CCMS) {
    var HRCase;
    (function (HRCase) {
        var Form;
        var saveInProgress = false;
        function FilterOwnerList(eContext) {
            Form = eContext.getFormContext();
            if (Form.ui.getFormType() == 1 || Form.ui.getFormType() == 2) {
                var ownerControl = Form.getControl("header_ownerid");
                if (ownerControl.getEntityTypes().length > 1) {
                    ownerControl.setEntityTypes(['systemuser']);
                    var defaultViewId = '7cfaa4e9-6fb6-ec11-983e-000d3a09c603';
                    ownerControl.setDefaultView(defaultViewId);
                }
            }
        }
        HRCase.FilterOwnerList = FilterOwnerList;
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
            //When case status is set to closed
            if (statusfield.getValue() != 315840004 /* Closed */ &&
                statusfield.getValue() != 315840005 /* WithdrawnbyPay */) {
                return;
            }
            var globalContext = Xrm.Utility.getGlobalContext();
            var confirmStrings = {
                text: "Are you sure you want to close this case?",
                title: "",
            };
            if (statusfield.getValue() == 315840004 /* Closed */) {
                if (globalContext.userSettings.languageId == 1036) {
                    confirmStrings = {
                        text: "Êtes-vous certain(e) de vouloir fermer ce cas?",
                        title: "",
                    };
                }
            }
            else if (statusfield.getValue() == 315840005 /* WithdrawnbyPay */) {
                if (globalContext.userSettings.languageId == 1033) {
                    confirmStrings = {
                        text: "Are you sure you want to withdraw this case?",
                        title: "",
                    };
                }
                else {
                    confirmStrings = {
                        text: "Etes-vous sûr de vouloir retirer ce cas?",
                        title: "",
                    };
                }
            }
            if (!saveInProgress) {
                saveInProgress = true;
                eContext.getEventArgs().preventDefault();
                var confirmOptions = { height: 200, width: 450 };
                Xrm.Navigation.openConfirmDialog(confirmStrings, confirmOptions).then(function (success) {
                    if (success.confirmed) {
                        //Do nothing
                        Form.data.save().then(function () { saveInProgress = false; });
                    }
                    else {
                        //do nothing
                        saveInProgress = false;
                    }
                });
            }
        }
        HRCase.ShowCloseCaseConfirmation = ShowCloseCaseConfirmation;
    })(HRCase = CCMS.HRCase || (CCMS.HRCase = {}));
})(CCMS || (CCMS = {}));
