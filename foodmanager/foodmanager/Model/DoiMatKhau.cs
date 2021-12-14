using foodmanager.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodmanager.Model
{
    class DoiMatKhau
    {
        DangNhap dn = new DangNhap();
        public bool KiemTraMK(string matKhauCu)
        {
            dn.kiemtraTTDN("User.xml", View.FormMain.tenDNMain, matKhauCu);
            return true;

        }
        public void Doi(string matKhauMoi)
        {

            dn.DoiMatKhau(View.FormMain.tenDNMain, matKhauMoi);
        }
    }
}
