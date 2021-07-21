using Crypto_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Crypto_WebApi.Controllers
{
    public class CrypToDecrypController : ApiController
    {
        public object PosEncrypt(RequestModel NewReq)
        {
            switch (NewReq.Method)
            {
                case "Encrypt":
                    return new CryptoModel().Encrypt(NewReq.Password);
                case "Decrypt":
                    return new CryptoModel().Decrypt(NewReq.Password);
                default:
                    return "Ivalid Method";
            }
            
        }

        
    }
}