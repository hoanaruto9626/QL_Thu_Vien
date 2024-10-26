using QL_Thu_Vien.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Thu_Vien
{
    public partial class fphieumuon : Form
    {
        DataTable dataThuVien;

        public fphieumuon()
        {
            InitializeComponent();
            LoadComboBoxMaSV();    // Gọi hàm nạp dữ liệu cho cbMaSV
            LoadComboBoxMaSach();  // Gọi hàm nạp dữ liệu cho cbMaSach
        }

        private void fphieumuon_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
            ResetValues();
            txtMaPhieu.Text = DBConnection.CreateKey("PM");
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text) || string.IsNullOrEmpty(cbMaSV.Text) || string.IsNullOrEmpty(cbMaSach.Text) || string.IsNullOrEmpty(txtSL.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy số lượng sách hiện có
            string getSoLuongSachSql = "SELECT SoLuong FROM Sach WHERE MaSach = N'" + cbMaSach.Text + "'";
            DataTable dtSach = DBConnection.GetDataToTable(getSoLuongSachSql);

            if (dtSach.Rows.Count > 0)
            {
                int soLuongHienTai = Convert.ToInt32(dtSach.Rows[0]["SoLuong"]);
                int soLuongMuon = Convert.ToInt32(txtSL.Text);

                if (soLuongMuon > soLuongHienTai)
                {
                    MessageBox.Show("Số lượng sách không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật thông tin phiếu mượn và cập nhật số lượng sách
                string updatePhieuSql = "UPDATE Phieu SET MaSV = N'" + cbMaSV.Text + "', MaSach = N'" + cbMaSach.Text + "', SoLuongMuon = " + txtSL.Text +
                    ", NgayMuon = '" + dateNgayMuon.Value.ToString("yyyy-MM-dd") + "', NgayTra = '" + dateNgayTra.Value.ToString("yyyy-MM-dd") +
                    "' WHERE MaPhieu = N'" + txtMaPhieu.Text.Trim() + "'";
                DBConnection.RunSQL(updatePhieuSql);

                // Cập nhật số lượng sách
                string updateSoLuongSachSql = "UPDATE Sach SET SoLuong = SoLuong - " + soLuongMuon + " WHERE MaSach = N'" + cbMaSach.Text + "'";
                DBConnection.RunSQL(updateSoLuongSachSql);

                LoadDataGridView();
                ResetValues();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataThuVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phiếu mượn nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "DELETE FROM Phieu WHERE MaPhieu = N'" + txtMaPhieu.Text + "'";
            DBConnection.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnSkip.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetValues()
        {
            txtMaPhieu.Text = "";
            cbMaSV.Text = "";
            cbMaSach.Text = "";
            txtSL.Text = "";
            dateNgayMuon.Text = DateTime.Now.ToShortDateString();
            dateNgayTra.Text = DateTime.Now.ToShortDateString();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaPhieu, MaSV, MaSach, SoLuongMuon, NgayMuon, NgayTra FROM Phieu";
            dataThuVien = DBConnection.GetDataToTable(sql);
            dgvMuon.DataSource = dataThuVien;

            dgvMuon.Columns[0].HeaderText = "Mã phiếu";
            dgvMuon.Columns[1].HeaderText = "Mã sinh viên";
            dgvMuon.Columns[2].HeaderText = "Mã sách";
            dgvMuon.Columns[3].HeaderText = "Số lượng";
            dgvMuon.Columns[4].HeaderText = "Ngày mượn";
            dgvMuon.Columns[5].HeaderText = "Ngày trả";

            dgvMuon.Columns[0].Width = 170;
            dgvMuon.Columns[1].Width = 200;
            dgvMuon.Columns[2].Width = 200;
            dgvMuon.Columns[3].Width = 200;
            dgvMuon.Columns[4].Width = 200;
            dgvMuon.Columns[5].Width = 250;

            dgvMuon.AllowUserToAddRows = false;
            dgvMuon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadComboBoxMaSV()
        {
            string sql = "SELECT MaSV, TenSV FROM SinhVien";
            DataTable dataSV = DBConnection.GetDataToTable(sql);
            cbMaSV.DataSource = dataSV;
            //cbMaSV.DisplayMember = "TenSV";
            cbMaSV.ValueMember = "MaSV";
            cbMaSV.SelectedIndex = -1;
        }

        private void LoadComboBoxMaSach()
        {
            string sql = "SELECT MaSach, TenSach FROM Sach";
            DataTable dataSach = DBConnection.GetDataToTable(sql);
            cbMaSach.DataSource = dataSach;
            //cbMaSach.DisplayMember = "TenSach";
            cbMaSach.ValueMember = "MaSach";
            cbMaSach.SelectedIndex = -1;
        }

        private void dgvPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
