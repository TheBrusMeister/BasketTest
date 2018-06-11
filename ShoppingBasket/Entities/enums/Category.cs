using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities.enums
{
    public class Category
    {
        public string categoryName { get; }

        public Category(string nameOfCategory)
        {
            this.categoryName = nameOfCategory;
        }

        public static readonly Category NONE = new Category("None");
        public static readonly Category HEADGEAR = new Category("Head Gear");
        public static readonly Category KNITWEAR = new Category("Knit Wear");

        public static IEnumerable<Category> Values
        {
            get
            {
                yield return NONE;
                yield return HEADGEAR;
                yield return KNITWEAR;
            }
        }
    }
}
