using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FilesController : Controller
    {

        FileDbContext context;
        IHostingEnvironment app;

        public FilesController(FileDbContext context, IHostingEnvironment appEnvironment)
        {
           app = appEnvironment;
            this.context = context;
        }

        [HttpGet]
        public IActionResult Push()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Push(FileScr file)
        {
            if (file.Upload != null)
            {
                
                string path = "/Files/" + file.Upload.FileName;
               
                using (var fileStream = new FileStream(app.WebRootPath + path, FileMode.Create))
                {
                    await file.Upload.CopyToAsync(fileStream);
                }
                FileScr newFile = new FileScr { Name = file.Upload.FileName, Path = path, ShortDesc = file.ShortDesc, Desc = file.Desc };
                context.Files.Add(newFile);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
