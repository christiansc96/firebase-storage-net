using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirebaseStorageNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var data = new
            {
                title = "Subiendo imágenes a Firebase Storage desde .NET",
                description = "Aprenderemos a subir archivos y otro contenido a Firebase Storage usando la tecnología .NET",
                speaker = "Christian Sánchez",
                bio = "Soy Desarrollador de Software y Auth0 Ambassador",
                codeExample = "https://github.com/christiansc96/firebase-storage-net",
                communities = new List<object>
                {
                    new
                    {
                        DevTeam504 = "Co-Fundador y Organizador",
                        FlutterHonduras = "Co-Fundador y Co-Organizer"
                    }
                },
                socialMedia = new
                {
                    twitter = new
                    {
                        user = "@christian_sc96",
                        profile = "https://twitter.com/christian_sc96"
                    },
                    github = new
                    {
                        user = "@christiansc96",
                        profile = "https://github.com/christiansc96"
                    },
                    instagram = new
                    {
                        user = "@christian_sc96",
                        profile = "https://www.instagram.com/christian_sc96/"
                    },
                    linkedin = new
                    {
                        user = "Christian Sánchez",
                        profile = "https://www.linkedin.com/in/christian-david-s%C3%A1nchez-675980177/"
                    }
                }
            };
            return Ok(data);
        }
    }
}