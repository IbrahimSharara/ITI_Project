using Microsoft.AspNetCore.Mvc;
using Graduation_Project.AdminRepository;
using Graduation_Project.Models;
namespace Graduation_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubjectController : Controller
    {
        ISubject isubject;
        public SubjectController(ISubject _isubject)
        {
             isubject = _isubject;
        }
        public IActionResult GetAllSubjects()
        {
            return View(isubject.GetAllSubjects());
        }
        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Subject subject) 
        {
            if (ModelState.IsValid == true) 
            {
                isubject.Add(subject);
                return RedirectToAction(nameof(GetAllSubjects));
            }
            return View(subject);
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            return View(isubject.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(Subject subject) 
        {
            isubject.Edit(subject);
            return RedirectToAction(nameof(GetAllSubjects));
        }
        public IActionResult Delete(int id) 
        {
            isubject.Delete(id);
            return RedirectToAction(nameof(GetAllSubjects));
        }
    }
}
