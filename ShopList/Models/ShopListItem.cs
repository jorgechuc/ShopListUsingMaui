using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopList.Models
{
    public class ShopListItem
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
<<<<<<< HEAD
        [DefaultValue(false)]
        public bool IsBuyed { get; set; }

        public ShopListItem() { }

        public ShopListItem(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
            IsBuyed = false;
        }
=======
        public bool IsBought { get; set; }
>>>>>>> df6b10c3096253867d02b27571fb308bb5c96f16
    }
}
