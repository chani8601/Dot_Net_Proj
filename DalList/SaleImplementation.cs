using DO;
using DalApi;

namespace Dal
{
    //delegate bool func(Sale s);
    public class SaleImplementation : ISale
    {
        public int Create(Sale item)
        {
            if (!DataSource.sales.Any(Sale => Sale.Id == item.Id))
            {
                DataSource.sales.Add(item);
                return item.Id;
            }
            throw new DO.DalAlreadyExistsException("Sale", item.Id);
        }
        public Sale Read(int id)
        {
            var sale = DataSource.sales.FirstOrDefault(s => s.Id == id);

            if (sale == null)
                throw new DalNotFoundException("Sale", id);

            return sale;
        }

        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            if (filter == null)
                return new List<Sale>(DataSource.sales);
            return DataSource.sales.Where(filter).ToList();
        }
        public void Delete(int id)
        {
            int removed = DataSource.sales.RemoveAll(s => s.Id == id);

            if (removed == 0)
                throw new DalNotFoundException("Sale", id);
        }

        public void Update(Sale s)
        {
            int index = DataSource.sales.FindIndex(x => x.Id == s.Id);

            if (index == -1)
                throw new DalNotFoundException("Sale", s.Id);

            DataSource.sales[index] = s;
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            var s = DataSource.sales.FirstOrDefault(filter);
            if (s != null)
                return s;
            throw new Exception("The Sale was not found according to the requested condition.\r\n");
            //throw new DalNotFoundException("Sale",0);
        }
    }
}
