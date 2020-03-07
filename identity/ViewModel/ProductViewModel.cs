using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace identity.ViewModel
{
    public class ProductViewModel
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

        [Display(Name = "Hình ảnh")]
        public byte[] Image { get; set; }
    }
}