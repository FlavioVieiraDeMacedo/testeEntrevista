using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestePleno.Models;
using TestePleno.WR_Magento;

namespace TestePleno.Services
{
    public class Service 
    {
        public MagentoService Mservice { get; set; }

        public Service()
        {
            Mservice = new MagentoService();
        }

        public string LogIn()
        {
            AuthenticationServices serviceAuthentication = new AuthenticationServices(Mservice);
            return serviceAuthentication.LogIn();
        }

        public Product GetProductById(string credential, string productId)
        {
            ProductServices serviceProduto = new ProductServices(Mservice);
            return serviceProduto.GetProdutoById(credential, productId);
           
        }
    }
}