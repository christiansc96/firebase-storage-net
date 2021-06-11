using System.ComponentModel.DataAnnotations;

namespace FirebaseStorageNET.DTOs
{
    public class ImageDTO
    {
        [Required(ErrorMessage = "This field is required")]
        [MinLength(5, ErrorMessage = "A minimum of 5 characters is required")]
        public string Image { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MinLength(5, ErrorMessage = "A minimum of 5 characters is required")]
        public string ImageName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MinLength(5, ErrorMessage = "A minimum of 5 characters is required")]
        public string FolderName { get; set; }
    }
}