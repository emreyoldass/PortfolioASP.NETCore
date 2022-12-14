using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.NETCore.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager experinceManager = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experinceManager.TGetList();
            return View(values);
        }
    }
}

