using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Folder_hierarchy_to_XML
{
    class ClassFolder
    {
        public ClassFolder() { }
        public ClassFolder(string name, long size, long numberOfFiles)
        {
            this.name = name;
            this.size = size;
            this.numberOfFiles = numberOfFiles;
            subFolders = new List<ClassFolder>();
            files = new List<ClassFile>();
        }
        public static ClassFolder CreateFolderHierarchy(DirectoryInfo directory)
        {
            ClassFolder folder = new ClassFolder(directory.Name, DirectorySize(directory), directory.GetFiles().Length);
            foreach (var file in directory.GetFiles())
                folder.files.Add(new ClassFile(file.Name, file.Length, file.CreationTime, file.LastAccessTime, file.LastWriteTime));
            foreach (var subDir in directory.GetDirectories())
                folder.subFolders.Add(CreateFolderHierarchy(subDir));
            return folder;
        }
        private static long DirectorySize(DirectoryInfo directory)
        {
            long size = 0;
            foreach (var dir in directory.GetDirectories())
                size += DirectorySize(dir);
            foreach (var file in directory.GetFiles())
                size += file.Length;
            return size;
        }
        public static TreeNode CreateTreeNode(ClassFolder folder)
        {
            var folderNode = new TreeNode(folder.Name);
            folderNode.Tag = folder;
            foreach (var tmpFolder in folder.subFolders)
                folderNode.Nodes.Add(CreateTreeNode(tmpFolder));
            foreach (var tmpFile in folder.files)
            {
                var tmpFileNode = new TreeNode(tmpFile.Name);
                tmpFileNode.Tag = tmpFile;
                folderNode.Nodes.Add(tmpFileNode);
            }
            return folderNode;
        }
        public static XElement CreateXmlFile(ClassFolder folder)
        {
            var info = new XElement("folder",
                            new XAttribute("folderName", folder.Name),
                            new XAttribute("folderSize", folder.Size),
                            new XAttribute("numberOfFiles", folder.NumberOfFiles));
            foreach (var tmpFolder in folder.subFolders)
                info.Add(CreateXmlFile(tmpFolder));
            foreach (var tmpFile in folder.files)
                info.Add(new XElement("file",
                            new XAttribute("fileName", tmpFile.Name),
                            new XAttribute("fileSize", tmpFile.Size),
                            new XAttribute("creationTime", tmpFile.CreationTime),
                            new XAttribute("lastAccessTime", tmpFile.LastAccessTime),
                            new XAttribute("lastModifiedTime", tmpFile.LastModifiedTime)));
            return info;
        }
        public string FolderDetails()
        {
            return "Folder name : " + this.Name + Environment.NewLine + "Folder size : " + this.Size + " bytes" + Environment.NewLine + "Number of files : " + this.NumberOfFiles;
        }







        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private long size;
        public long Size
        {
            get { return size; }
            set { size = value; }
        }
        private long numberOfFiles;
        public long NumberOfFiles
        {
            get { return numberOfFiles; }
            set { numberOfFiles = value; }
        }
        private List<ClassFolder> subFolders;
        private List<ClassFile> files;
    }
}
