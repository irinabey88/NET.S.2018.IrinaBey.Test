using System;
using System.IO;
using Task2.Solution.Entity.Base;

namespace Task2.Solution.Entity
{
    public class RandomBytesFileGenerator : CustomFileGenerator
    {
        public RandomBytesFileGenerator(string directory, string fileExtension) : base(directory, fileExtension)
        {
        }

        protected override void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}