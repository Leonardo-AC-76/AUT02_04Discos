using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AUT02_04Discos.Data;
using AUT02_04Discos.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace AUT02_04Discos.Controllers
{
    public class UsuarioController : Controller
    {
        //utilizar userManager para pasar la lista de usuarios + crear lista + pasar a la vista

        private readonly UserManager<IdentityUser> _user;
        
        public UsuarioController(UserManager<IdentityUser> usuario)
        {
            _user = usuario;
        }

        [Authorize(Roles = "Admin")]
        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            var lista = await _user.Users.ToListAsync();
            return View(lista);
        }
    }
}
