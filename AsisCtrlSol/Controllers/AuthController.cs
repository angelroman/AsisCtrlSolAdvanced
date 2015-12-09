using AsisCtrlSol.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsisCtrlSol.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult SignUp()
        {
            return View();
        }

        private EstudianteMateriasContexto db = new EstudianteMateriasContexto();

        [HttpPost]
        public JsonResult Login(string usr, string pass)
        {
            char login = '0';
            //Compara nombre de usuario y password, si devuelve un registro significa que encontro al usuario
            int sql = (from dbUser in db.Usuarios
                       where ((dbUser.username == usr) && (dbUser.password == pass))
                       select new { dbUser.username, dbUser.password }).Count();
            if (sql == 1)
            {
                login = '1'; //Login correcto
            }
            return Json(new
            {
                Usuario = usr,
                Login = login
            },
                JsonRequestBehavior.AllowGet
            );
        }
    }
}