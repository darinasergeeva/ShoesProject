using Microsoft.EntityFrameworkCore;
using ShoesProject.Models;
using ShoesProject.Properties;

namespace ShoesProject
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrders(User user, bool guest)
        {
            InitializeComponent();

            var colNumber = new DataGridViewTextBoxColumn();
            colNumber.Name = "colNumber";
            colNumber.FillWeight = 10;
            colNumber.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 70;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 20;
            colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrders.Columns.AddRange(
            [
                colNumber,
                colInfo,
                colStatus
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var orders = db.Orders
                        .Include(o => o.User)
                        .Include(o => o.Status)
                        .Include(o => o.DeliveryPoint)
                        .Include(o => o.ProductsOrders)
                            .ThenInclude(po => po.Product)
                        .OrderByDescending(o => o.OrderDate)
                        .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colNumber"].Value = order.Code.ToString();

                        row.Cells["colInfo"].Value = FormatOrderInfo(order);

                        row.Cells["colStatus"].Value = $"{order.Status.StatusName}";
                        row.Cells["colStatus"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, order);
                    }

                    dgvOrders.ResumeLayout();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, Order order)
        {
            switch (order.Status.StatusName.ToLower())
            {
                case "новый":
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFE4B5"); // Светло-оранжевый
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.Cells["colStatus"].Style.ForeColor = Color.Orange;
                    row.Cells["colStatus"].Style.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                    break;

                case "завершён":
                case "завершен":
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#90EE90"); // Светло-зеленый
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.Cells["colStatus"].Style.ForeColor = Color.Green;
                    row.Cells["colStatus"].Style.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                    break;
            }
        }

        private string FormatOrderInfo(Order order)
        {
            string productsList = "";
            decimal totalSum = 0;

            foreach (var po in order.ProductsOrders)
            {
                decimal productPrice = po.Product.Price;
                if (po.Product.Discount > 0)
                {
                    productPrice = productPrice * (100 - po.Product.Discount) / 100;
                }

                decimal itemSum = productPrice * po.Quantity;
                totalSum += itemSum;

                productsList += $"{po.Product.Description} ({po.Quantity} шт.) = {itemSum:C}\n";
            }

            return $"Заказ №{order.Code} от {order.OrderDate:dd.MM.yyyy}\n" +
                   $"Дата доставки: {order.DeliveryDate:dd.MM.yyyy}\n" +
                   $"Клиент: {order.User.FullName}\n" +
                   $"Пункт выдачи: {order.DeliveryPoint.DeliveryAddress}\n" +
                   $"Состав заказа:\n{productsList}" +
                   $"━━━━━━━━━━━━━━━━━━━━━━\n" +
                   $"ИТОГО: {totalSum:C}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}