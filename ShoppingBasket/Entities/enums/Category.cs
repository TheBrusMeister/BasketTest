﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket.Entities.enums
{
    public class Category
    {
        private string categoryName;

        public Category(string nameOfCategory)
        {
            this.categoryName = nameOfCategory;
        }

        public static readonly Category NONE = new Category("None");
        public static readonly Category HEADGEAR = new Category("Head Gear");
        public static readonly Category KNITWEAR = new Category("Knit Wear");

        public string GetCategoryName()
        {
            return categoryName;
        }

        public void SetCategoryName(string value)
        {
            categoryName = value;
        }

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
