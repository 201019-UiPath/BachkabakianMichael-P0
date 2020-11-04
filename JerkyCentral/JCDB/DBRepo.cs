using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JCDB
{
    public class DBRepo : IBrandRepo, ICategoryRepo, IInventoryRepo, ILocationRepo, IOrderLineRepo, IOrderRepo, IProductRepo, IUserRepo, ICartRepo, ICartLineRepo
    {
        private JCContext context;

        public DBRepo(JCContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// CRUD Methods for my Brands
        /// </summary>
        /// <param name="brand"></param>
        public void AddBrandAsync(Brand brand)
        {
            context.Brands.AddAsync(brand);
            context.SaveChangesAsync();
        }

        public void UpdateBrand(Brand brand)
        {
            context.Brands.Update(brand);
            context.SaveChanges();
        }

        public void DeleteBrand(Brand brand)
        {
            context.Brands.Remove(brand);
            context.SaveChanges();
        }

        public Brand GetBrandById(int id)
        {
            return (Brand) context.Brands.Single(x => x.BrandId == id);
        }

        public Brand GetBrandByName(string name)
        {
            return (Brand) context.Brands.Single(x => x.BrandName == name);
        }

        public Task<List<Brand>> GetAllBrandsAsync()
        {
            return context.Brands.Select(x => x).ToListAsync();
        }

        /// <summary>
        /// CRUD methods for my Categories
        /// </summary>
        /// <param name="category"></param>
        public void AddCategoryAsync(Category category)
        {
            context.Categories.AddAsync(category);
            context.SaveChangesAsync();
        }

        public void UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public Category GetCategoryById(int id)
        {
            return (Category) context.Categories.Single(x => x.CategoryId == id);
        }

        public Category GetCategoryByName(string name)
        {
            return (Category) context.Categories.Single(x => x.CategoryName == name);
        }

        public Task<List<Category>> GetAllCategoriesAsync()
        {
            return context.Categories.Select(x => x).ToListAsync();
        }

        /// <summary>
        /// CRUD methods for my Inventories
        /// </summary>
        /// <param name="inventory"></param>
        public void AddInventoryAsync(Inventory inventory)
        {
            context.Inventories.AddAsync(inventory);
            context.SaveChangesAsync();
        }

        public void UpdateInventory(Inventory inventory)
        {
            context.Inventories.Update(inventory);
            context.SaveChanges();
        }

        public void DeleteInventory(Inventory inventory)
        {
            context.Inventories.Remove(inventory);
            context.SaveChanges();
        }

        public Inventory GetInventoryById(int id)
        {
            return (Inventory) context.Inventories.Single(x => x.InventoryId == id);
        }

        public Inventory GetInventoryByLocationIdProductId(int locationId, int productId) {
            return (Inventory) context.Inventories.Single(x => x.LocationId == locationId && x.ProductId == productId);
        }

        public List<Inventory> GetAllInventoryItemsByLocationId(int locationId) {
        return context.Inventories.Select(x => x).Where(x => x.LocationId == locationId).ToList();
        }

        public List<Inventory> GetAllInventoryById(int id)
        {
            return context.Inventories.Where(x => x.InventoryId == id).ToList();
        }

        /// <summary>
        /// CRUD methods for my Locations
        /// </summary>
        /// <param name="location"></param>
        public void AddLocationAsync(Location location)
        {
            context.Locations.AddAsync(location);
            context.SaveChangesAsync();
        }

        public void UpdateLocation(Location location)
        {
            context.Locations.Update(location);
            context.SaveChanges();
        }

        public void DeleteLocation(Location location)
        {
            context.Locations.Remove(location);
            context.SaveChanges();
        }

        public Location GetLocationById(int id)
        {
            return (Location) context.Locations.Single(x => x.LocationId == id);
        }

        public Location GetLocationByName(string name)
        {
            return (Location) context.Locations.Single(x => x.LocationName == name);
        }

        public List<Location> GetAllLocations()
        {
            return context.Locations.Select(x => x).ToList();
        }

        /// <summary>
        /// CRUD methods for my OrderLines
        /// </summary>
        /// <param name="orderline"></param>
        public void AddOrderLineAsync(OrderLine orderline)
        {
            context.OrderLines.AddAsync(orderline);
            context.SaveChangesAsync();
        }

        public void UpdateOrderLine(OrderLine orderLine)
        {
            context.OrderLines.Update(orderLine);
            context.SaveChanges();
        }

        public void DeleteOrderLine(OrderLine orderLine)
        {
            context.OrderLines.Remove(orderLine);
            context.SaveChanges();
        }

        public OrderLine GetOrderLineByOrderLineId(int id)
        {
            return (OrderLine) context.OrderLines.Single(x => x.OrderLineId == id);
        }

        public Task<List<OrderLine>> GetAllOrderLinesAsync()
        {
            return context.OrderLines.Select(x => x).ToListAsync();
        }

        /// <summary>
        /// CRUD methods for my Orders
        /// </summary>
        /// <param name="order"></param>
        public void AddOrderAsync(Order order)
        {
            context.Orders.AddAsync(order);
            context.SaveChangesAsync();
        }

        public void UpdateOrder(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        public Order GetOrderById(int id)
        {
            return (Order) context.Orders.Single(x => x.OrderId == id);
        }

        public Task<List<Order>> GetAllOrdersAsync()
        {
            return context.Orders.Select(x => x).ToListAsync();
        }

        /// <summary>
        /// CRUD methods for my Products
        /// </summary>
        /// <param name="product"></param>
        public void AddProductAsync(Product product)
        {
            context.Products.AddAsync(product);
            context.SaveChangesAsync();
        }

        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return (Product) context.Products.Single(x => x.ProductId == id);
        }

        public Product GetProductByName(string name)
        {
            return (Product) context.Products.Single(x => x.ProductName == name);
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            return context.Products.Select(x => x).ToListAsync();
        }

        /// <summary>
        /// CRUD methods for my Users
        /// </summary>
        /// <param name="user"></param>
        public void AddUserAsync(User user)
        {
            context.Users.AddAsync(user);
            context.SaveChangesAsync();
        }

        public void UpdateUser(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            return (User) context.Users.Single(x => x.UserID == id);
        }

        public User GetUserByName(string name)
        {
            return (User) context.Users.Single(x => x.Name == name);
        }

        public User GetUserByManagerStatus(bool status)
        {
            return (User) context.Users.Single(x => x.ManagerStatus == true);
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            return context.Users.Select(x => x).ToListAsync();
        }

        /// <summary>
        /// CRUD methods for my Carts
        /// </summary>
        /// <param name="cart"></param>
        public void AddCartAsync(Cart cart)
        {
            context.Carts.AddAsync(cart);
            context.SaveChangesAsync();
        }

        public void UpdateCart(Cart cart)
        {
            context.Carts.Update(cart);
            context.SaveChanges();
        }

        public void DeleteCart(Cart cart)
        {
            context.Carts.Remove(cart);
            context.SaveChanges();
        }

        public Cart GetCartById(int id)
        {
            return (Cart) context.Carts.Single(x => x.CartId == id);
        }

        public Cart GetCartByUserId(int id) 
        {
            return (Cart) context.Carts.Single(x => x.UserId == id);
        }

        /// <summary>
        /// CRUD methods for CartLines
        /// </summary>
        /// <param name="cartLine"></param>
        public void AddCartLineAsync(CartLine cartLine)
        {
            context.CartLines.AddAsync(cartLine);
            context.SaveChangesAsync();
        }

        public void UpdateCartLine(CartLine cartLine)
        {
            context.CartLines.Update(cartLine);
            context.SaveChanges();
        }

        public void DeleteCartLine(CartLine cartLine)
        {
            context.CartLines.Remove(cartLine);
            context.SaveChanges();
        }

        public CartLine GetCartLineById(int id)
        {
            return (CartLine) context.CartLines.Single(x => x.CartLineId == id);
        }

        public Task<List<CartLine>> GetAllCartLinesByCartIdAsync(int id)
        {
            return context.CartLines.Select(x => x).ToListAsync();
        }
    }
}