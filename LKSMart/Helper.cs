using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LKSMart
{
    internal class Helper
    {
        public static string profilePictureDirectory = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", string.Empty).Replace(@"\bin\Release", string.Empty) + @"\images\profile_pictures\";
        public static string productPictureDirectory = Directory.GetCurrentDirectory().Replace(@"\bin\Debug", string.Empty).Replace(@"\bin\Release", string.Empty) + @"\images\products\";

        public static string GetProfilePicture(string filename)
        {
            Console.WriteLine(profilePictureDirectory);
            try
            {
                FileInfo[] file = new DirectoryInfo(profilePictureDirectory).GetFiles(filename + ".*");
                if (file.Length > 0)
                    return file[0].FullName;
                throw new FileNotFoundException();
            }
            catch
            {
                return null;
            }
        }

        public static string GetProductPicture(string filename)
        {
            try
            {
                FileInfo[] file = new DirectoryInfo(productPictureDirectory).GetFiles(filename);
                if (file.Length > 0)
                    return file[0].FullName;
                throw new FileNotFoundException();
            }
            catch
            {
                return null;
            }
        }

        public static string GetPaymentCode()
        {
            string result = string.Empty, seed = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                result += $"{seed[random.Next(0, seed.Length)]}";
            }
            return result;
        }
        public static Dictionary<int, string> productInCart = new Dictionary<int, string>();
    }
}
