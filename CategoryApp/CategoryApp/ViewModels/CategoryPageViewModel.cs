using CategoryApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CategoryApp.ViewModels
{
   public class CategoryPageViewModel
    {
        public ObservableCollection<CategoriesModel> Categories { get; set; } = new ObservableCollection<CategoriesModel> ();
        public ObservableCollection<LatestItemsModel> LatestItems { get; set; } = new ObservableCollection<LatestItemsModel>();

       public CategoryPageViewModel()
        {
            Categories.Add(new CategoriesModel
            {
                ImageUrl= "Watch.png",
                categoryName="Watch"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "Dress.png",
                categoryName = "Dress"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "Watch.png",
                categoryName = "Watch"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRKU69PRk3o9f2toiJJxCWuwnICKX5ultbgkQ&usqp=CAU",
                categoryName = "Mobile"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "Watch.png",
                categoryName = "Watch"
            });
            Categories.Add(new CategoriesModel
            {
                ImageUrl = "Watch.png",
                categoryName = "Watch"
            });
            LatestItems.Add(new LatestItemsModel
            {
               ImageUrl= "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTaTr5QFYJ7hKGMSc44LmtHPm5QvNdPz00Nhw&usqp=CAU",
               Name="Watches",
               Rating="4.8",
               Price= "Rs/-200",
               Descrption="Men Watches"
               
            });
            LatestItems.Add(new LatestItemsModel
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQBtRAWt-FetGkt-YXmDdXwf2kzmJ1cjIdeWw&usqp=CAU",
                Name = "Watches",
                Rating = "4.8",
                Price = "Rs/-200",
                Descrption = "Men Watches"

            });
            LatestItems.Add(new LatestItemsModel
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ4VSFw47YTIWdUqLXM_w8i9nmVfRKaf_IlXg&usqp=CAU",
                Name = "Watches",
                Rating = "4.8",
                Price = "Rs/-200",
                Descrption = "Men Watches"

            });
        }
    }

}
