using System.Xml.Linq;
using TH_05_11.model;

namespace TH_05_11
{
    public partial class Form1 : Form
    {
        private List<Customer> customers = new List<Customer>();
        private List<Service> services = new List<Service>();
        private List<Service> selectedServices = new List<Service>();
        private List<Invoice> invoices = new List<Invoice>();
        private int selectedCustomerId = -1;
        private Invoice currentInvoice;
        public Form1()
        {
            InitializeComponent();
            LoadSampleData();
            UpdateCustomerGridView();
            UpdateServiceGridView();
            dgvCustomers.CellClick += DgvCustomers_CellClick;
            lbInvoiceServices.SelectedIndexChanged += lbInvoiceServices_SelectedIndexChanged;

        }

        private void LoadSampleData()
        {
            customers.Add(new Customer(1, "Vu Dang Khoa", "0223456789", "Co Nhue 1"));
            customers.Add(new Customer(2, "Nguyen Xuan Giang", "098765431", "Co Nhue 2"));
            services.Add(new Service(1, "Rửa xe", 50000));
            services.Add(new Service(2, "Thay dầu", 120000));
            services.Add(new Service(3, "Bơm hơi", 100000));
        }

        //Update giá trị kháh hàng
        private void UpdateCustomerGridView()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = customers;
        }

        private void UpdateServiceGridView()
        {
            dgvServices.DataSource = null;
            dgvServices.DataSource = services;
        }

        private void DgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customers.Count)
            {
                Customer selectedCustomer = customers[e.RowIndex];
                selectedCustomerId = selectedCustomer.Id;

                // Hiển thị thông tin khách hàng lên giao diện
                txtId.Text = selectedCustomerId.ToString(); // Hiển thị ID
                txtTen.Text = selectedCustomer.Name;
                txtSdt.Text = selectedCustomer.Phone;
                txtDiachi.Text = selectedCustomer.Address;

                currentInvoice = invoices.FirstOrDefault(i => i.CustomerId == selectedCustomerId);

                lbInvoiceServices.Items.Clear();

                if (currentInvoice != null)
                {
                    foreach (var service in currentInvoice.Services)
                    {
                        lbInvoiceServices.Items.Add(service.Name);
                    }
                }
                else
                {
                    currentInvoice = new Invoice(invoices.Count + 1, selectedCustomerId);
                }

                UpdateTotalPrice();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Lưu thông tin hóa đơn cho khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (currentInvoice != null)
                {
                    invoices.Add(currentInvoice);
                }
                txtId.Clear();
                txtTen.Clear();
                txtSdt.Clear();
                txtDiachi.Clear();
                lbInvoiceServices.Items.Clear();
                txtPrice.Clear();
                selectedCustomerId = -1;
                currentInvoice = null;
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbInvoiceServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Kiểm tra trước khi thêm
            if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtSdt.Text) ||
                string.IsNullOrWhiteSpace(txtDiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!", "Thông báo");
                return;
            }

            int newId = customers.Count > 0 ? customers.Max(c => c.Id) + 1 : 1;
            string name = txtTen.Text;
            string phone = txtSdt.Text;
            string address = txtDiachi.Text;

            //Khoi tao moi de them khách hàng
            Customer newCustomer = new Customer(newId, name, phone, address);
            customers.Add(newCustomer);
            UpdateCustomerGridView();

            //Xóa giá trj textfield 
            txtTen.Clear();
            txtSdt.Clear();
            txtDiachi.Clear();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để chỉnh sửa!", "Thông báo");
                return;
            }
            //Tìm khách hàng theo id
            Customer selectedCustomer = customers.FirstOrDefault(c => c.Id == selectedCustomerId);
            if (selectedCustomer != null)
            {
                txtId.Text = selectedCustomerId.ToString();
                selectedCustomer.Name = txtTen.Text;
                selectedCustomer.Phone = txtSdt.Text;
                selectedCustomer.Address = txtDiachi.Text;

                UpdateCustomerGridView();

                txtTen.Clear();
                txtSdt.Clear();
                txtDiachi.Clear();
                selectedCustomerId = -1;

                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Thông báo");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Lấy vị trí giá trị khách hàng để xóa
                int selectedIndex = dgvCustomers.CurrentRow.Index;
                customers.RemoveAt(selectedIndex);
                UpdateCustomerGridView();
            }
        }
        private void UpdateTotalPrice()
        {
            if (currentInvoice != null)
            {
                txtPrice.Text = currentInvoice.TotalAmount().ToString("N0") + " VNĐ";
            }
        }

        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {

            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi thêm dịch vụ!", "Thông báo");
                return;
            }

            if (dgvServices.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để thêm vào hóa đơn!", "Thông báo");
                return;
            }

            Service selectedService = services[dgvServices.CurrentRow.Index];

            if (!currentInvoice.Services.Contains(selectedService))
            {
                currentInvoice.AddService(selectedService);
                lbInvoiceServices.Items.Add(selectedService.Name);
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Dịch vụ này đã được thêm vào hóa đơn.", "Thông báo");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để thanh toán!", "Thông báo");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Thanh toán?", "Xác nhận thanh toán", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Invoice invoiceToRemove = invoices.FirstOrDefault(i => i.CustomerId == selectedCustomerId);
                if (invoiceToRemove != null)
                {
                    invoices.Remove(invoiceToRemove);
                }

                int indexToRemove = customers.FindIndex(c => c.Id == selectedCustomerId);
                if (indexToRemove >= 0)
                {
                    customers.RemoveAt(indexToRemove);
                    UpdateCustomerGridView();
                }

                txtTen.Clear();
                txtSdt.Clear();
                txtDiachi.Clear();
                lbInvoiceServices.Items.Clear();
                txtPrice.Clear();
                selectedCustomerId = -1;
                currentInvoice = null;
                MessageBox.Show("Thành công!", "Thông báo");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
