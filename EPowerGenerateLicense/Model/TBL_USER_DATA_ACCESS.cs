using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPowerGenerateLicense.Class;


namespace EPowerGenerateLicense.Model
{
    public class TBL_USER_DATA_ACCESS : IDisposable
    {
        private LicenseDataContext _context;
        void IDisposable.Dispose()
        {

        }
        public IQueryable<TBL_USER> ShowUserByID(int USER_ID)
        {
            _context = new LicenseDataContext();
            var result = from u in _context.TBL_USERs where u.USER_ID == USER_ID select u;
            return result;
        }
        public void SaveUser(TBL_USER user)
        {
            using (_context = new LicenseDataContext())
            {
                _context.TBL_USERs.InsertOnSubmit(user);
                _context.SubmitChanges();
            }
        }
        public IQueryable<TBL_USER> CheckUniqueUsername(string user)
        {
            _context = new LicenseDataContext();
            var result = from u in _context.TBL_USERs where u.USERNAME == user select u;
            return result;
        }
        public IQueryable<CLASS_TBL_USER> ShowUserAllIncludeInActive()
        {
            _context = new LicenseDataContext();
            var result = from u in _context.TBL_USERs
                         select new CLASS_TBL_USER
                             {
                                 USER_ID = u.USER_ID,
                                 USERNAME = u.USERNAME,
                                 PASSWORD = u.PASSWORD,
                                 IS_ACTIVE = u.IS_ACTIVE
                             };
            return result;
        }
        public IQueryable<TBL_USER> ShowUserActive()
        {
            _context = new LicenseDataContext();
            var result = from u in _context.TBL_USERs where u.IS_ACTIVE == true select u;
            return result;
        }
        
        private string password;
        public bool Authentication(string user, string pwd)
        {
            bool flag = false;
            password = Encrypt(pwd, true);
            
            _context = new LicenseDataContext();
            var result = from u in _context.TBL_USERs where u.USERNAME == user && u.PASSWORD == password select u;
            if (result.Count() >= 1)
            {
                flag = true;
            }
            else
            {
                flag = false;
              
            }
            return flag;
        }
        public string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            // Get the key from config file
            string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));
            //System.Windows.Forms.MessageBox.Show(key);
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //Release the resources and flush data.
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //Set the secret key for the tripleDes algorithm
            tdes.Key = keyArray;
            //Mode of operation. there are other four modes (ECB..)
            tdes.Mode = CipherMode.ECB;
            //Padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //Transform the specified region of bytes array to resultArray
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public string Decrypt(string cipherString, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            //Get your key from config file to open the lock!
            string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}
