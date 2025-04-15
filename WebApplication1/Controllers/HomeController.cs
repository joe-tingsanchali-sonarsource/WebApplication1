using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private static bool HasContent(IEnumerable<string> strings)
        {
            var tripleDES1 = new TripleDESCryptoServiceProvider(); // Noncompliant: Triple DES is vulnerable to meet-in-the-middle attack
            var simpleDES = new DESCryptoServiceProvider(); // Noncompliant: DES works with 56-bit keys allow attacks via exhaustive search
            var RC2 = new RC2CryptoServiceProvider(); // Noncompliant: RC2 is vulnerable to a related-key attack
            
            return strings.Count() > 0;  // Noncompliant
        }

        public void MyMethod<T>()  // Noncompliant
        {
            // this method can only be invoked by providing the type argument e.g. 'MyMethod<int>()'
        }

        try
        {
        // do something that might throw a FileNotFoundException or IOException
        }
        catch (Exception e) // Noncompliant
        {
        // log exception ...
}
    }
}