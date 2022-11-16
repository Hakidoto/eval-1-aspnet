using System.ComponentModel.DataAnnotations;

namespace Eval_1.Models
{
    public class LoginModel
    {
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Passcode { get; set; }
    }
}
