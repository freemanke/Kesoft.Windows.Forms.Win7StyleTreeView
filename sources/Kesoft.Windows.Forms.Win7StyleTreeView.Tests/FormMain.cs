using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kesoft.Windows.Forms.Win7StyleTreeView.Tests
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            propertyGrid1.SelectedObject = win7StyleTreeView1;
        }
    }
}
