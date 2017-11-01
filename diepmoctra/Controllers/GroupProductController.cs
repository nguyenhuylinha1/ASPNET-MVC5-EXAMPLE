using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using diepmoctra.Models;

namespace diepmoctra.Controllers
{
    public class GroupProductController : Controller
    {
        //
        // GET: /GroupProduct/
        DiepMocTraEntities db = new DiepMocTraEntities();

        public PartialViewResult GroupProductPartial(int numberRecord = 4)
        {
            var groupProducts = db.GroupProducts.Where(a => a.Lang == "vi" && a.Active == 1)
                .Take(numberRecord).OrderBy(a => a.Ord).ToList();
            return PartialView(groupProducts);
        }
    }
}
