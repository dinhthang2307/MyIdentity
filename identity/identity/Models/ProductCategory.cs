using System.ComponentModel.DataAnnotations;

namespace identity.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        [Display(Name = "Tên danh mục")]
        public string CategoryName { get; set; }
    }
}