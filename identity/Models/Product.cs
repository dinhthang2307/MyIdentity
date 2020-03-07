using System.ComponentModel.DataAnnotations;

namespace identity.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }

        [Display(Name = "Mô tả sản phẩm")]
        public string Description { get; set; }

        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        [Display(Name = "Giá cả")]
        public int Price { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Hình ảnh")]
        public string ByteImage { get; set; }
    }
}