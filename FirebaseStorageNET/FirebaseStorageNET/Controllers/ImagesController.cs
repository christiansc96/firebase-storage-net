using FirebaseStorageNET.DTOs;
using FirebaseStorageNET.ImageManager;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FirebaseStorageNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> PostImage([FromBody] ImageDTO model)
        {
            string imageFromFirebase = await UploadImage(model);
            return Ok(imageFromFirebase);
        }

        private static async Task<string> UploadImage(ImageDTO model)
        {
            var imageFromBase64ToStream = FirebaseStorageManager.ConvertBase64ToStream(model.Image);
            var imageStream = imageFromBase64ToStream.ReadAsStream();

            string imageFromFirebase = await FirebaseStorageManager.UploadImage(imageStream, model);
            return imageFromFirebase;
        }
    }
}