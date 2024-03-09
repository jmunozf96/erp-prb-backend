using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSecurity.infrastructure.entities
{
    [Table("Users")]
    public class UserEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required, Key]
        public int Id { get; set; }
        
        public required String Email { get; set; }

        public required String Name { get; set; }

        public required String LastName { get; set; }

        public required String Password { get; set; }

    }
}
