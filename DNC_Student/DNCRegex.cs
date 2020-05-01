using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DNC_Student
{
    class DNCRegex
    {
        public static int GetSoTrangHienThi(string input)
        {
            string regex = @"(?<=\d+\/)\d+";
            string value = GetSingle(input, regex);
            return String.IsNullOrWhiteSpace(value) ? 1 : Convert.ToInt32(value);
        }

        public static string GetSoTinChi(string input)
        {
            string regex = @"(?<=lblTongTinChi.+>)\d+";
            return GetSingle(input, regex);
        }

        public static string GetSoTinChiNo(string input)
        {
            string regex = @"(?<=lblSoTCNo.+>)[%\d. -]+";
            return GetSingle(input, regex);
        }

        public static string GetTrungBinhTichLuy(string input)
        {
            string regex = @"(?<=lblTBCTL.+>)[\d. -]+";
            return GetSingle(input, regex);
        }

        public static string GetHoTen(string input)
        {
            string regex = @"(?<=<td>)[^0-9<>]+?(?=<\/td>)";
            return GetSingle(input, regex);
        }

        public static string GetKey(string input)
        {
            string regex = @"(?<=Diem\.aspx\?k=)[^""]+?(?=\\"")";
            return GetSingle(input, regex);
        }

        public static string GetLop(string input)
        {
            string regex = @"(?<=Lớp:\s*)[\w-]+";
            return GetSingle(input, regex);
        }

        public static string GetNganhHoc(string input)
        {
            string regex = @"(?<=Ngành:\s*)\w.+";
            return GetSingle(input, regex);
        }

        public static string GetTinhTrang(string input)
        {
            string regex = @"(?<=thái:\s*<.+> ).+(?=<)";
            return GetSingle(input, regex);
        }

        public static List<string> GetListMSSV(string input)
        {
            string regex = @"\d{6,12}";
            return GetList(input, regex);
        }

        public static List<string> GetListHoTen(string input)
        {
            string regex = @"(?<=<td>)[^0-9<].+?(?=<\/)";
            return GetList(input, regex);
        }

        public static List<string> GetListKey(string input)
        {
            string regex = @"(?<=Diem\.aspx\?k=)[^""]+?(?=\\"")";
            return GetList(input, regex);
        }

        static List<string> GetList(string input, string regex)
        {
            List<string> listKetQua = Regex.Matches(input, regex)
                                        .Cast<Match>()
                                        .Select(m => m.Value)
                                        .ToList();
            return listKetQua;
        }
        
        static string GetSingle(string input, string regex)
        {
            var ketQua = Regex.Match(input, regex).Value;
            return ketQua;
        }
    }
}
