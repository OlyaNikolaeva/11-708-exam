using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class FileScr
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ShortDesc { get; set; }
        public string Desc { get; set; }
        public string Path { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }

        public IFormFile Upload { get; set; }
    }
}
