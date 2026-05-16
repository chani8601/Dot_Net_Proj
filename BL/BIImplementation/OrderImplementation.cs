using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIApi;
using BL.BO;
using BO;
using DO;




namespace BIImplementation
{
    internal class OrderImplementation : BIApi.IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void DoOrder(Order order)
        {
            foreach (var item in order.products)
            {
                var product = _dal.Product.Read(item.id);
                if (product?.Amount < item.amount)
                    throw new Exception("אין מספיק במלאי");
                var updatedProduct = product with { Amount = product.Amount - item.amount };
                _dal.Product.Update(product);

            }
        }
        public void CalcTotalPrice(BO.Order order)
        {
            order.final_price += (from p in order.products select p.final_price).Sum();
        }
        public List<SaleInProduct> AddProductToOrder(Order order, int idProduct, int amountProduct)
        {
            var product = _dal.Product.Read(idProduct);
            var IsExistProduct = order.products.FirstOrDefault(p => p.id == product.Id);
            if(IsExistProduct != null)
            {
                if (IsExistProduct.amount + amountProduct > product.Amount)
                    throw new Exception("אין מספיק במלאי");
                IsExistProduct.amount += amountProduct;
            }
            else
            {
                if (amountProduct > product.Amount)
                    throw new Exception("אין מספיק במלאי עבור מוצר זה");
                else
                {
                    var newProductInOrder = new BO.ProductInOrder
                    {
                        id = product.Id,
                        amount = amountProduct,
                        basic_price = product.Price,
                        name = product.NameP

                    };

                    order.products.Add(newProductInOrder);
                    IsExistProduct = newProductInOrder;
                    SearchSaleForProduct(IsExistProduct, true);
                    CalcTotalPriceForProduct(IsExistProduct);
                    CalcTotalPrice(order);
                }
            }
            return IsExistProduct.sales;
        }

        public void SearchSaleForProduct(ProductInOrder productInOrder, bool IsPreferredCustomer)
        {
            var sales = _dal.Sale.ReadAll(s => s.IdP == productInOrder.id &&
            s.StartSale <= DateTime.Now && s.EndSale >= DateTime.Now &&
            productInOrder.amount >= s.MinAmount &&
            (IsPreferredCustomer || s.IfEveryone))
                .Select(s => new SaleInProduct { id = s.Id, price = s.AllPrice, amount = s.MinAmount, if_everyone = s.IfEveryone })
                .OrderBy(s => s.price / s.amount).ToList();
            productInOrder.sales = sales;
        }

        public void CalcTotalPriceForProduct(ProductInOrder productInOrder)
        {
            int count = productInOrder.amount;
            double totalPrice = 0;
            List<SaleInProduct> usedSales = new List<SaleInProduct>();

            foreach (SaleInProduct sale in productInOrder.sales)
            {
                if (count < sale.amount)
                    continue;

                int times = count / sale.amount;
                totalPrice += times * sale.price;
                count -= times * sale.amount;
                usedSales.Add(sale);

                if (count == 0)
                    break;
            }

            totalPrice += count * productInOrder.basic_price;
            productInOrder.sales = usedSales;
            productInOrder.final_price = totalPrice;
        }
    }
}
