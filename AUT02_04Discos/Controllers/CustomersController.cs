using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AUT02_04Discos.Data;
using AUT02_04Discos.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace AUT02_04Discos.Controllers
{
    [Authorize(Roles = "Admin, Comercial")]
    public class CustomersController : Controller
    {
        private readonly ChinookContext _context;

        public CustomersController(ChinookContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
              return View(await _context.Customer
                  .OrderByDescending(n => n.FirstName)
                  .ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [Authorize(Roles = "Admin")]
        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,Company,Address,City,State,Country,PostalCode,Phone,Fax,Email,SupportRepId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        
        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,Address,City,Country,PostalCode")] Customer editedCustomer)
        {
            if (id != editedCustomer.CustomerId)
            {
                return RedirectToAction(nameof(Index));
            }

            var cliente = _context.Customer.Find(id);

            if(cliente == null)
            {
                return RedirectToAction(nameof(Index));
            }

            cliente.Address = editedCustomer.Address;
            cliente.City = editedCustomer.City;
            cliente.Country = editedCustomer.Country;
            cliente.PostalCode = editedCustomer.PostalCode;

            try
            {
                _context.Update(cliente);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(editedCustomer.CustomerId))
                {
                    return NotFound();
                }
                else
                {
                    return View(editedCustomer);
                }
            }
            return RedirectToAction(nameof(Index));
          
            
        }

        [Authorize(Roles = "Admin")]
        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Customer == null)
            {
                return Problem("Entity set 'ChinookContext.Customer'  is null.");
            }
            var customer = await _context.Customer.FindAsync(id);
            if (customer != null)
            {
                _context.Customer.Remove(customer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
          return _context.Customer.Any(e => e.CustomerId == id);
        }

        public async Task<IActionResult> Facturas(int? id)
        {
            if(id == null || _context.Customer == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var customer = _context.Customer
                .Include(e => e.Invoices)
                .FirstOrDefault(e => e.CustomerId == id);

            if(customer == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(customer);
        }
    }
}
