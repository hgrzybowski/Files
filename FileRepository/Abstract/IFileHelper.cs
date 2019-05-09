namespace FileRepository.Abstract
{
    public interface IFileHelper
    {
        void Delete(string path);

        void Move(string resourcePath, string destinationPath);

        void AppendTextToFile(string path, string message);

        void Create(string path);

    }
}
