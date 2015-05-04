using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace iStore.Domain.Entities
{
    public class Item
    {
        [HiddenInput(DisplayValue = false)]
        public int ItemId { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Пожалуйста, введите название товара")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Пожалуйста, введите описание для товара")]
        public string Description { get; set; }

        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию для товара")]
        public string Category { get; set; }

        [Display(Name = "Цена (руб)")]
        [Required(ErrorMessage = "Пожалуйста, введите цену товара")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение для цены")]
        public decimal Price { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; } 
    }
}