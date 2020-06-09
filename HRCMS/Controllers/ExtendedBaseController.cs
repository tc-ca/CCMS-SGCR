using GoC.WebTemplate.Components.Configs;
using GoC.WebTemplate.Components.Core.Services;
using GoC.WebTemplate.Components.Entities;
using GoC.WebTemplate.CoreMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace HRCMS.Controllers
{
    public class ExtendedBaseController : WebTemplateBaseController
    {
        //public string UserName = "Mr. Fancy Pants";

        public ExtendedBaseController(ModelAccessor modelAccessor)
            : base(modelAccessor)
        {
            //Set a the common title for everypage here
            WebTemplateModel.HeaderTitle = "HR Case Management System";      
            //Metatags
            WebTemplateModel.HTMLHeaderElements.Add("<meta charset='UTF-8'>");
            WebTemplateModel.HTMLHeaderElements.Add("<meta http-equiv='default-style' content='sample'>");

            //Date Modifiied
            WebTemplateModel.DateModified = new DateTime(2020, 04, 21);

            //Version Identifier
            WebTemplateModel.VersionIdentifier = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

            //Screen Identifier
            //WebTemplateModel.ScreenIdentifier = "BASE-SETTING-SAMPLE";

            //Contact Links
            //WebTemplateModel.ContactLinks.Add(new GoC.WebTemplate.Components.Entities.Link { Text="Contact", Href = "http://travel.gc.ca/" });

            //WebTemplateModel.Settings.Environment = "PROD_SSL";

            //WebTemplateModel.HTMLHeaderElements.Add("<link rel='stylesheet' type='text/css' href='/css/site.css'>");

            WebTemplateModel.ApplicationTitle.Text = "HRCMS";
            WebTemplateModel.ApplicationTitle.Href = "../hrcase/list";


            //custom intranet title
            //WebTemplateModel.IntranetTitle = new IntranetTitle
            //{
            //    Href = "http://mytc",
            //    BoldText = "HR",
            //    Acronym = "Human Resource",
            //    Text = " CMS"
            //};

            WebTemplateModel.Settings.ShowPreContent = false;
            WebTemplateModel.HTMLBodyElements.Add("<script src='/js/site.js'></script>");

        }

    }
}