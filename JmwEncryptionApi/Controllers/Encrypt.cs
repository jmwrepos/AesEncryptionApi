using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JmwEncryptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Encrypt : ControllerBase
    {
        [HttpGet]
        public byte[] Get([FromQueryAttribute] byte[] key, [FromQueryAttribute] byte[] iv, string unencrypted)
        {
            try
            {
                unencrypted = WebUtility.UrlDecode(unencrypted);
                return ApiEncryption.Encrypt(key, iv, unencrypted);
            }
            catch
            {
                return Array.Empty<byte>();
            }
        }
    }
}
