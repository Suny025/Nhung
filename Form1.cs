using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chọn mặc định khoa QTKD
            cmbFaculty.SelectedIndex = 0;
            // Giới tính Nữ mặc định
            optFemale.Checked = true;
            // Tổng SV Nam/Nữ = 0
            txtMaleCount.Text = "0";
            txtFemaleCount.Text = "0";
        }

        // Lấy index của dòng có MSSV
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null &&
                    dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        // Thêm hoặc Cập nhật dữ liệu
        private void InsertUpdate(int rowIndex)
        {
            dgvStudent.Rows[rowIndex].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[rowIndex].Cells[1].Value = txtFullName.Text;
            dgvStudent.Rows[rowIndex].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[rowIndex].Cells[3].Value = txtAverageScore.Text;
            dgvStudent.Rows[rowIndex].Cells[4].Value = cmbFaculty.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtAverageScore.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rowIndex = GetSelectedRow(txtStudentID.Text);
            if (rowIndex == -1)
            {
                // Thêm mới
                dgvStudent.Rows.Add(txtStudentID.Text, txtFullName.Text,
                                    optFemale.Checked ? "Nữ" : "Nam",
                                    txtAverageScore.Text, cmbFaculty.Text);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật
                InsertUpdate(rowIndex);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cập nhật tổng số SV Nam/Nữ
            UpdateGenderCount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = GetSelectedRow(txtStudentID.Text);
            if (rowIndex == -1)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dgvStudent.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật tổng số SV Nam/Nữ
                UpdateGenderCount();
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFullName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gender = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (gender == "Nam")
                    optMale.Checked = true;
                else
                    optFemale.Checked = true;

                txtAverageScore.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbFaculty.Text = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void UpdateGenderCount()
        {
            int male = 0, female = 0;
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    if (row.Cells[2].Value.ToString() == "Nam") male++;
                    else if (row.Cells[2].Value.ToString() == "Nữ") female++;
                }
            }
            txtMaleCount.Text = male.ToString();
            txtFemaleCount.Text = female.ToString();
        }

        // Các event handlers rỗng để tránh lỗi Designer
        private void txtStudentID_TextChanged(object sender, EventArgs e) { }
        private void txtFullName_TextChanged(object sender, EventArgs e) { }
        private void optMale_CheckedChanged(object sender, EventArgs e) { }
        private void optFemale_CheckedChanged(object sender, EventArgs e) { }
        private void txtAverageScore_TextChanged(object sender, EventArgs e) { }
        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtMaleCount_TextChanged(object sender, EventArgs e) { }
        private void txtFemaleCount_TextChanged(object sender, EventArgs e) { }
    }
}
