using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook
{
    class Truyen
    {
        private int id;
        private string tenTruyen;
        private int namSangTac;
        private int soLuongNhanVat;
        private string moTa;
        public Truyen()
        {
        }
        public Truyen(int id,string tenTruyen,int namSangTac,int soLuongNhanVat,string moTa)
        {
            this.id = id;
            this.tenTruyen = tenTruyen;
            this.namSangTac = namSangTac;
            this.soLuongNhanVat = soLuongNhanVat;
            this.moTa = moTa;
        }

        public int Id { get => id; set => id = value; }
        public string TenTruyen { get => tenTruyen; set => tenTruyen = value; }
        public int NamSangTac { get => namSangTac; set => namSangTac = value; }
        public int SoLuongNhanVat { get => soLuongNhanVat; set => soLuongNhanVat = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
