using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Diplom.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace Diplom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Diplom.Models.HTML.HomePage homePageData = new Models.HTML.HomePage();
            if (HttpContext.Session.TryGetValue("UserID", out byte[] result))
            {
                using (var context = new OhranaContext())
                {
                    List<User> dataToDictionaryUser;
                    dataToDictionaryUser = context.User.Where(d => d.UserID == HttpContext.Session.GetInt32("UserID")).ToList();
                    if (dataToDictionaryUser.Count() == 1)
                    {
                        homePageData.Autorize = true;
                        homePageData.AccFamilyName = dataToDictionaryUser[0].UserSName;
                        homePageData.AccFirstName = dataToDictionaryUser[0].UserName; ;
                        homePageData.AccPatronymic = dataToDictionaryUser[0].UserPatronymic;
                        if (HttpContext.Session.GetInt32("Privilege1") == 1)
                        {
                            homePageData.Privilege1 = true;
                        }
                        else
                        {
                            homePageData.Privilege1 = false;
                        }
                    }
                }
            }
            else
            {
                homePageData.Autorize = false;
            }

            return View(homePageData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
