using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EverythingNow.Models;
using NuGet.Versioning;

namespace EverythingNow.Controllers
{
    public class NatprevarsController : Controller
    {
        private readonly Db202223zVaPrjEverythingnowContext _context;

        public NatprevarsController(Db202223zVaPrjEverythingnowContext context)
        {
            _context = context;
        }

        // GET: Natprevars
        public async Task<IActionResult> Index()
        {
            var db202223zVaPrjEverythingnowContext = _context.Natprevars.Include(n => n.IdRezultatNavigation)
                .Include(n => n.IdStadionNavigation).Include(n => n.UsernameNavigation);

   

            var posetitleKorisnickoIme = HttpContext.Session.GetString("korisnickoime");
            ViewBag.korisnickoime = posetitleKorisnickoIme;

            return View(await db202223zVaPrjEverythingnowContext.ToListAsync());
        }

        // GET: Natprevars/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Natprevars == null)
            {
                return NotFound();
            }

            var natprevar = await _context.Natprevars
                .Include(n => n.IdRezultatNavigation)
                .Include(n => n.IdStadionNavigation)
                .Include(n => n.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.IdNatprevar == id);

            var pogodoci = await _context.Pogodocis
                .Include(p=>p.EmbgIgrachNavigation)
                .Include(p=>p.DrzhavaNavigation)
                .FirstOrDefaultAsync(m => m.IdNatprevar == id);

            ViewBag.pogodoci = pogodoci;

            var sudii = await _context.SudiNas
               .Include(p => p.EmbgSudiiNavigation)
               .Include(p => p.IdNatprevarNavigation)
               .Where(p => p.IdNatprevar == id).ToListAsync();

            var glaven = "";
            List<string> pomosni = new List<string>();

            foreach (var s in sudii)
            {
                if(s.Uloga== "Glaven sudija")
                {
                    glaven = s.EmbgSudiiNavigation.ImeSudii;
                }
                else if(s.Uloga== "Pomosen sudija")
                {
                   pomosni.Add(s.EmbgSudiiNavigation.ImeSudii);
                }
            }
            @ViewBag.glaven = glaven;
            @ViewBag.pomosni = string.Format("{0}", string.Join(", ", pomosni));
            ViewBag.broj = pomosni.Count;

            if (natprevar == null)
            {
                return NotFound();
            }

            return View(natprevar);
        }

        // GET: Natprevars/Create
        public IActionResult Create()
        {
            ViewData["IdRezultat"] = new SelectList(_context.Rezultats, "IdRezultat", "IdRezultat");
            ViewData["IdStadion"] = new SelectList(_context.Stadions, "IdStadion", "IdStadion");
            ViewData["Username"] = new SelectList(_context.Admins, "Username", "Username");
            return View();
        }

