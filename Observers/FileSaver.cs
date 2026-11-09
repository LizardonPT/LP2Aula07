using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {
        private readonly string filePath;

        public FileSaver(string filePath)
        {
            this.filePath = filePath;
        }

        public void Update(AbstractStringSubject sub)
        {
            string info = sub.Item;
            File.AppendAllText(filePath, info + "\n");
        }
    }
}