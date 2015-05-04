using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace iStore.Domain.Entities
{
    public class Item
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ItemId { get; set; }

        [MaxLength(100)]
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Пожалуйста, введите название товара")]
        public string Name { get; set; }

        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Пожалуйста, введите описание для товара")]
        public string Description { get; set; }

        [MaxLength(50)]
        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию для товара")]
        public string Category { get; set; }

        [Display(Name = "Цена (руб)")]
        [Required(ErrorMessage = "Пожалуйста, введите цену товара")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение для цены")]
        public decimal Price { get; set; }

        public byte[] ImageData { get; set; }

        [MaxLength(50)]
        public string ImageMimeType { get; set; } 
    }
}