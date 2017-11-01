using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using diepmoctra.Models;

namespace diepmoctra.Controllers
{
    public class ProductTabSessionController : Controller
    {
        //
        // GET: /PageContent/
        DiepMocTraEntities db = new DiepMocTraEntities();

        public PartialViewResult ProductTabSessionPartial()
        {
            var groupProducts = db.GroupProducts.Where(g => g.Lang == "vi" && g.Active == 1).ToList();
            return PartialView(groupProducts);
        }

    }
}
