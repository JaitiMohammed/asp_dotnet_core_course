using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {

        private readonly IConfiguration config;
        public string message { get; set; }
        public ListModel(IConfiguration Configuraion)
        {
            this.config = Configuraion;
        }
        public void OnGet()
        {
            message = config["Message"];
        }
    }
}
