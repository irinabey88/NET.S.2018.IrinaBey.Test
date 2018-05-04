using System;
using Task2.Solution.Interface;

namespace Task2.Solution.Entity.Base
{
    public abstract class CustomFileGenerator : IFileGenerator
    {
        public string WorkingDirectory;

        public string FileExtension;

        protected CustomFileGenerator(string directory, string fileExtension)
        {
            if (string.IsNullOrWhiteSpace(directory))
            {
                throw new ArgumentNullException(nameof(directory));
            }

            if (string.IsNullOrWhiteSpace(fileExtension))
            {
                throw new ArgumentNullException(nameof(fileExtension));
            }

            this.WorkingDirectory = directory;
            this.FileExtension = fileExtension;
        }

        protected abstract void WriteBytesToFile(string fileName, byte[] content);

        protected abstract byte[] GenerateFileContent(int contentLength);

        public virtual void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }
    }
}