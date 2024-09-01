namespace PieShopApp.Models;

public class OrderRepository : IOrderRepository
{

    private readonly PieShopDbContext _dbContext;
    private readonly IShoppingCart _shoppingCart;

    public OrderRepository(IShoppingCart shoppingCart, PieShopDbContext dbContext)
    {
        _shoppingCart = shoppingCart;
        _dbContext = dbContext;
    }

    public void CreateOrder(Order order)
    {
        order.OrderPlaced = DateTime.Now;
        
        List<ShoppingCartItem> shoppingCartItems = _shoppingCart.GetShoppingCartItems();
        order.OrderDetails = new List<OrderDetail>();

        foreach (var shoppingCartItem in shoppingCartItems)
        {
            var orderDetail = new OrderDetail
            {
                Amount = shoppingCartItem.Amount,
                PieId = shoppingCartItem.Pie.PieId,
                Price = shoppingCartItem.Pie.Price
            };
            order.OrderDetails.Add(orderDetail);
        }

        _dbContext.Orders.Add(order);
        _dbContext.SaveChanges();
    }
}