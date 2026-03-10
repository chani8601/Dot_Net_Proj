using DO;
using DalApi;
namespace Dal
{
    public class ProductImplementation : IProduct
    {
        public int Create(Product item)
        {
            if (!DataSource.products.Any(Product => Product.Id == item.Id))
            {
                DataSource.products.Add(item);
                return item.Id;
            }
            throw new DO.DalAlreadyExistsException("Product", item.Id);
        }

        public Product Read(int id)
        {
            var product = DataSource.products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                throw new DalNotFoundException("Product", id);

            return product;
        }

        public List<Product> ReadAll(Func<Product, bool>? filter = null)
        {
            if (filter == null)
                return new List<Product>(DataSource.products);
            return DataSource.products.Where(filter).ToList();
        }


        public void Delete(int id)
        {
            int removed = DataSource.products.RemoveAll(p => p.Id == id);

            if (removed == 0)
                throw new DalNotFoundException("Product", id);
        }

        public void Update(Product p)
        {
            Delete(p.Id);
            DataSource.products.Add(p);
        }
        public Product? Read(Func<Product, bool> filter)
        {
            var p = DataSource.products.FirstOrDefault(filter);
            if (p != null)
                return p;
            throw new Exception("The Product was not found according to the requested condition.\r\n");
            //throw new DalNotFoundException("Product",0);
        }

    }
}