using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(CreateUser());
        }

        public User CreateUser()
        {
            User user = new User()
            {
                Name = "이준혁",
                Address = "서울특별시 동대문구 용두동 793 BYC 청량리 오피스텔"
            };

            return user;
        }
    }
}
