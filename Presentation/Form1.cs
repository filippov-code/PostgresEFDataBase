using Core;
using DatabaseModels;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private DbAdapter db;
        public Form1()
        {
            InitializeComponent();

            db = new();

            DisableAutoGenerateColumns();
            ShowTables();
        }

        /// <summary>
        /// Запрещает автоматическую генерацию колонок в компонентах DataGridView
        /// </summary>
        private void DisableAutoGenerateColumns()
        {
            customersDataGrid.AutoGenerateColumns = false;
            ordersDataGrid.AutoGenerateColumns = false;
            shipmentsDataGrid.AutoGenerateColumns = false;
            customerOrdersCountDataGrid.AutoGenerateColumns = false;
            addressOfShipmentDataGrid.AutoGenerateColumns = false;
            customerOrdersSumDataGrid.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Отображает записи в базе данных на форму
        /// </summary>
        private void ShowTables()
        {
            ShowCustomers();
            ShowOrders();
            ShowShipments();
        }

        /// <summary>
        /// Отображает записи в таблице покупателей на форму
        /// </summary>
        private void ShowCustomers()
        {
            customersDataGrid.DataSource = db.GetCustomers();
        }

        /// <summary>
        /// Отображает записи в таблице заказов на форму
        /// </summary>
        private void ShowOrders()
        {
            ordersDataGrid.DataSource = db.GetOrders();
        }

        /// <summary>
        /// Отображает записи в таблице достаовок на форму
        /// </summary>
        private void ShowShipments()
        {
            shipmentsDataGrid.DataSource = db.GetShipments();
        }

        /// <summary>
        /// Добавляет нового покупателя в базу данных на основе введенных на форме данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //читаем данные с формы для создания нового покупателя
                string newCustomerName = newCustomerNameTextBox.Text;
                int newCustomerAge = int.Parse(newCustomerAgeTextBox.Text);
                string newCustomerAddress = newCustomerAddressTextBox.Text;
                //создаем нового покупателя
                Customer newCustomer = new Customer()
                {
                    Name = newCustomerName,
                    Age = newCustomerAge,
                    Address = newCustomerAddress,
                    Orders = new()
                };
                //читаем данные с формы для создания нового заказа
                double newOrderPrice = double.Parse(newOrderPriceTextBox.Text.Replace(",", "."));
                DateTime newOrderDate = newOrderDateTimePicker.Value;
                //создаём новый заказ
                Order newOrder = new Order()
                {
                    Price = newOrderPrice,
                    Date = newOrderDate.ToUniversalTime()
                };
                //читаем данные с формы для создания новой доставки
                string newShipmentCourierInfo = newShipmentCourierInfoTextBox.Text;
                //создаем новую доставку
                Shipment newShipment = new Shipment()
                {
                    CourierInfo = newShipmentCourierInfo
                };

                //настраиваем связи между созданными объектами
                newCustomer.Orders.Add(newOrder);
                newShipment.Order = newOrder;

                //добавляем новые записи в базу данных
                db.AddCustomer(newCustomer);
                db.AddOrder(newOrder);
                db.AddShipment(newShipment);
                //сохраняем изменения
                db.Save();

                //показываем обновлённую таблицы из базы данных
                ShowTables();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        /// <summary>
        /// Сохраняет изменения в таблицы покупателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveCustomersButton_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем данные из таблицы покупателей на форме
                Customer[] customers = (Customer[])customersDataGrid.DataSource;
                //обновляем информацию о каждом покупателе
                foreach (var customer in customers)
                {
                    db.UpdateCustomer(customer);
                }
                //сохраняем изменения
                db.Save();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        /// <summary>
        /// Удаляем выбранную в таблице на форме запись покупателя из базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем id выбранного в таблице на форме покупателя
                int customerId = ((Customer)customersDataGrid.SelectedRows[0].DataBoundItem).Id;
                //получаем из базы данных покупателя с выбранным id
                Customer customer = db.GetCustomer(customerId);
                //удаляем этого покупателя из базы данных
                db.RemoveCustomer(customer);
                //сохраняем изменения в базе данных
                db.Save();

                //показываеи обновленную информацию из базы данных
                ShowTables();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        /// <summary>
        /// Добавляет новый заказ в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //читаем данные с формы для нового заказа
                int customerId = int.Parse(newOrderCustomerIdTextBox.Text);
                double newOrderPrice = double.Parse(newOrderPriceTextBox.Text.Replace(",", "."));
                DateTime newOrderDate = newOrderDateTimePicker.Value;
                //создаем объект нового заказа
                Order newOrder = new Order()
                {
                    Price = newOrderPrice,
                    Date = newOrderDate.ToUniversalTime()
                };
                //читаем данные с формы для новой доставки
                string newShipmentCourierInfo = newShipmentCourierInfoTextBox.Text;
                //создаем новую доставку
                Shipment newShipment = new Shipment()
                {
                    CourierInfo = newShipmentCourierInfo
                };

                //настраиваем связи между созданными объектами
                newShipment.Order = newOrder;
                Customer customer = db.GetCustomer(customerId);
                customer.Orders.Add(newOrder);

                //обновляем информацию в базе данных на основе новый записей
                db.UpdateCustomer(customer);
                db.AddOrder(newOrder);
                db.AddShipment(newShipment);

                //сохраняем изменения в базе данных
                db.Save();

                //показываем обновленные таблицы
                ShowTables();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        /// <summary>
        /// Сохраняет изменения в таблице заказов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем таблицу заказов с формы
                Order[] orders = (Order[])ordersDataGrid.DataSource;
                //обновляем каждую соответствующую запись в базе данных
                foreach (var order in orders)
                {
                    db.UpdateOrder(order);
                }
                //сохраняем изменения в базе данных
                db.Save();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        /// <summary>
        /// Удаляет выбранный заказ из базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем выбранный на форме элемент в таблице заказов
                Order order = (Order)ordersDataGrid.SelectedRows[0].DataBoundItem;
                //удаляем его из базы данных
                db.RemoveOrder(order);
                //сохраняем изменения
                db.Save();

                //показываем обновленные таблицы
                ShowTables();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        /// <summary>
        /// Удаляет выбранную доставку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeShipmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем выбранную в таблице доставок доставку
                Shipment shipment = (Shipment)shipmentsDataGrid.SelectedRows[0].DataBoundItem;
                //удаляем ее из базы данных
                db.RemoveShipment(shipment);
                //сохраняем изменения
                db.Save();

                //показываем обновленные таблицы
                ShowTables();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        /// <summary>
        /// Сохраняет изменения в таблице доставок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveShipmentsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем записи из таблицы доставок на форме
                Shipment[] shipments = (Shipment[])shipmentsDataGrid.DataSource;
                //обновляем каждую соответствующую запись доставки в базе данных
                foreach (var shipment in shipments)
                {
                    db.UpdateShipment(shipment);
                }
                //сохраняем изменения
                db.Save();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        /// <summary>
        /// Показывает все заказы покупателя и считает их количество
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerIdForCountOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                //читаем id покупателя с формы
                int customerId = int.Parse(customerIdForCountOrdersTextBox.Text);
                //получаеи из базы данных все заказы этого покупателя
                Order[] orders = db.GetCustomerOrders(customerId);
                //отображаем на форме заказы покупателя
                customerOrdersCountDataGrid.DataSource = orders;
                //отображаем на форме количество заказов 
                customerOrdersCountResultLabel.Text = orders.Length.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        /// <summary>
        /// Показывает покупателя к которому относится доставка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shipmentForAddressButton_Click(object sender, EventArgs e)
        {
            try
            {
                //читаем id доставки с формы
                int shipmentId = int.Parse(shipmentIdForAddressTextBox.Text);
                //получаем покупателя к которому относится доставка
                Customer customer = db.GetShipmentCustomer(shipmentId);
                //отображаем покупателя в таблице на форме
                addressOfShipmentDataGrid.DataSource = new Customer[] { customer };
                //отображаем адрес на форме
                addressOfShipmentResultLabel.Text = customer.Address;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        /// <summary>
        /// Показывает заказы покупателя и их сумму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerIdForSumOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                //читаем id покупателя с формы
                int customerId = int.Parse(customerIdForSumOrdersTextBox.Text);
                //получаем заказы покупателя из базы данных
                Order[] orders = db.GetCustomerOrders(customerId);
                //отображаем заказы в таблице на форме
                customerOrdersSumDataGrid.DataSource = orders;
                //отображаем сумму всех заказов на форме
                customerOrdersSumResultLabel.Text = orders.Sum(x => x.Price).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}