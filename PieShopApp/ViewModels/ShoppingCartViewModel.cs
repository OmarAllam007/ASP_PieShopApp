using PieShopApp.Models;

namespace PieShopApp.ViewModels;

public class ShoppingCartViewModel
{
    public IShoppingCart ShoppingCart { get; set; }
    public decimal ShoppingCartTotal { get; set; }
    
    public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
    {
        ShoppingCart = shoppingCart;
        ShoppingCartTotal = shoppingCartTotal;
    }
    
    
}