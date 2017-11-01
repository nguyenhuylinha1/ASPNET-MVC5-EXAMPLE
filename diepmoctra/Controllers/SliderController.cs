using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using diepmoctra.Models;

namespace diepmoctra.Controllers
{
    public class SliderController : Controller
    {
        //
        // GET: /Slider/
        DiepMocTraEntities db = new DiepMocTraEntities();

        public PartialViewResult SliderPartial(int numberRecord = 5)
        {
            var imagesSlider = db.Advertises.Where(a => a.Lang == "vi" && a.Position == 2 && a.Active == 1 && a.Image != "")
                .Take(numberRecord).OrderBy(a => a.Ord).ToList();
            return PartialView(imagesSlider);
        }
    }
}
