using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DAL.Utils;
using System.IO;
using ZXing;
using ZXing.QrCode;
using System.Drawing;
using System.Drawing.Imaging;

namespace DAL.Utils
{
    public class clsFunction
    {
        public static DateTime GetDate()
        {
            var dateTime = DateTime.UtcNow;
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone); // convert from utc to local
            return localTime; //DateTime.Now;
        }

        public static string DecryptText(string input)
        {
            var key = KEY.KEY_STRING;

            //var encryptedString = EncryptString(key, "test");
            //var decryptedString = DecryptString(key, encryptedString);


            string result = DecryptString(key, input);

            return result;
        }

        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        public static System.IFormatProvider formatThai = new System.Globalization.CultureInfo("th-TH");
        public static string setFormatDate(DateTime? Date)
        {
            string strDate = string.Empty;
            if (Date.HasValue)
            {
                strDate = Date.Value.ToString("dd/MM/yyyy");
            }

            return strDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="runningid"></param>
        /// <param name="catecode"></param>
        /// <param name="flag">"P": Product,"SE":SellsItem,"U":User</param>
        /// <returns></returns>
        public static string GenFormatCode(int runningid, string catecode, string flag)
        {
            string sFormat = string.Empty;
            //System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("th-TH");

            DateTime date = DateTime.UtcNow;
            var d = date.Day;
            var m = date.Month;
            var y = date.Year;

            switch (flag)
            {
                case "P": //product
                    sFormat = string.Format("{0}{1}{2}{3:D5}", catecode, d, m, runningid);
                    break;
                case "SE": //sell item
                    sFormat = string.Format("{0}{1}{2}{3:D5}", "SE", d, m, runningid);
                    break;
                case "U": //user
                    sFormat = string.Format("{0}{1}{2}{3:D5}", "", d, m, runningid);
                    break;
            }
            return sFormat;
        }
        public static string setFormatDateWithTime(DateTime? Date, bool IsThai)
        {
            string strDate = string.Empty;
            if (Date.HasValue)
            {
                if (IsThai)
                    strDate = Date.Value.ToString("dd/MM/yyyy HH:mm:ss", formatThai);
                else
                {
                    strDate = Date.Value.ToString("dd/MM/yyyy HH:mm:ss");

                }
            }

            return strDate;
        }

        public static bool GenBarcode(string filename)
        {
            bool isSuccess = false;
            try
            {
                string barcodePth = System.IO.Directory.GetCurrentDirectory();
                barcodePth = string.Format("{0}/{1}", barcodePth, "Barcode");
                MakePath(barcodePth);

                QrCodeEncodingOptions options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 160,
                    Height = 100,
                };


                var qr = new ZXing.BarcodeWriter();
                qr.Options = options;
                qr.Format = ZXing.BarcodeFormat.CODE_128;
                var result = new Bitmap(qr.Write(filename.Trim()));

                string savefile = string.Format("{0}/{1}.jpg", barcodePth, filename);
                result.Save(savefile);
               
               


                ////string path = "D:/Workspace/DotNet/Inventory/POS/POS_API/POSAPI/Barcode/test.jpg";
                //string savefile = string.Format("{0}/{1}.jpg", barcodePth, filename);
                //qr.SaveImageFile(savefile);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }
        public static void MakePath(string path)
        {
            try
            {
                string sDirPath;

                sDirPath = path;
                DirectoryInfo di = new DirectoryInfo(sDirPath);

                if (di.Exists == false)
                {
                    di.Create();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
