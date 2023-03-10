using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_BT
{
    public class HangHoa
    {
        public string MaHang;
        public string TenHang;
        public string DVT;
        public int SoLuong;
        public int DonGia;
        public HangHoa()
        {

        }
        public string HienThi()
        {
            return $"Ma hang: {MaHang} \t ten hang: {TenHang} \t DVT: {DVT} \t So Luong: {SoLuong} \t Don Gia: {DonGia}";
        }
    }
}
