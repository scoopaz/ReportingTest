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
		public ActionResult menu()
		{
			try
			{
				dynamic id = null, pageObject = null, redirect = null, var_params = XVar.Array();
				XTempl xt;
				Security.processLogoutRequest();
				if(XVar.Pack(!(XVar)(CommonFunctions.isLogged())))
				{
					MVCFunctions.HeaderRedirect(new XVar("login"));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				if((XVar)(XSession.Session["MyURL"] == "")  || (XVar)(!(XVar)(CommonFunctions.isLoggedAsGuest())))
				{
					Security.saveRedirectURL();
				}
{

TLayout t_layout = null;

t_layout = new TLayout(new XVar("menu_bootstrap1"), new XVar("BoldOffice"), new XVar("MobileOffice"));
t_layout.version = 3;
	t_layout.bootstrapTheme = "darkly";
			t_layout.customCssPageName = "_menu";
t_layout.blocks["top"] = XVar.Array();
t_layout.containers["menu"] = XVar.Array();
t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "hdr" ));
t_layout.containers["hdr"] = XVar.Array();
t_layout.containers["hdr"].Add(new XVar("name", "logo", "block", "logo_block", "substyle", 1  ));

t_layout.containers["hdr"].Add(new XVar("name", "bsnavbarcollapse", "block", "collapse_block", "substyle", 1  ));

t_layout.skins["hdr"] = "";


t_layout.containers["menu"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "menu_1" ));
t_layout.containers["menu_1"] = XVar.Array();
t_layout.containers["menu_1"].Add(new XVar("name", "hmenu", "block", "menu_block", "substyle", 1  ));

t_layout.containers["menu_1"].Add(new XVar("name", "wrapper", "block", "", "substyle", 1 , "container", "login" ));
t_layout.containers["login"] = XVar.Array();
t_layout.containers["login"].Add(new XVar("name", "morebutton", "block", "more_list", "substyle", 1  ));

t_layout.containers["login"].Add(new XVar("name", "loggedas", "block", "security_block", "substyle", 1  ));

t_layout.skins["login"] = "";


t_layout.skins["menu_1"] = "";


t_layout.skins["menu"] = "";

t_layout.blocks["top"].Add("menu");
t_layout.containers["center"] = XVar.Array();
t_layout.containers["center"].Add(new XVar("name", "welcome", "block", "", "substyle", 1  ));

t_layout.skins["center"] = "";

t_layout.blocks["top"].Add("center");
GlobalVars.page_layouts["menu"] = t_layout;


}

				xt = XVar.UnPackXTempl(new XTempl());
				id = XVar.Clone((XVar.Pack(!XVar.Equals(XVar.Pack(MVCFunctions.postvalue(new XVar("id"))), XVar.Pack(""))) ? XVar.Pack(MVCFunctions.postvalue(new XVar("id"))) : XVar.Pack(1)));
				var_params = XVar.Clone(XVar.Array());
				var_params.InitAndSetArrayItem(id, "id");
				var_params.InitAndSetArrayItem(xt, "xt");
				var_params.InitAndSetArrayItem(Constants.NOT_TABLE_BASED_TNAME, "tName");
				var_params.InitAndSetArrayItem(Constants.PAGE_MENU, "pageType");
				var_params.InitAndSetArrayItem("menu.cshtml", "templatefile");
				var_params.InitAndSetArrayItem(GlobalVars.isGroupSecurity, "isGroupSecurity");
				var_params.InitAndSetArrayItem(false, "needSearchClauseObj");
				GlobalVars.pageObject = XVar.Clone(new RunnerPage((XVar)(var_params)));
				GlobalVars.pageObject.init();
				GlobalVars.pageObject.commonAssign();
				if(XVar.Pack(GlobalVars.globalEvents.exists(new XVar("BeforeProcessMenu"))))
				{
					GlobalVars.globalEvents.BeforeProcessMenu((XVar)(GlobalVars.pageObject));
				}
				GlobalVars.pageObject.body["begin"] = MVCFunctions.Concat(GlobalVars.pageObject.body["begin"], CommonFunctions.GetBaseScriptsForPage(new XVar(false)));
				GlobalVars.pageObject.addCommonJs();
				GlobalVars.pageObject.fillSetCntrlMaps();
				GlobalVars.pageObject.setLangParams();
				xt.assign(new XVar("id"), (XVar)(id));
				xt.assign(new XVar("username"), (XVar)(XSession.Session["UserName"]));
				xt.assign(new XVar("changepwd_link"), (XVar)((XVar)(XSession.Session["AccessLevel"] != Constants.ACCESS_LEVEL_GUEST)  && (XVar)(XSession.Session["fromFacebook"] == false)));
				xt.assign(new XVar("changepwdlink_attrs"), (XVar)(MVCFunctions.Concat("onclick=\"window.location.href='", MVCFunctions.GetTableLink(new XVar("changepwd")), "';return false;\"")));
				xt.assign(new XVar("logoutlink_attrs"), (XVar)(MVCFunctions.Concat("id=\"logoutButton", id, "\"")));
				xt.assign(new XVar("guestloginlink_attrs"), (XVar)(MVCFunctions.Concat("id=\"loginButton", id, "\"")));
				xt.assign(new XVar("loggedas_block"), (XVar)(!(XVar)(CommonFunctions.isLoggedAsGuest())));
				xt.assign(new XVar("loggedas_message"), (XVar)(!(XVar)(CommonFunctions.isLoggedAsGuest())));
				xt.assign(new XVar("logout_link"), new XVar(true));
				xt.assign(new XVar("guestloginbutton"), (XVar)(CommonFunctions.isLoggedAsGuest()));
				xt.assign(new XVar("logoutbutton"), (XVar)((XVar)(CommonFunctions.isSingleSign())  && (XVar)(!(XVar)(CommonFunctions.isLoggedAsGuest()))));
				if(XVar.Pack(CommonFunctions.IsAdmin()))
				{
					xt.assign(new XVar("adminarea_link"), new XVar(true));
				}
				redirect = XVar.Clone(GlobalVars.pageObject.getRedirectForMenuPage());
				if(XVar.Pack(redirect))
				{
					MVCFunctions.HeaderRedirect((XVar)(MVCFunctions.Concat("", redirect)));
					MVCFunctions.Echo(new XVar(""));
					return MVCFunctions.GetBuferContentAndClearBufer();
				}
				xt.assign(new XVar("menu_block"), new XVar(true));
				if(XVar.Pack(GlobalVars.globalEvents.exists(new XVar("BeforeShowMenu"))))
				{
					new Func<XVar>(() => { var GlobalVars_pageObject_templatefile_byref = GlobalVars.pageObject.templatefile; var result = GlobalVars.globalEvents.BeforeShowMenu((XVar)(xt), ref GlobalVars_pageObject_templatefile_byref, (XVar)(GlobalVars.pageObject)); GlobalVars.pageObject.templatefile = GlobalVars_pageObject_templatefile_byref; return result; }).Invoke();
				}
				GlobalVars.pageObject.body["end"] = MVCFunctions.Concat(GlobalVars.pageObject.body["end"], "<script>");
				GlobalVars.pageObject.body["end"] = MVCFunctions.Concat(GlobalVars.pageObject.body["end"], "window.controlsMap = ", MVCFunctions.my_json_encode((XVar)(GlobalVars.pageObject.controlsHTMLMap)), ";");
				GlobalVars.pageObject.body["end"] = MVCFunctions.Concat(GlobalVars.pageObject.body["end"], "window.viewControlsMap = ", MVCFunctions.my_json_encode((XVar)(GlobalVars.pageObject.viewControlsHTMLMap)), ";");
				GlobalVars.pageObject.body["end"] = MVCFunctions.Concat(GlobalVars.pageObject.body["end"], "Runner.applyPagesData( ", MVCFunctions.my_json_encode((XVar)(GlobalVars.pagesData)), " );");
				GlobalVars.pageObject.body["end"] = MVCFunctions.Concat(GlobalVars.pageObject.body["end"], "window.settings = ", MVCFunctions.my_json_encode((XVar)(GlobalVars.pageObject.jsSettings)), ";</script>");
				GlobalVars.pageObject.body["end"] = MVCFunctions.Concat(GlobalVars.pageObject.body["end"], "<script type=\"text/javascript\" src=\"", MVCFunctions.GetRootPathForResources(new XVar("include/runnerJS/RunnerAll.js")), "\"></script>");
				GlobalVars.pageObject.body["end"] = MVCFunctions.Concat(GlobalVars.pageObject.body["end"], "<script>", GlobalVars.pageObject.PrepareJS(), "</script>");
				xt.assignbyref(new XVar("body"), (XVar)(GlobalVars.pageObject.body));
				GlobalVars.pageObject.display((XVar)(GlobalVars.pageObject.templatefile));
				ViewBag.xt = xt;
				return View(xt.GetViewPath());
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
