using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileEncryptionModel.Model
{
    public interface IEncryptor
    {
        public byte[] Key { get; set; }
        public string SourceFilePath { get; set; }
        public string DestinationFilePath { get; set; }

        Task<bool> EncryptAsync();
        bool Encrypt();
    }
}
