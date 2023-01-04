using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabaseModels;

namespace DatabaseContext
{
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Таблица покупателей
        /// </summary>
        public DbSet<Customer> Customers {get; set;}
        /// <summary>
        /// Таблица заказов
        /// </summary>
        public DbSet<Order> Orders {get; set;}
        /// <summary>
        /// Таблица доставок
        /// </summary>
        public DbSet<Shipment> Shipments {get; set;}

        /// <summary>
        /// Настройки подключения к базе данных
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=Kolonka2022");
        }
    }
}
