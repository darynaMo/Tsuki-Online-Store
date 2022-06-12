using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TsukiStore.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string Назва { get; set; }
        public string Опис { get; set; }
    }
}
