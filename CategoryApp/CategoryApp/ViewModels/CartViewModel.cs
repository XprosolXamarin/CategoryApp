using CategoryApp.Models;
using CategoryApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CategoryApp.ViewModels
{
   public class CartViewModel
    {
        public ObservableCollection<CartModel> CartItems { get; set; } = new ObservableCollection<CartModel>();
        public CartViewModel()
        {
            CartItems.Add(new CartModel
            {
                Name = "Mobile",

                Details = "254546",
                RPP = 10500,
                purchasedQty = 1,
                ImageUrl = "images.jpg",
                totalpurchased = 3



            });
            CartItems.Add(new CartModel
            {
                Name = "Watch",

                Details = "254546",
                RPP = 1055,
                purchasedQty = 1,
                ImageUrl = "Watch.png",
                totalpurchased = 3400

            });
            CartItems.Add(new CartModel
            {
                Name = "Mobile",

                Details = "254546",
                RPP = 10000,
                purchasedQty = 1,
                ImageUrl = "images.jpg",
                totalpurchased = 344


            });
            CartItems.Add(new CartModel
            {
                Name = "Mobile",

                Details = "254546",
                RPP = 10000,
                purchasedQty = 1,
                ImageUrl = "images.jpg",
                totalpurchased = 340,


            });
        }
        public Command<CartModel> IncreaseQtyCommand
        {
            get
            {
                return new Command<CartModel>((CartModel product) =>
                {
                    product.purchasedQty += 1;
                    product.totalpurchased = product.totalpurchased * product.purchasedQty;
                });
            }
        }
        public Command<CartModel> DecreaseQtyCommand
        {
            get
            {
                return new Command<CartModel>((CartModel product) =>
                {
                    product.totalpurchased = product.totalpurchased / product.purchasedQty;
                    product.purchasedQty -= 1;

                });
            }
        }
        public Command<CartModel> RemoveItem
        {
            get
            {
                return new Command<CartModel>((CartModel product) =>
                {
                    CartItems.Remove(product);
                });
            }
        }
        public Command NavigateCheckoutPage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new CheckoutPage());

                });
            }
        }
        public Command NavigateAddressPage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new AddressPage());

                });
            }
        }
        public Command NavigatePaymentsCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new PaymentsPage());

                });
            }
        }
        public Command NavigateSummaryPage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new SummaryPage());

                });
            }
        }
    }
}
