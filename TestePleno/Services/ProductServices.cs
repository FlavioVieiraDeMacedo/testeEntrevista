using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestePleno.Models;
using TestePleno.WR_Magento;
namespace TestePleno.Services
{
    public class ProductServices
    {
        MagentoService Mservice;

        public ProductServices(MagentoService service)
        {
            Mservice = service;
        }


        public Product GetProdutoById(string credential, string productId)
        {
            try
            {
                var product = Mservice.catalogProductInfo(credential, productId, null, null, null);
                
                var auxPrice = string.Format("{0:0.00}", decimal.Parse(product.price.Replace(".", ",")));
                return new Product
                {
                    Id = Int32.Parse(product.product_id),
                    Name = product.name,
                    Price = decimal.Parse(auxPrice)
                };

            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}