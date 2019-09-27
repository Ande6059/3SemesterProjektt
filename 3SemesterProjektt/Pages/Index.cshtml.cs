using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace _3SemesterProjektt.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger logger;


        public string Message;
        public int Count = 0;


        public IndexModel(ILogger<IndexModel> logger)
        {
            this.logger = logger;
        }
        public void OnGet()
        {
            Count++;
            Message = $"thank for visiting our awesome site. Visitor number {Count}";
        }
    }
}