        // POST: Natprevars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNatprevar,Faza,Data,Chas,IdStadion,Username,IdRezultat")] Natprevar natprevar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(natprevar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRezultat"] = new SelectList(_context.Rezultats, "IdRezultat", "IdRezultat", natprevar.IdRezultat);
            ViewData["IdStadion"] = new SelectList(_context.Stadions, "IdStadion", "IdStadion", natprevar.IdStadion);
            ViewData["Username"] = new SelectList(_context.Admins, "Username", "Username", natprevar.Username);
            return View(natprevar);
        }

        // GET: Natprevars/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Natprevars == null)
            {
                return NotFound();
            }

            var natprevar = await _context.Natprevars.FindAsync(id);
            if (natprevar == null)
            {
                return NotFound();
            }
            ViewData["IdRezultat"] = new SelectList(_context.Rezultats, "IdRezultat", "IdRezultat", natprevar.IdRezultat);
            ViewData["IdStadion"] = new SelectList(_context.Stadions, "IdStadion", "IdStadion", natprevar.IdStadion);
            ViewData["Username"] = new SelectList(_context.Admins, "Username", "Username", natprevar.Username);
            return View(natprevar);
        }

        // POST: Natprevars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("IdNatprevar,Faza,Data,Chas,IdStadion,Username,IdRezultat")] Natprevar natprevar)
        {
            if (id != natprevar.IdNatprevar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(natprevar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NatprevarExists(natprevar.IdNatprevar))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRezultat"] = new SelectList(_context.Rezultats, "IdRezultat", "IdRezultat", natprevar.IdRezultat);
            ViewData["IdStadion"] = new SelectList(_context.Stadions, "IdStadion", "IdStadion", natprevar.IdStadion);
            ViewData["Username"] = new SelectList(_context.Admins, "Username", "Username", natprevar.Username);
            return View(natprevar);
        }

        // GET: Natprevars/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Natprevars == null)
            {
                return NotFound();
            }

            var natprevar = await _context.Natprevars
                .Include(n => n.IdRezultatNavigation)
                .Include(n => n.IdStadionNavigation)
                .Include(n => n.UsernameNavigation)
                .FirstOrDefaultAsync(m => m.IdNatprevar == id);
            if (natprevar == null)
            {
                return NotFound();
            }

            return View(natprevar);
        }

        // POST: Natprevars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Natprevars == null)
            {
                return Problem("Entity set 'Db202223zVaPrjEverythingnowContext.Natprevars'  is null.");
            }
            var natprevar = await _context.Natprevars.FindAsync(id);
            if (natprevar != null)
            {
                _context.Natprevars.Remove(natprevar);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
         
        private bool NatprevarExists(long id)
        {
          return _context.Natprevars.Any(e => e.IdNatprevar == id);
        }


        public async Task<IActionResult> BuyTicket(long id)
        {
            List<Tiket> allTiketsExists = null;
            List<Sedistum> sedistas = new List<Sedistum>();
            var najde = false;
            if(_context.Tikets.Where(t => t.IdNatprevar == id).FirstOrDefault() != null)
            {
                allTiketsExists  = _context.Tikets.Where(t => t.IdNatprevar == id).ToList();
            }

            var natprevar = await _context.Natprevars.Include(n=>n.IdStadionNavigation)
                .Include(n=>n.IdStadionNavigation.Sedista)
                .Where(n => n.IdNatprevar == id).FirstOrDefaultAsync();

            if(allTiketsExists != null)
            {
                foreach(var s in _context.Sedista.Where(s=>s.IdStadion == _context.Natprevars
                .Where(n => n.IdNatprevar == id).FirstOrDefault().IdStadion))
                {
                    foreach(var t in allTiketsExists)
                    {
                        if (t.Sediste == s.Broj)
                        {
                            najde = true;
                            break;
                        }
                    }
                    if (najde == false)
                    {
                        sedistas.Add(s);
                    }
                    else
                    {
                        najde= false;
                    }
                }
            }
            else
            {
                sedistas = await _context.Sedista.Include(s => s.IdStadionNavigation)
                 .Where(s => s.IdStadion == natprevar.IdStadion).ToListAsync();
            }

            ViewBag.natprevar = natprevar.IdNatprevar;

            ViewBag.broj = sedistas.Count();

            return View(sedistas);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BuyTicket(int Broj, long IdStadion, bool Slobodno, long natprevar, int Cena)
        {
            List<Sedistum> sedista = new List<Sedistum>();
            sedista.Add(new Sedistum(IdStadion, Broj, Slobodno));
            return RedirectToAction(nameof(Buy),new { sedista[0].IdStadion, sedista[0].Broj, sedista[0].Slobodno, natprevar, sedista[0].Cena });

        }

        public async Task<IActionResult> Buy()
        {
            var IdStadion = HttpContext.Request.Query["IdStadion"].ToString();
            var Broj = HttpContext.Request.Query["Broj"].ToString();
            var Slobodno = HttpContext.Request.Query["Slobodno"].ToString();

            var natprevar = HttpContext.Request.Query["natprevar"].ToString();


            ViewBag.natprevar = HttpContext.Request.Query["natprevar"].ToString();

            var sediste =await _context.Sedista.Where(s => s.IdStadion == (long)Convert.ToDouble(IdStadion))
                .Where(s => s.Broj == (int)Convert.ToInt64(Broj))
                .Where(s => s.Slobodno == (bool)Convert.ToBoolean(Slobodno)).ToListAsync();
            return View(sediste);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Buy(int Broj, long IdStadion, bool Slobodno, long natprevar,int Cena)
        {
            var natprevars = _context.Tikets.Where(n => n.IdNatprevar == natprevar).FirstOrDefault();
            var najavenKorisnik = HttpContext.Session.GetString("korisnickoime");
            bool goIma = false;
            if (natprevars != null)
            {
                var sedista = _context.Sedista.Where(s => s.IdStadion == IdStadion).ToList();
                foreach (var n in sedista)
                {
                    if (n.Broj == Broj && _context.Tikets.Where(t=>t.Sediste==Broj).Where(t=>t.IdNatprevar==natprevars.IdNatprevar).FirstOrDefault()!=null)
                    {
                        goIma = true;
                        break;
                    }
                }

            }
            if (natprevars==null || goIma==false)
            {
                Tiket t = new Tiket();
                t.Sediste = Broj;
                t.IdNatprevar = natprevar;
                t.Username = "Ivana Stojanovska";
                t.Emailaddress = _context.Posetitels.Where(p => p.UsernamePosetitel == najavenKorisnik)
                    .FirstOrDefault().Emailaddress;
                t.Cena = Cena;
                _context.Add(t);
                await _context.SaveChangesAsync();
                return Redirect("~/Posetitels/Details/" + t.Emailaddress);
               // return RedirectToAction("Details", "Posetitels",routeValues: t.Emailaddress);
            }
            return View();
        }
    }
}
