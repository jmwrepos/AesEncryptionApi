using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace JmwEncryptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewKey : ControllerBase
    {
        [HttpGet(Name = "NewKey")]
        public byte[] Get()
        {
            Aes aes = Aes.Create();
            aes.GenerateKey();
            return aes.Key;
        }
    }
}
