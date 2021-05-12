using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAuthentication.Models
{
    [Table("User")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        [DisplayName("Kullanıcı Adı"), StringLength(50), Required]
        public string userName { get; set; }
        [DisplayName("Şifresi"), StringLength(50), Required]
        public string password { get; set; }
        public int rank { get; set; }
    }
}