using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFSelfHosting
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in both code and config file together.
    public class ProductService : IProductService
    {
        NorthwindEntities db = new NorthwindEntities();

        public List<ProductDTO> ProductsSelect()
        {
            List<Products> productsList = db.Products.ToList();
            List<ProductDTO> urunListesi = new List<ProductDTO>();

            foreach (Products item in productsList)
            {
                ProductDTO urun = new ProductDTO() 
                {
                    ProductID = item.ProductID,
                    ProductName = item.ProductName
                };

                urunListesi.Add(urun);
            }

            return urunListesi;
            }
    }

    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public int ProductID { get; set; }
    }
}
