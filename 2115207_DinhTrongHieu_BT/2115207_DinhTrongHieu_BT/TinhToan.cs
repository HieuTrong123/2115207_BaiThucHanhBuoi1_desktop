using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2115207_DinhTrongHieu_BT
{
    static class TinhToan
    {
        public static void CongHaiSo(double a,double b,ref double s)
        {
            s = a + b;
        }
        public static int TongDaySo(int n)
        {
            int kq=0;
            for (int i = 1; i <= n; i++)
            {
                kq += i;
            }
            return kq;
        }
    }
}
