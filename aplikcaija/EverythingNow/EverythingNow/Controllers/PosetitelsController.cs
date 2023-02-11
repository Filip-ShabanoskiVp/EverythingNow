using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EverythingNow.Models;
using NuGet.Protocol.Plugins;

namespace EverythingNow.Controllers
{
    public class PosetitelsController : Controller
    {
        private readonly Db202223zVaPrjEverythingnowContext _context;

        public PosetitelsController(Db202223zVaPrjEverythingnowContext context)
        {
            _context = context;
        }

        // GET: Posetitels
        public async Task<IActionResult> Index()
        {
            var posetitleKorisnickoIme = HttpContext.Session.GetString("korisnickoime");
            ViewBag.korisnickoime = posetitleKorisnickoIme;
            return View(await _context.Posetitels
                .Where(x => x.UsernamePosetitel == posetitleKorisnickoIme).ToListAsync());
        }

        // GET: Posetitels/Details/5
        public async Task<IActionResult> Details(string id)
        {

            var bileti = await _context.Tikets
                .Where(x => x.Emailaddress == id)
                .ToListAsync();

            return View(bileti);
        }


        public async Task<IActionResult> SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(string UsernamePosetitel, string PasswordPosetitel)
        {
            if (UsernamePosetitel != null && PasswordPosetitel != null)
            {
                var korisniks = await _context.Posetitels.Where(k => k.UsernamePosetitel == UsernamePosetitel).FirstOrDefaultAsync();
                if (korisniks != null && korisniks.PasswordPosetitel == PasswordPosetitel)
                {
                    HttpContext.Session.SetString("korisnickoime", korisniks.UsernamePosetitel);
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("Error", "Непостоечки корисник или лозинка!");
            }
            return View();
        }

        // GET: Posetitels/Create
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: Posetitels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([Bind("Emailaddress,ImePosetitel,UsernamePosetitel,PasswordPosetitel")] Posetitel posetitel)
        {
            if (ModelState.IsValid)
            {
                var korisnickoime = _context.Posetitels.Where(x => x.UsernamePosetitel == posetitel.UsernamePosetitel).FirstOrDefault();
                if (korisnickoime == null)
                {
                    _context.Add(posetitel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(SignIn));
                }
                else
                {
                    ModelState.AddModelError("Error", "Корисничкото име веќе постои!");
                    return View(posetitel);
                }
            }
            return View(posetitel);
        }



        public async Task<IActionResult> SignOut(string id)
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(SignIn));
        }


    }
}
