﻿using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniProject
{
    public partial class PersonEntry : Form
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public PersonEntry()
        {
            InitializeComponent();
        }

    }
}
