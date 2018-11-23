using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockManager.Models;
using StockManager.Repositories;
using StockManager.ViewModel;

namespace StockManager.Controllers
{
    [Authorize]
    public class PrendasController : Controller
    {

        protected readonly IPrendaRepository prendaRepository;
        protected readonly ITipoDePrendaRepository tipoDePrendaRepository;

        public PrendasController(IPrendaRepository prendaRepository, ITipoDePrendaRepository tipoDePrendaRepository)
        {
            this.prendaRepository = prendaRepository;
            this.tipoDePrendaRepository = tipoDePrendaRepository;
        }

        // GET: Prendas
        public ActionResult Index()
        {
            var tiposDePrendas = tipoDePrendaRepository.GetAll();
            return View(prendaRepository.GetAll().Select(x => {
                x.TipoDePrenda = tiposDePrendas.First(t => t.TipoDePrendaId == x.TipoDePrendaID);
                return x;
            }));
        }

        // GET: Prendas/Details/5
        public ActionResult Details(int id)
        {
            return View(prendaRepository.GetByID(id));
        }

        // GET: Prendas/Create
        public ActionResult Create()
        {
            PrendaViewModel prendaViewModel = new PrendaViewModel
            {
                TiposDePrendas = tipoDePrendaRepository.GetAll()
            };
            return View(prendaViewModel);
        }

        // POST: Prendas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prenda model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                prendaRepository.Add(model);
                prendaRepository.save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prendas/Edit/5
        public ActionResult Edit(int id)
        {
            Prenda prenda = prendaRepository.GetByID(id);
            PrendaViewModel prendaViewModel = new PrendaViewModel
            {
                Color = prenda.Color,
                PrendaID = prenda.PrendaID,
                Descripcion = prenda.Descripcion,
                Talle = prenda.Talle,
                TipoDePrendaID = prenda.TipoDePrendaID,
                TiposDePrendas = tipoDePrendaRepository.GetAll()
            };
            return View(prendaViewModel);
        }

        // POST: Prendas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Prenda model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                model.PrendaID = id;
                prendaRepository.Update(model);
                prendaRepository.save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Prendas/Delete/5
        public ActionResult Delete(int id)
        {
            return View(prendaRepository.GetByID(id));
        }

        // POST: Prendas/Delete/5
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

                prendaRepository.Del(id);
                prendaRepository.save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
