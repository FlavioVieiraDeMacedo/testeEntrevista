    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestePleno.Services;
using TestePleno.WR_Magento;

namespace TestePleno.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult Index(string IdProduct)
        {
            Service service = new Service();
            var credential = service.LogIn();
            var result = service.GetProductById(credential, IdProduct);
            if (result!=null)
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var respost = new
                {
                    Status = "Nenhum produto encontrado!"
                };
                return Json(respost, JsonRequestBehavior.AllowGet);
            }
        }
        
    }
}