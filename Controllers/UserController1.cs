using Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars_dreams.Controllers
{
    public class UserController1 : Controller
    {

        private readonly ApplicationContext _Dbcontext;

        public ProductRepositorio(ApplicationContext dbcontext)
        {
            _Dbcontext = dbcontext; 
        }

        public async Task AddAsync(User user)
        {
            await _Dbcontext.user.AddAsync(user);
            await _Dbcontext.SaveChangesAsync();    
        }

        public async Task UpdateAsync(User user)
        {
            _Dbcontext.Entry(user).State = EntityState.Modified;
            await _Dbcontext.SaveChangesAsync();
        }

        public async Task DeleteAsync(User user)
        {
            _Dbcontext.Set<User>().Remove(user);   
            await _Dbcontext.SaveChangesAsync(); 
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _Dbcontext.Set<User>().ToListAsync();
        }












        // GET: UserController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
