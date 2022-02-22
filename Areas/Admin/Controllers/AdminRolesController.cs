using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HShopping.Models;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace HShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRolesController : Controller
    {
        private readonly dbHshoppingContext _context;
        public INotyfService _notyfService { get; }
        public AdminRolesController(dbHshoppingContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Roles.ToListAsync());
        }

        // GET: Admin/AdminRoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _context.Roles
                .FirstOrDefaultAsync(m => m.RoleId == id);
            if (roles == null)
            {
                return NotFound();
            }

            return View(roles);
        }

        // GET: Admin/AdminRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleId,RoleName,Description")] Roles roles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roles);
                await _context.SaveChangesAsync();
                _notyfService.Success("Tạo mới thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }

        // GET: Admin/AdminRoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _context.Roles.FindAsync(id);
            if (roles == null)
            {
                return NotFound();
            }
            return View(roles);
        }

        // POST: Admin/AdminRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoleId,RoleName,Description")] Roles roles)
        {
            if (id != roles.RoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roles);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Cập nhật thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RolesExists(roles.RoleId))
                    {
                        _notyfService.Success("Có lỗi xảy ra");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }

        // GET: Admin/AdminRoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _context.Roles
                .FirstOrDefaultAsync(m => m.RoleId == id);
            if (roles == null)
            {
                return NotFound();
            }

            return View(roles);
        }

        // POST: Admin/AdminRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roles = await _context.Roles.FindAsync(id);
            _context.Roles.Remove(roles);
            await _context.SaveChangesAsync();
            _notyfService.Success("Xóa thành công");
            return RedirectToAction(nameof(Index));
        }

        private bool RolesExists(int id)
        {
            return _context.Roles.Any(e => e.RoleId == id);
        }
    }
}
