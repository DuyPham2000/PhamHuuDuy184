using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhamHuuDuy184.Models
{
    public class PHD0184
    {
        [Key]
        [Column(TypeName="varchar(20)")]
        public int PHDId { get; set; }
        
        [Column(TypeName="nvarchar(50)")]
        public string PHDName { get; set; }

        public string PHDGender { get; set; }
    }
}