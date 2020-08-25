using Bmes.Models.Shared;

namespace Bmes.Models.Product
{
    public class Brand : BaseObject
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
<<<<<<< HEAD
        public BrandStatus { get; set; }
}
=======
        public BrandStatus BrandStatus { get; set; }
    }
>>>>>>> c49c934f5cc3bc4b03bb2f80a1e88009378b09ac
}
