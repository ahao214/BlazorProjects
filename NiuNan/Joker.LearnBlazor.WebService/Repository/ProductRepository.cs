using Joker.LearnBlazor.WebService.Models;

namespace Joker.LearnBlazor.WebService.Repository
{
    public class ProductRepository : IProduct
    {
        public List<Product> proList { get; set; }
        public ProductRepository()
        {
            proList = new List<Product>()
            {
                new Product(){ ProductId=1,ProductName="抽纸",ThumbnailImage="1.jpg",CategoryId=21},
                new Product(){ ProductId=2,ProductName="饼干",ThumbnailImage="2.jpg",CategoryId=31},
                new Product(){ ProductId=3,ProductName="蛋糕",ThumbnailImage="3.jpg",CategoryId=3},
                new Product(){ ProductId=4,ProductName="Macbook",ThumbnailImage="4.jpg", CategoryId = 13},
            };
        }
        public void Add(Product model)
        {
            proList.Add(model);
        }

        public void Delete(int id)
        {
            Product model = GetModel(id);
            if (model != null)
            {
                proList.Remove(model);
            }
        }

        public List<Product> GetList(string searchKey = "")
        {
            if (string.IsNullOrEmpty(searchKey))
            {
                return proList;
            }
            else
            {
                return proList.Where(p => p.ProductName.ToLower().Contains(searchKey.ToLower())).ToList();
            }
        }

        public void Update(Product model)
        {
            Product srcModel = GetModel(model.ProductId);
            if (srcModel != null)
            {
                srcModel.ProductName = model.ProductName;
                srcModel.ThumbnailImage = model.ThumbnailImage;
            }

        }

        public Product GetModel(int id)
        {
            return proList.SingleOrDefault(a => a.ProductId == id);
        }

        public List<Product> GetListByCaId(int caid)
        {
            return proList.Where(pro => pro.CategoryId == caid).ToList();
        }

        public int CalcCount(int caid)
        {
            return proList.Where(pro => pro.CategoryId == caid).Count();

        }


    }
}
