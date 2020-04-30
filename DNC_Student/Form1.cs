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

        public Form1()
        {
            InitializeComponent();
            trangHienTai = 1;
        }

        private async void btnTruyCap_Click(object sender, EventArgs e)
        {
            await TimKiemThongTin();
            for (int i = 1; i <= trangCuoi; i++)
            {
                cboTrang.Items.Add(i);
            }
            cboTrang.SelectedIndex = 0;

            UpdateDataGridView();
        }

        List<string> listMSSV = new List<string>();
        List<string> listHoTen = new List<string>();
        List<string> listKey = new List<string>();
        async Task<bool> TimKiemThongTin()
        {
            string responseText = await GetResponseText();

            trangCuoi = DNCRegex.GetSoTrangHienThi(responseText);
            listMSSV = DNCRegex.GetListMSSV(responseText);
            listHoTen = DNCRegex.GetListHoTen(responseText);
            listKey = DNCRegex.GetListKey(responseText);

            if (listHoTen.Count == 0 || trangCuoi > 150)
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thông báo");
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

        void UpdateDataGridView()
        {
            dataGridViewSinhVien.Rows.Clear();
            for (int i = 0; i < listHoTen.Count; i++)
            {
                dataGridViewSinhVien.Rows.Add(i + 1, listMSSV[i], listHoTen[i], listKey[i]);
            }
        }
        
        //Đã sửa
        private void dataGridViewSinhVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string mssv = dataGridViewSinhVien.SelectedRows[0].Cells[1].Value.ToString();
            string hoTen = dataGridViewSinhVien.SelectedRows[0].Cells[2].Value.ToString();
            string key = dataGridViewSinhVien.SelectedRows[0].Cells[3].Value.ToString();

            LoadAnhSinhVien(mssv);
            txtHoTen.Text = hoTen;
            ShowThongTinSinhVien(key);
        }

        async void ShowThongTinSinhVien(string key)
        {
            string urlXemDiem = "http://student.nctu.edu.vn/XemDiem.aspx?k=" + key;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.122 Safari/537.36");
            HttpResponseMessage response = await client.GetAsync(urlXemDiem);

            string ketQuaXemDiem = await response.Content.ReadAsStringAsync();
            txtSoTinChi.Text = DNCRegex.GetSoTinChi(ketQuaXemDiem);
            txtSoTinChiNo.Text = DNCRegex.GetSoTinChiNo(ketQuaXemDiem);
            txtTichLuy.Text = DNCRegex.GetTrungBinhTichLuy(ketQuaXemDiem);
            txtNganhHoc.Text = DNCRegex.GetNganhHoc(ketQuaXemDiem);
            txtTinhTrang.Text = DNCRegex.GetTinhTrang(ketQuaXemDiem);
            txtLop.Text = DNCRegex.GetLop(ketQuaXemDiem);

            txtKetQua.Text = ketQuaXemDiem;
        }

        async Task<string> GetResponseText()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.122 Safari/537.36");
            client.DefaultRequestHeaders.Add("X-AjaxPro-Method", "GetDanhSachSinhVien");

            StringContent data = new StringContent("{\"currentPage\":" + trangHienTai + ",\"maSinhVien\":\"" + txtMSSV.Text 
                                                    + "\",\"hoDem\":\"\",\"Ten\":\"" + txtTenSinhVien.Text 
                                                    + "\",\"ngaySinh\":\"\",\"maLopHoc\":\"" 
                                                    + txtMaLop.Text + "\"}");

            string link = "http://student.nctu.edu.vn/ajaxpro/TraCuuThongTin,PMT.Web.PhongDaoTao.ashx";
            HttpResponseMessage response = await client.PostAsync(link, data);

            string text = await response.Content.ReadAsStringAsync();
            return text;
        }

        private void linkChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Đã sửa
            string key = dataGridViewSinhVien.SelectedRows[0].Cells[3].Value.ToString();
            string urlXemDiem = "http://student.nctu.edu.vn/XemDiem.aspx?k=" + key;
            Process.Start(urlXemDiem);
        }

        //Đã sửa
        void LoadAnhSinhVien(string mssv)
        {
            picSinhVien.LoadAsync("http://student.nctu.edu.vn/GetImage.aspx?MSSV=" + mssv);
        }

        private void dataGridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSinhVien_RowHeaderMouseClick(null, null);
        }

        private async void cboTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            trangHienTai = Convert.ToInt32(cboTrang.SelectedItem);
            MessageBox.Show(trangHienTai.ToString());
            await TimKiemThongTin();
            UpdateDataGridView();
        }
    }
}
