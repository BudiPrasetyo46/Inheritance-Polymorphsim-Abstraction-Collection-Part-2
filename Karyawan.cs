﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhPolAbsCollTugas8
{
    public abstract class Karyawan
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public abstract double Gaji();
    }
}
