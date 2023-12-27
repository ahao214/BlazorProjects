﻿using BlazorEcommerce.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        {
            var result = await _productService.GetProductAsync(productId);
            return Ok(result);
        }

        /// <summary>
        /// 根据分类获取产品数据
        /// </summary>
        /// <param name="categoryUrl"></param>
        /// <returns></returns>
        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductByCategory(string categoryUrl)
        {
            var result = await _productService.GetProductsByCategory(categoryUrl); 
            return Ok(result);
        }


        /// <summary>
        /// 根据内容搜索商品
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<ServiceResponse<Product>>> SearchProducts(string searchText)
        {
            var result = await _productService.SearchProducts(searchText);
            return Ok(result);
        }

    }
}
