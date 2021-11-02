using ISOS.Weather.Scoring.Core.UI.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOS.Weather.Scoring.Core.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string sourceFilePath = txtSour.Text;
            string compareFilePath = txtcompare.Text;
            int errorCountThreshold = (int)txtErrCountThreshold.Value;
            string res = CompareFileHelper.ExecCompare(sourceFilePath, compareFilePath, errorCountThreshold);

            txtResultMessage.Text = res;
        }

        private void labSelSour_Click(object sender, EventArgs e)
        {
            txtSour.Text = SelectFilePath();
        }

        private void labSelCompare_Click(object sender, EventArgs e)
        {
            txtcompare.Text = SelectFilePath();
        }

        private string SelectFilePath()
        {
            string path = string.Empty;
            try
            {
                OpenFileDialog fileDialog = new()
                {
                    Multiselect = false,
                    Title = "请选择文件",
                    Filter = "所有文件(*xls*)|*.xls*" //设置要选择的文件的类型
                };
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = fileDialog.FileName;//返回文件的完整路径                
                }
            }
            catch (Exception ex)
            {
                txtResultMessage.Text = ex.Message;
            }

            return path;
        }
    }
}
