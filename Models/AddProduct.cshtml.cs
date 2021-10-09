using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductApp.Models.Product;

namespace ProductApp.Pages
{
    public class AddProductModel : PageModel
    {
        public string Result { get; set; }

        public void OnGet(string name, double price)
        {
            if(name != null && price >= 0)
            {
                if (ProductRep.AddData(name, price) == "Success!")
                {
                    Result = "New product successfully added!";
                }
                else
                {
                    Result = "Product addition failed!";
                }
            }
        }
    }
}
