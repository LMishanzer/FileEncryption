using System;
using System.IO;
using System.Threading.Tasks;

namespace FileEncryptionModel.Model
{
    public class XorEncryptor : IEncryptor
    {
        public byte[] Key { get; set; }
        public string SourceFilePath { get; set; }
        public string DestinationFilePath { get; set; }

        public async Task<bool> EncryptAsync()
        {
            return await Task.Run(Encrypt);
        }

        public bool Encrypt()
        {
            if (!File.Exists(SourceFilePath))
            {
                return false;
            }

            using (var sourceFileStream = File.OpenRead(SourceFilePath))
            {
                using (var destinationFileStream = File.Create(DestinationFilePath))
                {
                    var buffer = new byte[Key.Length];

                    while (sourceFileStream.Read(buffer, 0, buffer.Length) > 0)
                    {
                        for (int i = 0; i < Key.Length; i++)
                        {
                            buffer[i] = (byte)(buffer[i] ^ Key[i]);
                        }

                        destinationFileStream.Write(buffer, 0, buffer.Length);
                    }

                    return true;
                }
            }
        }
    }
}
