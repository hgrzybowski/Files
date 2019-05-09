
using FileRepository.Abstract;
using System.IO;

namespace FileRepository.Helpers
{
    public class FileHelper : IFileHelper
    {
        public void AppendTextToFile(string path, string message)
        {
            if (File.Exists(path))
            {
                File.AppendAllText(path, message);
               
            }
        }

        public void Create(string path)
        {
            if(!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
        }

        public void Delete(string path)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void Move(string sourcePath, string destinationPath)
        {
            if (File.Exists(sourcePath))
            {
                File.Move(sourcePath, destinationPath);
            }
        }
    }
}