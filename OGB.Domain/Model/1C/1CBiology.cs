﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class _1CBiology
    {
        public int Id { get; set; }
        public double TestAvarage {  get; set; }
        public double ShortQuizAvarage { get; set; }
        public double HomeworkAvarage { get; set; }
        public int StudentRef { get; set; }
        public _1CStudent _1CStudent { get; set; }
    }
}
