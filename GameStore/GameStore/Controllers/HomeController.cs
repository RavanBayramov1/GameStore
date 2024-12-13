
using GameStore.Context;
using GameStore.Models;
using GameStore.ViewModels;
using GameStore.ViewModels.Games;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GameStore.Controllers
{
    public class HomeController(GamingStoreDbContext _context) : Controller
    {
       

        public async Task<IActionResult> Index()
        {
            return View(await _context.Games.ToListAsync());
        }
        public async Task<IActionResult> Detail(int id)
        {
           Game game = await _context.Games.FindAsync(id);
            if (game == null) return BadRequest();
            
                GameDetailVM vm = new GameDetailVM()
                {
                    Title = game.Title,
                    Description = game.Description,
                    CoverImage = game.CoverImg,
                    SellPrice = game.SellPrice,
                    GameId = game.GameId
                };
                return View(vm);
            
        }


    }
}
