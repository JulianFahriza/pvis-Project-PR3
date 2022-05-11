using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class DataTas : connection
    {
        public String ID_TAS { set; get; }
        public String foto_tas { set; get; }
        public String JENIS_TAS { set; get; }
        public String MERK_TAS { set; get; }
        public int HARGA_TAS { set; get; }
        public DateTime TGL_MASUK { set; get; }

        internal static string insert()
        {
            throw new NotImplementedException();
        }
    }
}
