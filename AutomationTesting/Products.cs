using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting
{
    public class Products
    {
        public void ProductList (int index)
        { 
            
        }
        public void AddToCart(int index)
        {
            var selector = $"//ul[contains(@class,'product_list grid row homefeatured')] /li[{ index}]";
            DriverHelper.MouseOver (By.XPath(selector + "//a[@class='product_img_link']"));
            DriverHelper.Click(By.XPath(selector + "//a[@title='Add to cart']"));
            //mouse over
            //ul[@class="product_list grid row"] /li[2] //a[@class="product_img_link"]
            //hacer click
            //ul[@class="product_list grid row"] /li[2] //a[@title="Add to cart"]
        }
    }
}
