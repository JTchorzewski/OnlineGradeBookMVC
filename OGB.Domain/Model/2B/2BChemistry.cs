﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _2BChemistry
    {
        public int Id { get; set; }
        public double TestAvarage {  get; set; }
        public double ShortQuizAvarage { get; set; }
        public double HomeworkAvarage { get; set; }
        public int StudentRef { get; set; }
        public _2BStudent _2BStudent { get; set; }
    }
}
