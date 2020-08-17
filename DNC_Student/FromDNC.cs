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
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace DNC_Student
{
    public partial class FromDNC : RadForm
    {
        int currentPage;
        int lastPage;
        bool isFirstTimes;
        List<string> listMSSV = new List<string>();
        List<string> listHoTen = new List<string>();
        List<string> listKey = new List<string>();

        public FromDNC()
        {
            InitializeComponent();
            currentPage = 1;
            isFirstTimes = false;
            SetFormInCenter();
            RadMessageBox.SetThemeName(this.ThemeName);
        }

        #region Events
        private async void btnTraCuu_Click(object sender, EventArgs e)
        {
            isFirstTimes = true;
            currentPage = 1;
            ClearComboBoxAndGridView();
            if (InputDataIsEmpty() || !await SearchData())
            {
                RadMessageBox.Show("Không tìm thấy thông tin", "Thông báo",
                                    MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            
            for (int i = 1; i <= lastPage; i++)
            {
                cboPages.Items.Add(i.ToString());
            }
            cboPages.SelectedIndex = 0;
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
        
        private void dataGridViewSinhVien_CellClick(object sender, GridViewCellEventArgs e)
        {
            dataGridViewSinhVien_RowHeaderMouseClick(sender, null);
        }

        private async void cboTrang_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!isFirstTimes)
            {
                currentPage = Convert.ToInt32(cboPages.SelectedText);
                await SearchData();
                UpdateDataGridView();
            }
        }

        private void lblTacGia_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RadMessageBox.Show("DH16TIN02: Nguyễn Quốc Tín, Nguyễn Ngọc Trọng Tín, Bùi Văn Khương\r\n"
                                + "DH18TIN01: Huỳnh Trung Tín, Nguyễn Thành Trí\r\n"
                                + "DH19TIN03: Lê Trần Hoài Bảo",
                                "Nhóm tác giả",
                                MessageBoxButtons.OK,
                                RadMessageIcon.Info);
            }
        }

        private void txtTinhTrang_TextChanged(object sender, EventArgs e)
        {
            var thisTextBox = sender as RadTextBox;

            if (thisTextBox.Text=="Thôi học" || thisTextBox.Text == "Bảo lưu")
            {
                thisTextBox.ForeColor = Color.Red;
            }
            else
            {
                thisTextBox.ForeColor = SystemColors.WindowText;
            }
            txtTinhTrang.Refresh();
        }

        private void FromDNC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void linkChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowserWithURL("http://student.nctu.edu.vn/XemDiem.aspx?k=");
        }

        private void linkLichHoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenBrowserWithURL("http://student.nctu.edu.vn/XemLichHoc.aspx?k=");
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
            lastPage = DNCRegex.GetSoTrangHienThi(responseText);
            listMSSV = DNCRegex.GetListMSSV(responseText);
            listHoTen = DNCRegex.GetListHoTen(responseText);
            listKey = DNCRegex.GetListKey(responseText);

            if (listHoTen.Count == 0 || lastPage > 150)
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

            StringContent data = new StringContent("{\"currentPage\":" + currentPage
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
                dataGridViewSinhVien.Rows.Add((20 * (currentPage - 1)) + i + 1, 
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
            cboPages.Text = "";
            cboPages.Items.Clear();
            dataGridViewSinhVien.Rows.Clear();
        }

        void SetFormInCenter()
        {
            int screenH = Screen.PrimaryScreen.Bounds.Height;
            int screenW = Screen.PrimaryScreen.Bounds.Width;
            int centerX = screenW / 2 - this.Width / 2;
            int centerY = screenH / 2 - this.Height / 2;
            this.Location = new Point(centerX-80, centerY-50);
        }

        void OpenBrowserWithURL(string url)
        {
            try
            {
                string key;
                if (dataGridViewSinhVien.RowCount == 1)
                {
                    key = dataGridViewSinhVien.Rows[0].Cells[3].Value.ToString();
                }
                else
                {
                    key = dataGridViewSinhVien.SelectedRows[0].Cells[3].Value.ToString();
                }
                url += key;
                Process.Start(url);
            }
            catch
            {
                RadMessageBox.Show("Không có gì để xem!!!", "Thông báo");
            }
        }

        #endregion
    }
}
