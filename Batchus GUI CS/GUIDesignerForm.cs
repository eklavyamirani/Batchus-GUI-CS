using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BatchusGUICS
{
    public partial class GUIDesignerForm : Form
    {
        protected string FileName;
        protected bool IsSaved=false;
        public GUIDesignerForm()
        {
            InitializeComponent();
        }
        private bool SaveFileToDisk(string FileName)
        {

            try
            {
                FileStream F1 = new FileStream(FileName, FileMode.CreateNew, FileAccess.Write);
                StreamWriter SW = new StreamWriter(F1);
                string TextToSave = this.TextBox1.Text;
                SW.Write(TextToSave);
                SW.Close();
                F1.Close();
                this.IsSaved = true;
                return true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error File Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Input/Output error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        protected void SaveButtonClicked(object sender, EventArgs e)
        {
            if (!File.Exists(this.FileName) || this.FileName == string.Empty)
            {
                var F1 = new SaveFileDialog();
                F1.Filter = "Text Files|*.txt|Batch Files|*.bat";
                F1.OverwritePrompt = true;
                try
                {

                    if (F1.ShowDialog() == DialogResult.OK)
                    {
                        this.FileName = F1.FileName;
                        SaveFileToDisk(this.FileName);
                    }


                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Input/Output error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unexpected Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                SaveFileToDisk(this.FileName);
            
        }
        void OpenClicked(object sender, System.EventArgs e)
        {
            OpenFileDialog D1 = new OpenFileDialog();
            D1.Filter = "Text Files|*.txt|Batch Files|*.bat";
            if (D1.ShowDialog() == DialogResult.OK)
            {
                OpenFile(D1.FileName);
            }
        }

        bool OpenFile(string FileName)
        {
            try
            {
                FileStream FileToOpen = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
                StreamReader SR = new StreamReader(FileToOpen);
                this.TextBox1.Text = SR.ReadToEnd();
                SR.Close();
                FileToOpen.Close();
                return true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error File Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Input/Output error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
            
    }
}
