﻿using BikeShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_shop
{
    class ProductsManagmentMVVMViewModel : Notifier
    {
        #region Input and Output properties
        private string searchInput;

        public string SearchInput
        {
            get { return searchInput; }
            set { searchInput = value;
                base.OnPropertyChanged("SearchInput");
                OnSearchInputChanged();
            }
        }

        private IEnumerable<Product> foundProducts;

        public IEnumerable<Product> FoundProducts
        {
            get { return foundProducts; }
            set { foundProducts = value;
                OnPropertyChanged("FoundProducts");
            }
        }

        private Product selectedProduct;

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        #endregion

        ProductsFactory factory = new ProductsFactory();

        public ProductsManagmentMVVMViewModel()
        {
            //Optional: we're just making sure the list is empty
            FoundProducts = Enumerable.Empty<Product>();
        }

        private void OnSearchInputChanged()
        {
            //Optional: just make sure any selected product is unselected
            SelectedProduct = null;

            FoundProducts = factory.FindProducts(SearchInput);
        }
    }
}
