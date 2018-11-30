using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        SchoolManagementSystem.Models.SchoolManagementSystemEntities db = new SchoolManagementSystemEntities();
        private object u;

        // GET: Admin
        public ActionResult RegisterStudent()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterStudent(StudentTable model, HttpPostedFileBase file)
        {
            var s = new StudentTable();
            s.StudentName = model.StudentName;
            s.StudentRegNumber = model.StudentRegNumber;
            s.StudentGender = model.StudentGender;
            s.StudentDOB = model.StudentDOB.ToString();
            s.StudentGender = model.StudentGender;
            s.StudentProvince = model.StudentProvince;
            s.StudentCity = model.StudentCity;
            s.DateEnroll = model.DateEnroll;
            //ImageFile Code
            string uploadPath = Server.MapPath("~/Uploads/Images");
            file.SaveAs(System.IO.Path.Combine(uploadPath, s.StudentRegNumber + ".jpeg"));
            s.StudentPicture = "/Uploads/Images" + "/" + s.StudentRegNumber + ".jpeg";

            db.StudentTables.Add(s);
            db.SaveChanges();
            return View();
        }
        public ActionResult Students()
        {
            return View();
        }
        

        [ValidateInput(false)]
        public ActionResult StudentsPartial()
        {
            var model = db.StudentTables;
            return PartialView("_StudentsPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult StudentsPartialAddNew([ModelBinder(typeof(DevExpressEditorsBinder))] SchoolManagementSystem.Models.StudentTable item)
        {
            var model = db.StudentTables;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_StudentsPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult StudentsPartialUpdate([ModelBinder(typeof(DevExpressEditorsBinder))] SchoolManagementSystem.Models.StudentTable item)
        {
            var model = db.StudentTables;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.StudentID == item.StudentID);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_StudentsPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult StudentsPartialDelete(System.Int32 StudentID)
        {
            var model = db.StudentTables;
            if (StudentID >= 0)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.StudentID == StudentID);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_StudentsPartial", model.ToList());
        }
    }
}