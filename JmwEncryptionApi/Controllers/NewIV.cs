using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace JmwEncryptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewIV : ControllerBase
    {
        [HttpGet(Name = "NewIV")]
        public byte[] Get()
        {
            Aes aes = Aes.Create();
            aes.GenerateIV();
            return aes.IV;
        }
    }
}
