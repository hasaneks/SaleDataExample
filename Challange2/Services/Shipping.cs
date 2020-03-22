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
    public class Shipping
    {
        public ShippingDTO getShippingData(int id)
        {
            try
            {
                string RequestUrl = String.Format("http://5e209e06e31c6e0014c60962.mockapi.io/api/shipping/{0}", id);

                ServiceBaseConfig serviceBase = new ServiceBaseConfig();
                var responseString = serviceBase.getRequest(RequestUrl);

                dynamic data = serviceBase.getData(responseString);

                var shippingData = getMapperForShipping(data);

                return shippingData;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }
        private ShippingDTO getMapperForShipping(dynamic data)
        {
            return new ShippingDTO
            {
                SaleId = data.saleId,
                Status = data.status == "true" ? "Teslim Edildi" : "Teslim Edilmedi",
                CreadetAt = data.createdAt
            };
        }
    }
}
