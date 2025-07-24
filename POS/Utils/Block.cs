using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POS.Utils
{
    public class Block
    {
        public int Index { get; set; }
        public DateTime Timestamp { get; set; }
        public string Data { get; set; }
        public string PreviousHash { get; set; }
        public string Hash { get; set; }

        public Block(int index, DateTime timestamp, string data, string previousHash)
        {
            Index = index;
            Timestamp = timestamp;
            Data = data;
            PreviousHash = previousHash;
            Hash = CalculateHash();
        }

        public string CalculateHash()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string rawData = Index + Timestamp.ToString() + Data + PreviousHash;
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                string utfString = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                byte[] data = FromHex(utfString);
                string s = Encoding.ASCII.GetString(data);
                return Encoding.ASCII.GetString(data);
            }
        }

        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }
    }
}
