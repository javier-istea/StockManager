using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockManager.Repositories;
using StockManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace StockManager.Controllers
{
    [Authorize]
    public class TiposDePrendasController : Controller
    {


        protected readonly ITipoDePrendaRepository repo;

        public TiposDePrendasController(ITipoDePrendaRepository _repo)
        {
            this.repo = _repo;
        }
        // GET: TiposDePrendas
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        // GET: TiposDePrendas/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.GetByID(id));
        }

        // GET: TiposDePrendas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposDePrendas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoDePrenda model)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                repo.Add(model);
                repo.save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TiposDePrendas/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repo.GetByID(id));
        }

        // POST: TiposDePrendas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TipoDePrenda model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                repo.Update(model);
                repo.save();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TiposDePrendas/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repo.GetByID(id));
        }

        // POST: TiposDePrendas/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                repo.Del(id);
                repo.save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}