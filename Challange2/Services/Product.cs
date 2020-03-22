using Challange2.Config;
using Challange2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Challange2.Services
{
    public class Product
    {

        public ProductDTO getProductData(int id)
        {
            try
            {
                string RequestUrl = String.Format("http://5e209e06e31c6e0014c60962.mockapi.io/api/products/{0}", id);

                ServiceBaseConfig serviceBase = new ServiceBaseConfig();
                var responseString = serviceBase.getRequest(RequestUrl);

                dynamic data = serviceBase.getData(responseString);

                var productData = getMapper(data);

                return productData;

            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }
        private ProductDTO getMapper(dynamic data)
        {
            return new ProductDTO
            {
                Id = data.id,
                Category = data.category,
                Name = data.name,
                Price = data.price,
                Image = data.image,
            };
        }
    }
}
