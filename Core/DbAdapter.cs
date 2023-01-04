using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class DbAdapter
    {
        private ApplicationContext dbContext;

        public DbAdapter()
        {
            dbContext = new ApplicationContext();
        }

        #region Customer
        /// <summary>
        /// Добавляет нового покупателя в базу данных
        /// </summary>
        /// <param name="customer">Добавляемый покупатель</param>
        public void AddCustomer(Customer customer)
        {
            dbContext.Customers.Add(customer);
        }
        /// <summary>
        /// Возвращает покупателя по его Id
        /// </summary>
        /// <param name="id">Id покупателя</param>
        /// <returns></returns>
        public Customer GetCustomer(int id)
        {
            return dbContext.Customers.Include(x => x.Orders).SingleOrDefault(x => x.Id == id);
        }
        /// <summary>
        /// Обновляет информацию о покупателе
        /// </summary>
        /// <param name="customer">Покупатель для обновления</param>
        public void UpdateCustomer(Customer customer)
        {
            dbContext.Customers.Update(customer);
        }
        /// <summary>
        /// Возвращает всех существующих покупателей
        /// </summary>
        /// <returns></returns>
        public Customer[] GetCustomers()
        {
            return dbContext.Customers.ToArray();
        }
        /// <summary>
        /// Удаляет покупателя из базы данных
        /// </summary>
        /// <param name="customer">Удаляемый покупатель</param>
        public void RemoveCustomer(Customer customer)
        {
            dbContext.Customers.Remove(customer);
        }
        /// <summary>
        /// Удаляет покупателя с указанным Id, если у него не осталось заказов
        /// </summary>
        /// <param name="customerId"></param>
        private void RemoveCustomerIfNoOrders(int customerId)
        {
            Customer customer = GetCustomer(customerId);

            //удаляем покупателя если у него не осталось заказов
            if (customer.Orders.Count == 0)
                RemoveCustomer(customer);
        }
        #endregion

        #region Order
        /// <summary>
        /// Добавляет новый заказ в базу данных
        /// </summary>
        /// <param name="order">Новый заказ</param>
        public void AddOrder(Order order)
        {
            dbContext.Orders.Add(order);
        }
        /// <summary>
        /// Возвращает заказ с указанным Id
        /// </summary>
        /// <param name="orderId">Id заказа</param>
        /// <returns></returns>
        public Order GetOrder(int orderId)
        {
            return dbContext.Orders.SingleOrDefault(x => x.Id == orderId);
        }
        /// <summary>
        /// Обновляет информацию о покупателе
        /// </summary>
        /// <param name="order">Заказ для обновления</param>
        public void UpdateOrder(Order order)
        {
            dbContext.Orders.Update(order);
        }
        /// <summary>
        /// Возвращает все существующие заказы
        /// </summary>
        /// <returns></returns>
        public Order[] GetOrders()
        {
            return dbContext.Orders.ToArray();
        }
        /// <summary>
        /// Удаляет заказ из базы данных
        /// </summary>
        /// <param name="order"></param>
        public void RemoveOrder(Order order)
        {
            int customerId = order.CustomerId;
            //удаляем заказ из базы данных
            dbContext.Orders.Remove(order);

            //получаем покупателя с которым связан удалённый заказ
            Customer customer = GetCustomer(customerId);
            //убираем из списка заказов покупателя удалённый заказ
            customer.Orders.Remove(order);

            //удаляем покупателя если у него не осталось заказов
            RemoveCustomerIfNoOrders(customerId);
        }
        #endregion

        #region Shipment
        /// <summary>
        /// Добавляет новую доставку в базу данных
        /// </summary>
        /// <param name="shipment">Новая доставка</param>
        public void AddShipment(Shipment shipment)
        {
            dbContext.Shipments.Add(shipment);
        }
        /// <summary>
        /// Возвращает все существующие доставки
        /// </summary>
        /// <returns></returns>
        public Shipment[] GetShipments()
        {
            return dbContext.Shipments.ToArray();
        }
        /// <summary>
        /// Обновляет информацию о доставке
        /// </summary>
        /// <param name="shipment">Доставка для обновления</param>
        public void UpdateShipment(Shipment shipment)
        {
            dbContext.Shipments.Update(shipment);
        }
        /// <summary>
        /// Удаляет доставку и связанную с ним доставку из базы данных
        /// </summary>
        /// <param name="shipment">Удаляемая доставка</param>
        public void RemoveShipment(Shipment shipment)
        {
            int orderId = shipment.OrderId;
            //удаляем доставку из базы данных
            dbContext.Shipments.Remove(shipment);

            Order order = GetOrder(orderId);
            //удаляем заказ связанный с удалённой доставкой
            RemoveOrder(order);
        }
        #endregion

        #region VariantTasks
        /// <summary>
        /// Возвращает все заказы покупателя
        /// </summary>
        /// <param name="customerId">Id покупателя</param>
        /// <returns></returns>
        public Order[] GetCustomerOrders(int customerId)
        {
            return dbContext.Orders.Where(x => x.CustomerId == customerId).ToArray();
        }
        /// <summary>
        /// Возвращает покупателя, к которому относится доставка
        /// </summary>
        /// <param name="shipmentId">Id доставки</param>
        /// <returns></returns>
        public Customer GetShipmentCustomer(int shipmentId)
        {
            int customerId = dbContext.Orders.Include(x => x.Shipment).Where(x => x.Shipment.Id == shipmentId).First().CustomerId;
            return dbContext.Customers.Where(x => x.Id == customerId).First();
        }
        #endregion

        /// <summary>
        /// Применяет изменения в базе данных
        /// </summary>
        public void Save() => dbContext.SaveChanges();
    }
}
