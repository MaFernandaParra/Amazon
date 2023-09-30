using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amazon.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Detalles(int id)
        //{
        //    var producto = ObtenerDetallesDelProducto(id);
        //    return View(producto);
        //}
    }
}