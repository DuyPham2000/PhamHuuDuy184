using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhamHuuDuy184.Models
{
    public class PersonPHD184
    {
        [Key][Column(TypeName="varchar(20)")]
        public int Personld { get; set; }
        
        [Column(TypeName="nvarchar(50)")]
        public string PersonName { get; set; }
    }
}