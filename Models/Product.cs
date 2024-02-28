using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    public class Product
    {
        [BindNever]
        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Ürün adı girmek zorunludur.")]
        [StringLength(100, ErrorMessage = "Ürün adı maksimum 100 karakter olabilir.")]
        [Display(Name = "Ürün Adı")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Ürün fiyatı girmek zorunludur.")]
        [Range(0,int.MaxValue, ErrorMessage = "{1}-{2} aralığında bir fiyat girebilirsiniz.")]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; }

        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Ürün kategorisi seçmek zorunludur.")]
        [Display(Name = "Kategori")]
        public int? CategoryId { get; set; }
    }
}