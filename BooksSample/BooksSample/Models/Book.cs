﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class Book : BindableBase
    {
        //public string Title { get; set; }
        //public string Publisher { get; set; }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set
            {
                SetProperty(ref _publisher, value);
            }
        }



        public override string ToString() => Title;

    }
}
