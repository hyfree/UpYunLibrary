using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpYunLibrary
{
    //目录条目类
    public class FolderItem
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        public string Filename { get; set; }
        /// <summary>
        /// 文件为 file，文件夹为 folder
        /// </summary>
        public string Filetype { get;set;}
        /// <summary>
        /// 文件大小
        /// </summary>
        public int Size { get; set; }
        public int Number { get; set; }
        public FolderItem(string filename, string filetype, int size, int number)
        {
            this.Filename = filename;
            this.Filetype = filetype;
            this.Size = size;
            this.Number = number;
        }
    }
}
