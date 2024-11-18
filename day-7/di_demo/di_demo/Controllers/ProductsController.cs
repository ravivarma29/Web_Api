using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace di_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


     //   ProductsList pObj = new ProductsList(); //this is bad, else please write the code to destroy, release the memory

        ProductsList pObj;

        public ProductsController(ProductsList _pObj)
        {
            this.pObj = _pObj;
        }

        [HttpGet]
        [Route("/product/list")]
        public IActionResult GetProducts()
        {
            return Ok(pObj.GetAllProducts());
        }
    }
}