using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers;
 
     public class HelloController : Controller
     {

        public IActionResult Index() {
          Person person = new Person(); 
          person.SetData();
          string strResult = "Hello" + person.PersonID + "-" + person.FullName;
          ViewBag.info = strResult;
          return View();
          }
     [HttpPost]
     public IActionResult Index(Person ps)
     {
          ExccelsProcess exPro = new ExccelsProcess();
          DataTable dt = exPro.ReadDataFromExcelFile("file path");
          string strResult = "Xin chao "+ ps.PersonID + " - " + ps.FullName;
          ViewBag.info = strResult;
          return View();
     }
     }

