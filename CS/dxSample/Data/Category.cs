using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace dxSample.Data {
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public static class CategoryData {
        static Random _random = new Random();
        static string[] _possibleItems = new string[] { "Tea", "Coffee", "Butter", "Lemon", "Apple", "Orange", "Milk", "Chocolate" };
        static string[] _categories = new string[] { "Main", "New", "Best" };
        public static IList<Category> GetCategories() {
            BindingList<Category> categories = new BindingList<Category>();
            for (int i = 0; i < 8; i++) {
                int index = i + 1;
                string items = string.Empty;
                int itemsCount = _random.Next(4, 14);
                for (int j = 0; j < itemsCount; j++) {
                    items += _possibleItems[_random.Next(4, 8)];
                    items += (j < itemsCount - 1 ? ", " : "");
                }
                categories.Add(new Category() { Id = i, Name = _categories[_random.Next(0, 3)], Description = items });
            }
            return categories;
        }
    }
}
