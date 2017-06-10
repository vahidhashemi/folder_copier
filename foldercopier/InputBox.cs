using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foldercopier
{
    public partial class InputBox : Form
    {
        private IAnswer result;
        public InputBox()
        {
            InitializeComponent();
        }

        
        public void setAnswer(IAnswer result)
        {
            this.result = result;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            result.answer(textBox1.Text);
            Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            result.answer(null);
            Hide();
        }
    }
}
