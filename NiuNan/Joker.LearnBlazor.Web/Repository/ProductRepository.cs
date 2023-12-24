﻿using Joker.LearnBlazor.Web.Models;

namespace Joker.LearnBlazor.Web.Repository
{
    public class ProductRepository : IProduct
    {
        public List<Product> proList { get; set; }
        public ProductRepository()
        {
            proList = new List<Product>()
            {
                new Product(){ ProductId=1,ProductName="抽纸",ThumbnailImage="1.jpeg"},
                new Product(){ ProductId=2,ProductName="牛奶",ThumbnailImage="2.jpeg"},
                new Product(){ ProductId=3,ProductName="蛋糕",ThumbnailImage="3.jpeg"},
                new Product(){ ProductId=4,ProductName="Macbook",ThumbnailImage="4.jpeg"},
            };
        }
        public void Add(Product model)
        {
            proList.Add(model);
        }

        public void Delete(int id)
        {
            Product model = GetModel(id);
            if(model !=null )
            {
                proList.Remove(model);
            }            
        }

        public List<Product> GetList()
        {
            return proList;
        }

        public void Update(Product model)
        {
            Product srcModel = GetModel(model .ProductId);
            if(srcModel !=null )
            {
                srcModel .ProductName = model.ProductName;  
                srcModel .ThumbnailImage =model .ThumbnailImage;    
            }

        }

        public Product GetModel(int id)
        {
            return proList.SingleOrDefault(a => a.ProductId == id);
        }

    }
}
