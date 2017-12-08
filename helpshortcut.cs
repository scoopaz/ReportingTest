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
		public XVar helpshortcut()
		{
			try
			{
				dynamic templatefile = null;
				XTempl xt;
				CommonFunctions.add_nocache_headers();
				xt = XVar.UnPackXTempl(new XTempl());
				xt.display((XVar)(templatefile));
				return MVCFunctions.GetBuferContentAndClearBufer();
			}
			catch(RunnerRedirectException ex)
			{ return Redirect(ex.Message); }
		}
	}
}
