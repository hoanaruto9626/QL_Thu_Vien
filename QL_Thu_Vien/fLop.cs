using System.Data;

namespace QL_Thu_Vien
{
    public partial class fLop : Form
    {
        DataTable dataThuVien;

        public fLop()
        {
            InitializeComponent();
        }

        private void fLop_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnSkip.Enabled = false;
            txtMaLop.Enabled = false;
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSkip.Enabled = true;
            btnSave.Enabled = true;
            ResetValues();
            txtMaLop.Enabled = true;
            txtMaLop.Focus();
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Lop";
            dataThuVien = DBConnection.GetDataToTable(sql);
            dgvDSLop.DataSource = dataThuVien;
            dgvDSLop.Columns[0].HeaderText = "Mã lớp";
            dgvDSLop.Columns[1].HeaderText = "Tên khoa";
            dgvDSLop.Columns[2].HeaderText = "Tên lớp";

            // Tăng kích thước mỗi cột
            dgvDSLop.Columns[0].Width = 100; // Kích thước cột "Mã lớp"
            dgvDSLop.Columns[1].Width = 350; // Kích thước cột "Tên lớp"
            dgvDSLop.Columns[2].Width = 300; // Kích thước cột "Tên khoa"

            dgvDSLop.AllowUserToAddRows = false;
            dgvDSLop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvDSLop_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có đang ở chế độ "Thêm mới" hay không
            if (btnAdd.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLop.Focus();
                return;
            }

            // Kiểm tra xem có dữ liệu trong DataGridView hay không
            if (dgvDSLop.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra nếu không có hàng nào được chọn
            if (dgvDSLop.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn dòng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu từ hàng hiện tại và gán vào các TextBox
            txtMaLop.Text = dgvDSLop.CurrentRow.Cells["MaLop"].Value?.ToString() ?? string.Empty;
            txtTenLop.Text = dgvDSLop.CurrentRow.Cells["TenLop"].Value?.ToString() ?? string.Empty;
            txtKhoa.Text = dgvDSLop.CurrentRow.Cells["TenKhoa"].Value?.ToString() ?? string.Empty;

            // Bật các nút Sửa, Xóa, và Bỏ Qua
            btnExit.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xác nhận xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Lop WHERE MaLop=N'" + txtMaLop.Text + "'";
                DBConnection.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;

            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoa.Focus();
                return;
            }

            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            // Câu lệnh UPDATE với các trường cần thiết
            sql = "UPDATE Lop SET TenLop = N'" + txtTenLop.Text.Trim() +
                              "', TenKhoa = N'" + txtKhoa.Text.Trim() +
                              "' WHERE MaLop = N'" + txtMaLop.Text.Trim() + "'";

            DBConnection.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnSkip.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;
            txtMaLop.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập mã sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLop.Focus();
                return;
            }
            if (txtKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tên sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoa.Focus();
                return;
            }
            if (txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn hãy nhập tác giả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.Focus();
                return;
            }

            sql = "INSERT INTO Lop (MaLop, TenKhoa, TenLop) " +
                  "VALUES (N'" + txtMaLop.Text.Trim() + "', N'" + txtKhoa.Text.Trim() + "', N'" + txtTenLop.Text.Trim() + "')";

            try
            {
                DBConnection.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kích hoạt các nút điều hướng
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSkip.Enabled = false;
            btnSave.Enabled = false;

            txtMaLop.Enabled = false; // Vô hiệu hóa ô mã sách sau khi lưu
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Xác nhận đóng chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ResetValues()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoa.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
