using System.ComponentModel.DataAnnotations;
namespace OnlineShopping.Models
{ 
    public class User
    {
        public int id { get; set;  }
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [StringLength(50,MinimumLength =6,ErrorMessage ="Password invalid")]
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; }
    }
}
