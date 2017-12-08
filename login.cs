using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using runnerDotNet;
namespace runnerDotNet
{
	public partial class GlobalController : BaseController
	{
		public ActionResult login()
		{
			try
			{
				dynamic pageObject = null, var_params = XVar.Array();
				XTempl xt;
				CommonFunctions.add_nocache_headers();
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("bootstrap4"), new XVar("BoldOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "darkly";
			t_layout.customCssPageName = "_login";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["page"] = XVar.Array();
t_layout.containers["page"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "top" ));
t_layout.containers["top"] = XVar.Array();
t_layout.containers["top"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.skins["top"] = "";


t_layout.containers["page"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "page_1" ));
t_layout.containers["page_1"] = XVar.Array();
t_layout.containers["page_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "panel" ));
t_layout.containers["panel"] = XVar.Array();
t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header" ));
t_layout.containers["header"] = XVar.Array();
t_layout.containers["header"].Add(new XVar("name", "loginheader", "block", "loginheader", "substyle", 1  ));

t_layout.skins["header"] = "";


t_layout.containers["panel"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "body" ));
t_layout.containers["body"] = XVar.Array();
t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header_1" ));
t_layout.containers["header_1"] = XVar.Array();
t_layout.containers["header_1"].Add(new XVar("name", "message", "block", "message_block", "substyle", 1  ));

t_layout.skins["header_1"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "fields" ));
t_layout.containers["fields"] = XVar.Array();
t_layout.containers["fields"].Add(new XVar("name", "loginfields", "block", "", "substyle", 1  ));

t_layout.skins["fields"] = "";


t_layout.containers["body"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "header_2" ));
t_layout.containers["header_2"] = XVar.Array();
t_layout.containers["header_2"].Add(new XVar("name", "loginbuttons", "block", "loginbuttons", "substyle", 1  ));

t_layout.skins["header_2"] = "";


t_layout.skins["body"] = "";


t_layout.skins["panel"] = "";


t_layout.containers["page_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "register" ));
t_layout.containers["register"] = XVar.Array();
t_layout.containers["register"].Add(new XVar("name", "bsloginregister", "block", "", "substyle", 1  ));

t_layout.skins["register"] = "";


t_layout.skins["page_1"] = "";


t_layout.skins["page"] = "";

t_layout.blocks["top"].Add("page");
GlobalVars.page_layouts["login"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("id")), "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(Constants.PAGE_LOGIN, "pageType");
				var_params.InitAndSetArrayItem(Constants.NOT_TABLE_BASED_TNAME, "tName");
				var_params.InitAndSetArrayItem("login.cshtml", "templatefile");
				var_params.InitAndSetArrayItem(false, "needSearchClauseObj");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("value_captcha_1")), "captchaValue");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("notRedirect")), "notRedirect");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("remember_password")), "rememberPassword");
				var_params.InitAndSetArrayItem(LoginPage.readLoginModeFromRequest(), "mode");
				var_params.InitAndSetArrayItem(LoginPage.readActionFromRequest(), "action");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("message")), "message");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("username")), "var_pUsername");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("password")), "var_pPassword");
				var_params.InitAndSetArrayItem(MVCFunctions.postvalue(new XVar("return")), "redirectAfterLogin");
				GlobalVars.pageObject = XVar.Clone(new LoginPage((XVar)(var_params)));
				GlobalVars.pageObject.init();
				GlobalVars.pageObject.process();
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
