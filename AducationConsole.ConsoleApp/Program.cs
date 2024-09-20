abstract class Delivery
{
    public string Address;
}

class HomeDelivery : Delivery
{
    
}

class PickPointDelivery : Delivery
{
    
}

class ShopDelivery : Delivery
{
    
}

class Product<TProductType> where TProductType : ProductType
{
    public int Id
    {
        set 
        {
            if (value > 0)
                Id = value;
        }
    }
    public string Name
    {
        get { return Name; }
        set 
        {
            if (value.Length != 0 && value != null)
                Name = value;

            else Console.WriteLine();
        }
    }
    public string Description;
    public decimal Price;

    protected TProductType Type;
}

//Тип продукта (Еда, продукты для дома и т.д.)
class ProductType
{
    public int Id;
    public string Name;
}

class ProductCart<TProduct> where TProduct : Product<ProductType>
{
    public int Id;
    public List<TProduct> Products;
    public decimal CartPrice;

    public void CalculatingPrice(List<TProduct> products) 
    {
        foreach (Product<ProductType> p in products)
        {
            CartPrice += p.Price;
        }
    }

    public void AddProduct(TProduct product) { }
    public void RemoveProduct(int id) { }
}

abstract class Coupon
{
    public int Percent;
    public virtual void ApplyCoupon() { }
}

//Купон, который применяется к определенному продукту
class CouponProduct<TProduct> : Coupon where TProduct : Product<ProductType>
{
    public int Id;
    private TProduct Product;

    public override void ApplyCoupon() { }
}

//Купон, который применяется к корзине целиком
class CouponCart<TCart> : Coupon where TCart : ProductCart<Product<ProductType>>
{
    public int Id;
    private TCart Cart;

    public override void ApplyCoupon() { }

    class Order<TDelivery, TStruct, TProduct> where TDelivery : Delivery where TProduct : Product<ProductType>
    {
        public int Id;
        public TDelivery Delivery;
        public string Description;



        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
}