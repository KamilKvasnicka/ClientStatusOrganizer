using System.ComponentModel.DataAnnotations;
namespace ClientStatusOrganizer.Model
{
    public class Client
    {
        public int ClientID { get; set; }
        [Required(ErrorMessage = "Please enter Client first name")]
        [Display(Name = "Client Name")]
        [StringLength(50)]
        public string ClientName { get; set; }
        [Required(ErrorMessage = "Please enter Client surname")]
        [Display(Name = "Client Surname")]
        [StringLength(50)]
        public string ClientSurName { get; set; }
        public double ClientBankStatus { get; set; }

    }
}
