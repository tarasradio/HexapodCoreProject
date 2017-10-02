using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrundGeneratorProject.Core
{
    /// <summary>
    /// Здесь хранятся загруженные файлы с движениями
    /// </summary>
    public class FileStorage
    {
        uint newID;
        public Dictionary<uint, FrundMoveFile> fileList;

        public FileStorage()
        {
            fileList = new Dictionary<uint, FrundMoveFile>();
            newID = 0;
        }

        public bool addFile(string path)
        {
            if (!System.IO.File.Exists(path)) return false;
            FrundMoveFile file = new FrundMoveFile(path);
            fileList.Add(newID++, file);
            return true;
        }

        public void deleteFile(uint id)
        {
            fileList.Remove(id); ;
        }
    }
}
