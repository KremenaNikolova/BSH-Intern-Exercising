using Lab5.Optional.Models;
using Lab5.Optional.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Optional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingController : ProductsController<Clothing>
    {
        public ClothingController(IProductsRepository<Clothing> clothingRepository) 
            : base(clothingRepository)
        {
            
        }
    }
}
