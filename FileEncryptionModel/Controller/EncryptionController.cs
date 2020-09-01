using System;
using System.Text;
using FileEncryptionModel.Model;

namespace FileEncryptionModel.Controller
{
    public class EncryptionController
    {
        public IEncryptor Encryptor { get; private set; } = new XorEncryptor();

        #region Properties

        public string SourcePath
        {
            get => Encryptor.SourceFilePath;
            set
            {
                if (Encryptor != null)
                {
                    Encryptor.SourceFilePath = value;
                }
            }
        }

        public string DestinationPath
        {
            get => Encryptor.DestinationFilePath;
            set
            {
                if (Encryptor != null)
                {
                    Encryptor.DestinationFilePath = value;
                }
            }
        }

        public string Key
        {
            set
            {
                byte[] keyBytes = Encoding.ASCII.GetBytes(value);
                Encryptor.Key = keyBytes;
            }
        }

        #endregion

        public bool Encrypt()
        {
            return Encryptor.Encrypt();
        }

        public bool EncryptAsync()
        {
            return Encryptor.EncryptAsync().Result;
        }
    }
}
