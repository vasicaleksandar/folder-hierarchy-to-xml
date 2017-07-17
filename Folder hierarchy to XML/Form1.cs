using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using static Folder_hierarchy_to_XML.ClassFolder;

namespace Folder_hierarchy_to_XML
{
    public partial class formFolderHierarchy : Form
    {
        public formFolderHierarchy()
        {
            InitializeComponent();
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                txtChosenDirectory.Text = folderBrowserDialog.SelectedPath;
            btnSaveXml.Enabled = true;
        }
        /*
        CreateFolderHierarchy method iterate a folder tree and place every folder and file in corresponding lists.
        CreateXmlFile method takes ClassFolder type object, makes XML file out of it, and returns it back.
        CreateTreeNode method takes ClassFolder type object, makes Tree node that fit that object and returns it back.
        */
        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            ClassFolder folder = ClassFolder.CreateFolderHierarchy(new DirectoryInfo(txtChosenDirectory.Text));
            var doc = new XDocument(ClassFolder.CreateXmlFile(folder));
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save XML file";
            saveFileDialog.Filter = "XML file|*.xml";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                txtDetails.Text = "";
                doc.Save(saveFileDialog.FileName);
                tvDirectoryHierarchy.Nodes.Clear();
                tvDirectoryHierarchy.Nodes.Add(ClassFolder.CreateTreeNode(folder));
            }

        }
        private void tvDirectoryHierarchy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txtDetails.Text = "";
            var tester = e.Node.Tag as ClassFolder;
            if (tester != null)
            {
                ClassFolder folder = (ClassFolder)e.Node.Tag;
                txtDetails.Text = folder.FolderDetails();
            }
            else
            {
                ClassFile file = (ClassFile)e.Node.Tag;
                txtDetails.Text = file.FileDetails();
            }
        }
    }
}
