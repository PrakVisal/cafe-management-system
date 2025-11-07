using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project.Business_Layer
{
    public class ImageConverter
    {
        public static byte[] ConvertImageToBytes(Guna2PictureBox img)
        {
            if (img == null || img.Image == null)
            {
                throw new ArgumentException("Invalid image parameter");
            }

            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    img.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    // Handle any specific exceptions or log the error as needed
                    //MessageBox.Show("Error converting image to byte array: " + ex.Message);
                    throw new Exception("Error converting image to byte array", ex);
                }
            }
        }

        public static Image ConvertByteArrayToImage(byte[] data)
        {
            if (data == null || data.Length == 0)
            {
                // Return null so callers can decide how to handle missing images
                return null;
            }

            using (MemoryStream ms = new MemoryStream(data))
            {
                try
                {
                    return Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"ConvertByteArrayToImage error: {ex.Message}");
                    return null;
                }
            }
        }
    }
}