﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModalModalessForm
{
	public partial class FormAbout : Form
	{
		public String Title
		{
			set { this.Text = value; }
		}
		public FormAbout()
		{
			InitializeComponent();
		}
	}
}
