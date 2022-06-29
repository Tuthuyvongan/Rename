using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rename
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            txtFile.Text = null;
            OpenFileDialog file_open = new OpenFileDialog();
            file_open.ValidateNames = false;
            file_open.CheckFileExists = false;
            file_open.CheckPathExists = true;
            file_open.FileName = "Select Folder";
            //Setup open file dialog before displaying it
            file_open.Filter = "All files (*.*)|*.*";
            //Chon dang file mac dinh hien thi dau tien trong combo box neu mo nhieu loai file
            file_open.FilterIndex = 1;
            file_open.Title = "Choose file";
            if (DialogResult.OK == file_open.ShowDialog())
            {
                string filePath = file_open.FileName;
                string directoryPath = Path.GetDirectoryName(filePath);
                txtFile.Text = directoryPath;
                if(txtSave.Text == null || txtSave.Text == "")
                    txtSave.Text = directoryPath + "\\" + "Save";
            }    
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_open = new OpenFileDialog();
            file_open.ValidateNames = false;
            file_open.CheckFileExists = false;
            file_open.CheckPathExists = true;
            file_open.FileName = "Select Folder";
            //Setup open file dialog before displaying it
            file_open.Filter = "All files (*.*)|*.*";
            //Chon dang file mac dinh hien thi dau tien trong combo box neu mo nhieu loai file
            file_open.FilterIndex = 1;
            file_open.Title = "Choose file";
            if (DialogResult.OK == file_open.ShowDialog())
            {
                string filePath = file_open.FileName;
                string directoryPath = Path.GetDirectoryName(filePath);
                txtSave.Text = directoryPath;
            }
        }
        public string b = null;
        public string a = null;
        public string chap = null;
        private void btRun_Click(object sender, EventArgs e)
        {
            if (txtFile.Text != "")
            {
                chap = cbChapter.Text;
                DirectoryInfo d = new DirectoryInfo(txtFile.Text);
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    string name = Path.GetFileNameWithoutExtension(f.FullName);
                    a = Regex.Match(name, @"\d+").Value;
                    CheckRadio();
                    if (a != "")
                        File.Move(f.FullName, f.FullName.Replace(name, b));
                }
                MessageBox.Show("Finish rename");
            }
            else
                MessageBox.Show("Please choose file");
        }
        public void CheckRadio()
        {
            string strF;
            string strL;
            if (rdDefaut.Checked == true)
            {
                if (chap == "<10")
                {
                    b = a.ToString().PadLeft(2, '0');
                }
                else if (chap == "<100")
                {
                    b = a.ToString().PadLeft(3, '0');
                }
                else if (chap == "<1000")
                {
                    b = a.ToString().PadLeft(4, '0');
                }
                else if (chap == "<10000")
                {
                    b = a.ToString().PadLeft(5, '0');
                }
                else if (chap == "<100000")
                {
                    b = a.ToString().PadLeft(6, '0');
                }
            }
            else if (rdStart.Checked == true)
            {
                strL = txtCharL.Text;
                b = a.ToString().TrimStart(new Char[] { '0' }) + strL;
            }
            else if (rdLast.Checked == true)
            {
                strF = txtCharF.Text;
                b = strF + a.ToString().TrimStart(new Char[] { '0' });
            }
            else
            {
                strF = txtCharF.Text;
                strL = txtCharL.Text;
                b = strF + a.ToString() + strL;
            }    
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            cbChapter.Text = cbChapter.Items[2].ToString();
            rdDefaut.Checked = true;
            txtCharF.Enabled = false;
            txtCharL.Enabled = false;
        }

        private void rdDefaut_CheckedChanged(object sender, EventArgs e)
        {
            txtCharF.Text = null;
            txtCharL.Text = null;
            if (rdStart.Checked == true)
            {
                txtCharF.Enabled = false;
                txtCharL.Enabled = true;
            }    
            else if (rdMid.Checked == true)
            {
                txtCharF.Enabled = true;
                txtCharL.Enabled = true;
            }    
            else if (rdLast.Checked == true)
            {
                txtCharF.Enabled = true;
                txtCharL.Enabled = false;
            }   
            else
            {
                txtCharF.Enabled = false;
                txtCharL.Enabled = false;
            }    
        }

        private void rdLast_CheckedChanged(object sender, EventArgs e)
        {
            txtCharF.Text = null;
            txtCharL.Text = null;
            if (rdStart.Checked == true)
            {
                txtCharF.Enabled = false;
                txtCharL.Enabled = true;
            }
            else if (rdMid.Checked == true)
            {
                txtCharF.Enabled = true;
                txtCharL.Enabled = true;
            }
            else if (rdLast.Checked == true)
            {
                txtCharF.Enabled = true;
                txtCharL.Enabled = false;
            }
            else
            {
                txtCharF.Enabled = false;
                txtCharL.Enabled = false;
            }
        }

        private void rdMid_CheckedChanged(object sender, EventArgs e)
        {
            txtCharF.Text = null;
            txtCharL.Text = null;
            if (rdStart.Checked == true)
            {
                txtCharF.Enabled = false;
                txtCharL.Enabled = true;
            }
            else if (rdMid.Checked == true)
            {
                txtCharF.Enabled = true;
                txtCharL.Enabled = true;
            }
            else if (rdLast.Checked == true)
            {
                txtCharF.Enabled = true;
                txtCharL.Enabled = false;
            }
            else
            {
                txtCharF.Enabled = false;
                txtCharL.Enabled = false;
            }
        }

        private void rdStart_CheckedChanged(object sender, EventArgs e)
        {
            txtCharF.Text = null;
            txtCharL.Text = null;
            if (rdStart.Checked == true)
            {
                txtCharF.Enabled = false;
                txtCharL.Enabled = true;
            }
            else if (rdMid.Checked == true)
            {
                txtCharF.Enabled = true;
                txtCharL.Enabled = true;
            }
            else if (rdLast.Checked == true)
            {
                txtCharF.Enabled = true;
                txtCharL.Enabled = false;
            }
            else
            {
                txtCharF.Enabled = false;
                txtCharL.Enabled = false;
            }
        }
    }
}
