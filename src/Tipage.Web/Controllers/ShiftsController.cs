using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tipage.Web.Data;
using Tipage.Web.Models;

namespace Tipage.Web.Controllers
{
    [Authorize]
    public class ShiftsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ShiftsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, UserManager<ApplicationUser> userManager1)
        {
            _context = context;
            _userManager = userManager1;
        }

        // GET: Shifts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Shifts.ToListAsync());
        }

        // GET: Shifts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var shift = await _context.Shifts
                .SingleOrDefaultAsync(m => m.Id == id);

            if (shift == null)
                return NotFound();

            return View(shift);
        }

        // GET: Shifts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shifts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Start,End,CashTips,CreditTips")] Shift shift)
        {
            if (ModelState.IsValid)
            {
                shift.User = await _userManager.GetUserAsync(HttpContext.User);
                _context.Add(shift);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(shift);
        }

        // GET: Shifts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var shift = await _context.Shifts.SingleOrDefaultAsync(m => m.Id == id);

            if (shift == null)
                return NotFound();

            return View(shift);
        }

        // POST: Shifts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Start,End,CashTips,CreditTips")] Shift shift)
        {
            if (id != shift.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shift);
                    await _context.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!ShiftExists(shift.Id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction("Index");
            }

            return View(shift);
        }

        // GET: Shifts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var shift = await _context.Shifts
                .SingleOrDefaultAsync(m => m.Id == id);

            if (shift == null)
                return NotFound();

            return View(shift);
        }

        // POST: Shifts/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shift = await _context.Shifts.SingleOrDefaultAsync(m => m.Id == id);
            _context.Shifts.Remove(shift);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        private bool ShiftExists(int id)
        {
            return _context.Shifts.Any(e => e.Id == id);
        }
    }
}