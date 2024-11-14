using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace lab3.Models
{
    public class Dane
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć minimum 2 znaki")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwisko")][MinLength(2, ErrorMessage = "Nazwisko musi mieć minimum 2 znaki")] public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Proszę podać adres e-mail")][EmailAddress(ErrorMessage = "Proszę podać poprawny adres e-mail")] public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać hasło")][MinLength(8, ErrorMessage = "Hasło musi mieć minimum 8 znaków")][RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę")][DataType(DataType.Password)] public string Hasło { get; set; }
        [Required(ErrorMessage = "Proszę potwierdzić hasło")][Compare("Hasło", ErrorMessage = "Hasła muszą się zgadzać")][DataType(DataType.Password)] public string PotwierdzenieHasła { get; set; }
        [Phone(ErrorMessage = "Proszę podać poprawny numer telefonu")][DataType(DataType.PhoneNumber)] public string NrTelefonu { get; set; }
        [Range(11, 80, ErrorMessage = "Wiek musi być pomiędzy 11 a 80 lat")] public int Wiek { get; set; }

        public string Miasto { get; set; }
        public enum Miasta
        {
            Kraków, Warszawa, Wrocław, Gdańsk, Poznań
        }
    }
}
