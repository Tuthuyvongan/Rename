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
                txtSave.Text = directoryPath;
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
        public string a = null;
        public string b = null;
        public string c = null;
        public string chap = null;
        public int temp;
        public int i = 1;
        public int j = 1;
        public int k = 1;
        private void btRun_Click(object sender, EventArgs e)
        {
            i = 1;
            j = 1;
            k = 1;
            if (txtFile.Text != "")
            {
                chap = cbChapter.Text;
                DirectoryInfo d = new DirectoryInfo(txtFile.Text);
                FileInfo[] infos = d.GetFiles();
                temp = infos.Count();
                if (temp <= 0)
                {
                    MessageBox.Show("There are no files in the directory");
                    return;
                }
                foreach (FileInfo f in infos)
                {
                    string name = Path.GetFileNameWithoutExtension(f.FullName);
                    a = Regex.Match(name, @"\d+").Value;
                    CheckRadio();
                    if (rdAll.Checked == true)
                    {
                        while (File.Exists(f.FullName.Replace(name, c)))
                        {
                            i++;
                            CheckRadio();
                        }
                        File.Move(f.FullName, f.FullName.Replace(name, c));
                        i++;
                    }
                    else
                    {
                        if (a == "" && rdChar.Checked == true)
                        {
                            while (File.Exists(f.FullName.Replace(name, c)))
                            {
                                i++;
                                CheckRadio();
                            }
                            File.Move(f.FullName, f.FullName.Replace(name, c));
                            i++;
                        }
                        else
                        {
                            k++;
                            if (k == temp && rdChar.Checked == true)
                            {
                                MessageBox.Show("Directory without files with only letters in in name");
                                return;
                            }
                        }
                        
                        if (a != "" && rdNumber.Checked == true)
                        {
                            File.Move(f.FullName, f.FullName.Replace(name, b));
                        }
                        else
                        {
                            j++;
                            if (j == temp && rdNumber.Checked == true)
                            {
                                MessageBox.Show("Directory without files with number in in name");
                                return;
                            }
                        }
                    }
                    
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
            if (rdNumber.Checked == true)
            {
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
                    else
                    {
                        b = a.ToString().TrimStart(new Char[] { '0' });
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
            else
            {
                if (rdDefaut.Checked == true)
                {
                    c = i.ToString();
                }
                else if (rdStart.Checked == true)
                {
                    strL = txtCharL.Text;
                    c = i.ToString() + strL;
                }
                else if (rdLast.Checked == true)
                {
                    strF = txtCharF.Text;
                    c = strF + i.ToString();
                }
                else
                {
                    strF = txtCharF.Text;
                    strL = txtCharL.Text;
                    c = strF + i.ToString() + strL;
                }
            } 
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            rdDefaut.Checked = true;
            rdNumber.Checked = true;
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
            if (rdNumber.Checked == true && rdDefaut.Checked == true)
            {
                cbChapter.Text = cbChapter.Items[3].ToString();
                cbChapter.Enabled = true;
            }
            else
            {
                cbChapter.Enabled = false;
                cbChapter.Text = cbChapter.Items[0].ToString();
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
            if (rdNumber.Checked == true && rdDefaut.Checked == true)
            {
                cbChapter.Text = cbChapter.Items[3].ToString();
                cbChapter.Enabled = true;
            }
            else
            {
                cbChapter.Enabled = false;
                cbChapter.Text = cbChapter.Items[0].ToString();
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
            if (rdNumber.Checked == true && rdDefaut.Checked == true)
            {
                cbChapter.Text = cbChapter.Items[3].ToString();
                cbChapter.Enabled = true;
            }
            else
            {
                cbChapter.Enabled = false;
                cbChapter.Text = cbChapter.Items[0].ToString();
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
            if (rdNumber.Checked == true && rdDefaut.Checked == true)
            {
                cbChapter.Text = cbChapter.Items[3].ToString();
                cbChapter.Enabled = true;
            }
            else
            {
                cbChapter.Enabled = false;
                cbChapter.Text = cbChapter.Items[0].ToString();
            }
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNumber.Checked == true && rdDefaut.Checked == true)
            {
                cbChapter.Text = cbChapter.Items[3].ToString();
                cbChapter.Enabled = true;
            }
            else
            {
                cbChapter.Enabled = false;
                cbChapter.Text = cbChapter.Items[0].ToString();
            }
        }

        private void rdChar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNumber.Checked == true && rdDefaut.Checked == true)
            {
                cbChapter.Text = cbChapter.Items[3].ToString();
                cbChapter.Enabled = true;
            }
            else
            {
                cbChapter.Enabled = false;
                cbChapter.Text = cbChapter.Items[0].ToString();
            }
        }

        private void rdNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNumber.Checked == true && rdDefaut.Checked == true)
            {
                cbChapter.Text = cbChapter.Items[3].ToString();
                cbChapter.Enabled = true;
            }
            else
            {
                cbChapter.Enabled = false;
                cbChapter.Text = cbChapter.Items[0].ToString();
            }
        }
    }
}
