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
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTruyCap_Click(object sender, EventArgs e)
        {
            
            string responseText = await GetResponseText();

            var listMSSV = DNCRegex.GetListMSSV(responseText);
            var listHoTen = DNCRegex.GetListHoTen(responseText);
            var listKey = DNCRegex.GetListKey(responseText);

            for (int i = 0; i < listHoTen.Count; i++)
            {
                dataGridViewSinhVien.Rows.Add(listMSSV[i], listHoTen[i], listKey[i]);
            }
            
            txtKey.Text = DNCRegex.GetKey(responseText);

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên", "Thông báo");
                return;
            }
                        
        }
        
        //Đã sửa
        private void dataGridViewSinhVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string mssv= dataGridViewSinhVien.SelectedRows[0].Cells[0].Value.ToString();
            string hoTen = dataGridViewSinhVien.SelectedRows[0].Cells[1].Value.ToString();
            string key = dataGridViewSinhVien.SelectedRows[0].Cells[2].Value.ToString();

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

            StringContent data = new StringContent("{\"currentPage\":1,\"maSinhVien\":\"" + txtMSSV.Text + "\",\"hoDem\":\"\",\"Ten\":\"\",\"ngaySinh\":\"\",\"maLopHoc\":\"" + txtMaLop.Text + "\"}");

            string link = "http://student.nctu.edu.vn/ajaxpro/TraCuuThongTin,PMT.Web.PhongDaoTao.ashx";
            HttpResponseMessage response = await client.PostAsync(link, data);

            string text = await response.Content.ReadAsStringAsync();
            return text;
        }

        private void linkChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Đã sửa
            string key = dataGridViewSinhVien.SelectedRows[0].Cells[2].Value.ToString();
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
    }
}
