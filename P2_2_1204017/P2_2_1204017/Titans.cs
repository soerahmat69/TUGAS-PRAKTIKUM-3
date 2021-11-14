using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204017
{
   public class Titans : Manusia
    {
        protected string kemampuan;

        public Titans(string jenis, string kemampuan) : base(jenis,kemampuan)
        {

           
            this.Jenis = jenis;
            this.Nama = "EREN YEGER";
            this.kemampuan = kemampuan;
        }

        public string Kemampuan
        {
            get
            {
                return kemampuan;
            }
            set
            {
               kemampuan = value;
            }
        }
    }
}
