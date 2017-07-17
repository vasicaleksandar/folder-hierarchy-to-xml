using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_hierarchy_to_XML
{
    class ClassFile
    {
        public ClassFile(string name, long size, DateTime creationTime, DateTime lastAccessTime, DateTime lastModifiedTime)
        {
            this.name = name;
            this.size = size;
            this.creationTime = creationTime;
            this.lastAccessTime = lastAccessTime;
            this.lastModifiedTime = lastModifiedTime;
        }
        public string FileDetails()
        {
            return "File name : " + this.Name + Environment.NewLine + "File size : " + this.Size + " bytes" + Environment.NewLine + "Creation time : " + this.CreationTime + Environment.NewLine +
                "Last access time : " + this.LastAccessTime + Environment.NewLine + "Last modified time : " + this.LastModifiedTime;
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
        private DateTime creationTime;
        public DateTime CreationTime
        {
            get { return creationTime; }
            set { creationTime = value; }
        }
        private DateTime lastAccessTime;
        public DateTime LastAccessTime
        {
            get { return lastAccessTime; }
            set { lastAccessTime = value; }
        }
        private DateTime lastModifiedTime;
        public DateTime LastModifiedTime
        {
            get { return lastModifiedTime; }
            set { lastModifiedTime = value; }
        }
    }
}
