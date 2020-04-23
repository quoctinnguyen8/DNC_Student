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
            LoadAnhSinhVien();
            string responseText = await GetResponseText();
            txtHoTen.Text = GetHoTen(responseText);
            txtKey.Text = GetKey(responseText);

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên", "Thông báo");
            }

            txtKetQua.Text = responseText;
        }

        void LoadAnhSinhVien()
        {
            picSinhVien.Hide();
            picSinhVien.LoadAsync("http://student.nctu.edu.vn/GetImage.aspx?MSSV=" + txtMSSV.Text);
            picSinhVien.Show();
        }



        string GetHoTen(string input)
        {
            string regex = @"(?<=<td>)[^0-9<>]+?(?=<\/td>)";
            var ketQua = Regex.Match(input, regex).Value;
            return ketQua;
        }

        string GetKey(string input)
        {
            string regex = @"(?<=Diem\.aspx\?k=)[^""]+?(?=\\"")";
            var ketQua = Regex.Match(input, regex).Value;
            return ketQua;
        }

        async Task<string> GetResponseText()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.122 Safari/537.36");
            client.DefaultRequestHeaders.Add("X-AjaxPro-Method", "GetDanhSachSinhVien");

            StringContent data = new StringContent("{\"currentPage\":1,\"maSinhVien\":\"" + txtMSSV.Text + "\",\"hoDem\":\"\",\"Ten\":\"\",\"ngaySinh\":\"\",\"maLopHoc\":\"\"}");

            string link = "http://student.nctu.edu.vn/ajaxpro/TraCuuThongTin,PMT.Web.PhongDaoTao.ashx";
            HttpResponseMessage response = await client.PostAsync(link, data);

            string text = await response.Content.ReadAsStringAsync();
            return text;
        }
    }
}
