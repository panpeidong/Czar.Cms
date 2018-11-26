using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Simple01.Models;

namespace Simple01.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }

        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 0; i < 10; i++)
            //{
            //    contents.Add(new Content { Id = i, Title = $"{i}的标题", Contents = $"{i}的内容", State = 1, AddTime = DateTime.Now.AddDays(-1) });
            //}
            //return View(new ContentViewModel { Contents = contents });
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}