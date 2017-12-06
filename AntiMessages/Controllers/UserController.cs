using AntiMessages.DAL;
using AntiMessages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AntiMessages.Controllers
{
    public class UserController : Controller
    {
        UserContext db = new UserContext();

              // GET: User
        public ActionResult Index()
        {

            return View(db.Users.ToList());
        }

        // GET: User/Details/5
       // public ActionResult Details(int id)
       // {
      //      return View();
      //  }

        // GET: User/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User collection)
        {
            try
            {
                // TODO: Add insert logic here
  
                db.Users.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
                
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                // TODO: Add update logic here
                
                db.Users.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                // TODO: Add delete logic here
                var user = new User
                {
                    UserId = collection.UserId,
                    FirstName = collection.FirstName,
                    LastName = collection.LastName,
                    Email = collection.Email,
                };
                db.Users.Remove(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(collection);
            }
        }
    }
}
