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
    public class Sale
    {
        public SaleDTO getSaleData(int id)
        {
            try
            {
                string RequestUrl = String.Format("http://5e209e06e31c6e0014c60962.mockapi.io/api/sales/{0}", id);

                ServiceBaseConfig serviceBase = new ServiceBaseConfig();
                var responseString = serviceBase.getRequest(RequestUrl);

                dynamic data = serviceBase.getData(responseString);

                var saleData = getMapperForSale(data);

                return saleData;
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }

        private SaleDTO getMapperForSale(dynamic data)
        {
            return new SaleDTO
            {
                id = data.id,
                saleCode = data.saleCode,
                productId = data.productId
            };
        }
    }

}
