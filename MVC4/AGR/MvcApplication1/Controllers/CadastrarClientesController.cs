using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CadastrarClientesController : Controller
    {
        //
        // GET: /CadastrarClientes/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /CadastrarClientes/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /CadastrarClientes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CadastrarClientes/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /CadastrarClientes/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CadastrarClientes/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /CadastrarClientes/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CadastrarClientes/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
