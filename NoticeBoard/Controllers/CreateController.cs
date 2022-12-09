using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NoticeBoard.Data;
using NoticeBoard.Models;

namespace NoticeBoard.Controllers;

public class CreateController : Controller
{
    private readonly ApplicationDbContext _db;

    public CreateController(ApplicationDbContext db)
    {
        _db = db;
    }

    //get
    public IActionResult Index()
    {
        return View();
    }

    //post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(Notice obj)
    {
        if(obj.Name == obj.Description)
        {
            ModelState.AddModelError("Description", "The name and description cannot be exactly the same!");
        }
        if (ModelState.IsValid)
        {
            _db.Notices.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Notice created successfuly!";
            return RedirectToAction("Index", "Home");
        }
        return View(obj);
    }
}
