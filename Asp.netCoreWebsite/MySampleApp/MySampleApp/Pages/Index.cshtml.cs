using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySampleApp.Models;
using MySampleApp.Service;

namespace MySampleApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductsService FileProductsService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductsService jsonFileProductsService)
        {
            _logger = logger;
            FileProductsService = jsonFileProductsService;
        }

        public void OnGet()
        {
            Products = FileProductsService.GetProducts();
        }
    }
}
