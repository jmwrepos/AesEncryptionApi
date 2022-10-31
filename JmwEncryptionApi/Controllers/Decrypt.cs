using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JmwEncryptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Decrypt : ControllerBase
    {
        [HttpGet]
        public string Get([FromQueryAttribute] byte[] key, [FromQueryAttribute] byte[] iv, [FromQueryAttribute] byte[] encrypted)
        {
            try
            {
                return ApiEncryption.Decrypt(key, iv, encrypted);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
