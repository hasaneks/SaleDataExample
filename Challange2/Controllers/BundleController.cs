using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Challange2.Models;
using Challange2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challange2.Controllers
{
    [ApiController]
    public class BundleController : Controller
    {

        [HttpGet]
        [Route("sale/shipping")]
        public JsonResult Shipping(int id)
        {
            if(id == 0)
            {
                return new JsonResult("Id parameter cannot equal zero!") { StatusCode = (int)HttpStatusCode.BadRequest };
            }
            try
            {
                Sale saleService = new Sale();
                var saleResult = saleService.getSaleData(id);

                Product productService = new Product();

                Shipping shippingService = new Shipping();

                return Json(setBundleData(shippingService.getShippingData(id), saleService.getSaleData(id), productService.getProductData(saleResult.productId)));
            }

            catch (Exception ex)
            {
                return new JsonResult(ex.Message) { StatusCode = (int)HttpStatusCode.BadRequest };
                throw;
            }
        }

        private BundleModel setBundleData(ShippingDTO shippingResult, SaleDTO saleResult,ProductDTO productResult)
        {
            return new BundleModel
            {
                Status = shippingResult.Status,
                Sale = getMapperBySale(saleResult),
                Product = getMapperByProduct(productResult)
            };
        }

        private sale getMapperBySale(SaleDTO data)
        {
            return new sale
            {
                Id = data.id,
                Code = data.saleCode
            };
        }
        private product getMapperByProduct(ProductDTO data)
        {
            return new product()
            {
                Id = data.Id,
                Name = data.Name,
                Price = data.Price
            };
        }
    }
}