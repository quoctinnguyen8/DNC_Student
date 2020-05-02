using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace DNC_Student
{
    public partial class Form1 : Form
    {
        int trangHienTai;
        int trangCuoi;
        bool isFirstTimes;
        List<string> listMSSV = new List<string>();
        List<string> listHoTen = new List<string>();
        List<string> listKey = new List<string>();

        public Form1()
        {
            InitializeComponent();
            trangHienTai = 1;
            isFirstTimes = false;
        }

        #region Events
        private async void btnTraCuu_Click(object sender, EventArgs e)
        {
            isFirstTimes = true;
            trangHienTai = 1;
            ClearComboBoxAndGridView();
            if (InputDataIsEmpty() || !await SearchData())
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            for (int i = 1; i <= trangCuoi; i++)
            {
                cboTrang.Items.Add(i);
            }
            cboTrang.SelectedIndex = 0;
            UpdateDataGridView();
            isFirstTimes = false;
        }
        
        private void dataGridViewSinhVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string mssv = dataGridViewSinhVien.SelectedRows[0].Cells[1].Value.ToString();
                string hoTen = dataGridViewSinhVien.SelectedRows[0].Cells[2].Value.ToString();
                string key = dataGridViewSinhVien.SelectedRows[0].Cells[3].Value.ToString();

                LoadAnhSinhVien(mssv);
                txtHoTen.Text = hoTen;
                ShowThongTinSinhVien(key);
            }
            catch { }
        }
        
        private void linkChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string key = dataGridViewSinhVien.SelectedRows[0].Cells[3].Value.ToString();
                string urlXemDiem = "http://student.nctu.edu.vn/XemDiem.aspx?k=" + key;
                Process.Start(urlXemDiem);
            }
            catch
            {
                MessageBox.Show("Không có gì để xem!!!", "Thông báo");
            }
        }
        
        private void dataGridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSinhVien_RowHeaderMouseClick(sender, null);
        }

        private async void cboTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFirstTimes)
            {
                trangHienTai = Convert.ToInt32(cboTrang.SelectedItem);
                await SearchData();
                UpdateDataGridView();
            }
        }

        private void lblTacGia_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("DH16TIN02: Nguyễn Quốc Tín, Nguyễn Ngọc Trọng Tín, Bùi Văn Khương\r\n"
                                + "DH18TIN01: Huỳnh Trung Tín, Nguyễn Thành Trí\r\n"
                                + "DH19TIN03: Lê Trần Hoài Bảo",
                                "Nhóm tác giả",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {
            var thisTextBox = sender as TextBox;

            if (thisTextBox.Text.Equals("Thôi học"))
            {
                thisTextBox.ForeColor = Color.Red;
            }
            else
            {
                thisTextBox.ForeColor = SystemColors.WindowText;
            }
            txtTinhTrang.Refresh();
        }

        #endregion

        #region Functions
        async Task<bool> SearchData()
        {
            string responseText = "";
            try
            {
                responseText = await GetDNCSearchResultText();
            }
            catch
            {
                MessageBox.Show("Lỗi mạng, xin thử lại sau!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            trangCuoi = DNCRegex.GetSoTrangHienThi(responseText);
            listMSSV = DNCRegex.GetListMSSV(responseText);
            listHoTen = DNCRegex.GetListHoTen(responseText);
            listKey = DNCRegex.GetListKey(responseText);

            if (listHoTen.Count == 0 || trangCuoi > 150)
            {
                return false;
            }
            if (listHoTen.Count == 1)
            {
                LoadAnhSinhVien(listMSSV[0]);
                txtHoTen.Text = listHoTen[0];
                ShowThongTinSinhVien(listKey[0]);
            }
            return true;
        }

        async Task<string> GetDNCSearchResultText()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.122 Safari/537.36");
            client.DefaultRequestHeaders.Add("X-AjaxPro-Method", "GetDanhSachSinhVien");

            StringContent data = new StringContent("{\"currentPage\":" + trangHienTai
                                                    + ",\"maSinhVien\":\"" + txtMSSV_Input.Text
                                                    + "\",\"hoDem\":\"\",\"Ten\":\"" + txtTenSinhVien_Input.Text
                                                    + "\",\"ngaySinh\":\"\",\"maLopHoc\":\"" + txtMaLop_Input.Text
                                                    + "\"}");

            string link = "http://student.nctu.edu.vn/ajaxpro/TraCuuThongTin,PMT.Web.PhongDaoTao.ashx";
            HttpResponseMessage response = await client.PostAsync(link, data);

            string text = await response.Content.ReadAsStringAsync();
            return text;
        }

        async void ShowThongTinSinhVien(string key)
        {
            string urlXemDiem = "http://student.nctu.edu.vn/XemDiem.aspx?k=" + key;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.122 Safari/537.36");
            HttpResponseMessage response = await client.GetAsync(urlXemDiem);

            string chiTietSinhVien = await response.Content.ReadAsStringAsync();
            txtSoTinChi.Text = DNCRegex.GetSoTinChi(chiTietSinhVien);
            txtSoTinChiNo.Text = DNCRegex.GetSoTinChiNo(chiTietSinhVien);
            txtTichLuy.Text = DNCRegex.GetTrungBinhTichLuy(chiTietSinhVien);
            txtNganhHoc.Text = DNCRegex.GetNganhHoc(chiTietSinhVien);
            txtTinhTrang.Text = DNCRegex.GetTinhTrang(chiTietSinhVien);
            txtLop.Text = DNCRegex.GetLop(chiTietSinhVien);
        }
        
        void UpdateDataGridView()
        {
            dataGridViewSinhVien.Rows.Clear();
            for (int i = 0; i < listHoTen.Count; i++)
            {
                dataGridViewSinhVien.Rows.Add((20 * (trangHienTai - 1)) + i + 1, 
                                    listMSSV[i], listHoTen[i], listKey[i]);
            }
            dataGridViewSinhVien.ClearSelection();
        }

        void LoadAnhSinhVien(string mssv)
        {
            picSinhVien.LoadAsync("http://student.nctu.edu.vn/GetImage.aspx?MSSV=" + mssv);
        }

        bool InputDataIsEmpty()
        {
            return String.IsNullOrWhiteSpace(txtMSSV_Input.Text)
                && String.IsNullOrWhiteSpace(txtMaLop_Input.Text)
                && String.IsNullOrWhiteSpace(txtTenSinhVien_Input.Text);
        }

        void ClearComboBoxAndGridView()
        {
            cboTrang.Text = "";
            cboTrang.Items.Clear();
            dataGridViewSinhVien.Rows.Clear();
        }
        #endregion
    }
}
