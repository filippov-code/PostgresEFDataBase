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
        /// ��������� �������������� ��������� ������� � ����������� DataGridView
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
        /// ���������� ������ � ���� ������ �� �����
        /// </summary>
        private void ShowTables()
        {
            ShowCustomers();
            ShowOrders();
            ShowShipments();
        }

        /// <summary>
        /// ���������� ������ � ������� ����������� �� �����
        /// </summary>
        private void ShowCustomers()
        {
            customersDataGrid.DataSource = db.GetCustomers();
        }

        /// <summary>
        /// ���������� ������ � ������� ������� �� �����
        /// </summary>
        private void ShowOrders()
        {
            ordersDataGrid.DataSource = db.GetOrders();
        }

        /// <summary>
        /// ���������� ������ � ������� ��������� �� �����
        /// </summary>
        private void ShowShipments()
        {
            shipmentsDataGrid.DataSource = db.GetShipments();
        }

        /// <summary>
        /// ��������� ������ ���������� � ���� ������ �� ������ ��������� �� ����� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //������ ������ � ����� ��� �������� ������ ����������
                string newCustomerName = newCustomerNameTextBox.Text;
                int newCustomerAge = int.Parse(newCustomerAgeTextBox.Text);
                string newCustomerAddress = newCustomerAddressTextBox.Text;
                //������� ������ ����������
                Customer newCustomer = new Customer()
                {
                    Name = newCustomerName,
                    Age = newCustomerAge,
                    Address = newCustomerAddress,
                    Orders = new()
                };
                //������ ������ � ����� ��� �������� ������ ������
                double newOrderPrice = double.Parse(newOrderPriceTextBox.Text.Replace(",", "."));
                DateTime newOrderDate = newOrderDateTimePicker.Value;
                //������ ����� �����
                Order newOrder = new Order()
                {
                    Price = newOrderPrice,
                    Date = newOrderDate.ToUniversalTime()
                };
                //������ ������ � ����� ��� �������� ����� ��������
                string newShipmentCourierInfo = newShipmentCourierInfoTextBox.Text;
                //������� ����� ��������
                Shipment newShipment = new Shipment()
                {
                    CourierInfo = newShipmentCourierInfo
                };

                //����������� ����� ����� ���������� ���������
                newCustomer.Orders.Add(newOrder);
                newShipment.Order = newOrder;

                //��������� ����� ������ � ���� ������
                db.AddCustomer(newCustomer);
                db.AddOrder(newOrder);
                db.AddShipment(newShipment);
                //��������� ���������
                db.Save();

                //���������� ���������� ������� �� ���� ������
                ShowTables();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }

        /// <summary>
        /// ��������� ��������� � ������� �����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveCustomersButton_Click(object sender, EventArgs e)
        {
            try
            {
                //�������� ������ �� ������� ����������� �� �����
                Customer[] customers = (Customer[])customersDataGrid.DataSource;
                //��������� ���������� � ������ ����������
                foreach (var customer in customers)
                {
                    db.UpdateCustomer(customer);
                }
                //��������� ���������
                db.Save();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }

        /// <summary>
        /// ������� ��������� � ������� �� ����� ������ ���������� �� ���� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //�������� id ���������� � ������� �� ����� ����������
                int customerId = ((Customer)customersDataGrid.SelectedRows[0].DataBoundItem).Id;
                //�������� �� ���� ������ ���������� � ��������� id
                Customer customer = db.GetCustomer(customerId);
                //������� ����� ���������� �� ���� ������
                db.RemoveCustomer(customer);
                //��������� ��������� � ���� ������
                db.Save();

                //���������� ����������� ���������� �� ���� ������
                ShowTables();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }

        /// <summary>
        /// ��������� ����� ����� � ���� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //������ ������ � ����� ��� ������ ������
                int customerId = int.Parse(newOrderCustomerIdTextBox.Text);
                double newOrderPrice = double.Parse(newOrderPriceTextBox.Text.Replace(",", "."));
                DateTime newOrderDate = newOrderDateTimePicker.Value;
                //������� ������ ������ ������
                Order newOrder = new Order()
                {
                    Price = newOrderPrice,
                    Date = newOrderDate.ToUniversalTime()
                };
                //������ ������ � ����� ��� ����� ��������
                string newShipmentCourierInfo = newShipmentCourierInfoTextBox.Text;
                //������� ����� ��������
                Shipment newShipment = new Shipment()
                {
                    CourierInfo = newShipmentCourierInfo
                };

                //����������� ����� ����� ���������� ���������
                newShipment.Order = newOrder;
                Customer customer = db.GetCustomer(customerId);
                customer.Orders.Add(newOrder);

                //��������� ���������� � ���� ������ �� ������ ����� �������
                db.UpdateCustomer(customer);
                db.AddOrder(newOrder);
                db.AddShipment(newShipment);

                //��������� ��������� � ���� ������
                db.Save();

                //���������� ����������� �������
                ShowTables();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }
        /// <summary>
        /// ��������� ��������� � ������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                //�������� ������� ������� � �����
                Order[] orders = (Order[])ordersDataGrid.DataSource;
                //��������� ������ ��������������� ������ � ���� ������
                foreach (var order in orders)
                {
                    db.UpdateOrder(order);
                }
                //��������� ��������� � ���� ������
                db.Save();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }
        /// <summary>
        /// ������� ��������� ����� �� ���� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //�������� ��������� �� ����� ������� � ������� �������
                Order order = (Order)ordersDataGrid.SelectedRows[0].DataBoundItem;
                //������� ��� �� ���� ������
                db.RemoveOrder(order);
                //��������� ���������
                db.Save();

                //���������� ����������� �������
                ShowTables();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }
        /// <summary>
        /// ������� ��������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeShipmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //�������� ��������� � ������� �������� ��������
                Shipment shipment = (Shipment)shipmentsDataGrid.SelectedRows[0].DataBoundItem;
                //������� �� �� ���� ������
                db.RemoveShipment(shipment);
                //��������� ���������
                db.Save();

                //���������� ����������� �������
                ShowTables();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }

        /// <summary>
        /// ��������� ��������� � ������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveShipmentsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //�������� ������ �� ������� �������� �� �����
                Shipment[] shipments = (Shipment[])shipmentsDataGrid.DataSource;
                //��������� ������ ��������������� ������ �������� � ���� ������
                foreach (var shipment in shipments)
                {
                    db.UpdateShipment(shipment);
                }
                //��������� ���������
                db.Save();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }

        /// <summary>
        /// ���������� ��� ������ ���������� � ������� �� ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerIdForCountOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                //������ id ���������� � �����
                int customerId = int.Parse(customerIdForCountOrdersTextBox.Text);
                //�������� �� ���� ������ ��� ������ ����� ����������
                Order[] orders = db.GetCustomerOrders(customerId);
                //���������� �� ����� ������ ����������
                customerOrdersCountDataGrid.DataSource = orders;
                //���������� �� ����� ���������� ������� 
                customerOrdersCountResultLabel.Text = orders.Length.ToString();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }

        /// <summary>
        /// ���������� ���������� � �������� ��������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shipmentForAddressButton_Click(object sender, EventArgs e)
        {
            try
            {
                //������ id �������� � �����
                int shipmentId = int.Parse(shipmentIdForAddressTextBox.Text);
                //�������� ���������� � �������� ��������� ��������
                Customer customer = db.GetShipmentCustomer(shipmentId);
                //���������� ���������� � ������� �� �����
                addressOfShipmentDataGrid.DataSource = new Customer[] { customer };
                //���������� ����� �� �����
                addressOfShipmentResultLabel.Text = customer.Address;
            }
            catch
            {
                MessageBox.Show("������");
            }
        }

        /// <summary>
        /// ���������� ������ ���������� � �� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerIdForSumOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                //������ id ���������� � �����
                int customerId = int.Parse(customerIdForSumOrdersTextBox.Text);
                //�������� ������ ���������� �� ���� ������
                Order[] orders = db.GetCustomerOrders(customerId);
                //���������� ������ � ������� �� �����
                customerOrdersSumDataGrid.DataSource = orders;
                //���������� ����� ���� ������� �� �����
                customerOrdersSumResultLabel.Text = orders.Sum(x => x.Price).ToString();
            }
            catch
            {
                MessageBox.Show("������");
            }
        }
    }
}