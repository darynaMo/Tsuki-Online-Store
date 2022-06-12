using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TsukiStore.Data;

namespace TsukiStore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Назва { get; set; }
        public string Клас { get; set; }
        public string Вага { get; set; }
        public string Опис { get; set; }
        public double Ціна { get; set; }
        public string ImageURL { get; set; }
        public ProductType Вид { get; set; }

        //Relationships
        public List<Brand_Product> Бренд_Продукт { get; set; }
    }
}
