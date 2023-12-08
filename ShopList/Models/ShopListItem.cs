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
        [DefaultValue(false)]
        public bool IsBuyed { get; set; }

        public ShopListItem() { }

        public ShopListItem(string name)
        {
            ID = Guid.NewGuid();
            Name = name;
            IsBuyed = false;
        }
    }
}
