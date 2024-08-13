using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.TestimonialDto
{
    public class CreateTestimonialDto
    {
        [Required(ErrorMessage = "Referans adı giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Referans ünvanı giriniz.")]
        public string Title { get; set; }
        [StringLength(500, ErrorMessage = "Hizmet başlığı en fazla 500 karakter olabilir.")]
        [Required(ErrorMessage = "Referans açıklaması giriniz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Referans Fotoğrafı giriniz.")]
        public string Image { get; set; }
    }
}
