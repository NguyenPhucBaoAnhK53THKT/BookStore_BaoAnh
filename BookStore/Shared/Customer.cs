using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Shared
{
    public class Customer
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập đầy đủ Họ Tên")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ nhà")]
        public string Street { get; set; } = default!;

        [Required(ErrorMessage = "Vui lòng chọn thành phố")]
        public string City { get; set; } = default!;

    }
}
