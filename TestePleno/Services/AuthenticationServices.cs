using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestePleno.WR_Magento;

namespace TestePleno.Services
{
    public class AuthenticationServices
    {
        MagentoService Mservice;

        public AuthenticationServices(MagentoService service)
        {
            Mservice = service;
        }

        public string LogIn()
        {
            try
            {
                return Mservice.login("yourviews", "yourviews");
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}