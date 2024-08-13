using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad alanı boş geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı alanı boş geçilemez")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail alanı alanı boş geçilemez")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Parola alanı boş geçilemez")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Parola tekrar alanı boş geçilemez")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmamaktadır!")]
        public string ConfirmPassword { get; set; }
    }
}
