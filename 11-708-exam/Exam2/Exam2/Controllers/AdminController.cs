using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam2.Data;
using Exam2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam2.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context
                ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IActionResult> AddRestaurant(Restarant restaurant)
        {
            await _context.Restaurants.AddAsync(restaurant);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> GetRestaurantByIdAsync(int? restaurantId)
        {
            var restaurant = await _context.Restaurants.FindAsync(restaurantId);
            return View(restaurant);
        }

        public async Task<IActionResult> EditRestaurant(Restarant restaurant)
        {
            var entity = await _context.Restaurants.FindAsync(restaurant.Id);
            if (entity == null)
                await _context.Restaurants.AddAsync(restaurant);
            else
            {
                entity.Name = restaurant.Name;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> DeleteRestaurant(Restarant restaurant)
        {
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AddDish(Dishe dish)
        {
            await _context.Dishes.AddAsync(dish);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> GetDishByIdAsync(int? dishId)
        {
            var dish = await _context.Dishes.FindAsync(dishId);
            return View(dish);
        }

        public async Task<IActionResult> EditDish(Dishe dish)
        {
            var entity = await _context.Dishes.FindAsync(dish.Id);
            if (entity == null)
                await _context.Dishes.AddAsync(dish);
            else
            {
                entity.Name = dish.Name;
                entity.Price = dish.Price;
                entity.RestaurantId = dish.RestaurantId;
                entity.Desc = dish.Desc;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        
        public async Task<IActionResult> DeleteDish(Dishe dish)
        {
            _context.Dishes.Remove(dish);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}