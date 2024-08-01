

using System.ComponentModel.DataAnnotations;

namespace secoundyear.Properties.Models
{
    public class SingIn
    {
        [Key]
        public int Id { get; set; }

        public string userName {get; set;} = string.Empty;

        public string password {get; set;} = string.Empty;


    }
}

// userName email password comform password