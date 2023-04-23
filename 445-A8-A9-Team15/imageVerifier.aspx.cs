using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _445_A8_A9_Team15
{
    public partial class imageVerifier : System.Web.UI.Page
    {
        public string CaptchaStr;
        protected void Page_Load(object sender, EventArgs e)
        {
            string randomString = GenerateRandomString(6);
            CaptchaStr = randomString;

            Session["CaptchaImageText"] = randomString;

            GenerateCaptchaImage(randomString);
        }

        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void GenerateCaptchaImage(string randomString)
        {
            Random random = new Random();
            // bitmap image with white background
            Bitmap bitmap = new Bitmap(150, 50);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            // Create a font and brush for drawing the text
            Font font = new Font("Arial", 20, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);

            // Create a path for the text and draw it with distortion
            GraphicsPath path = new GraphicsPath();
            path.AddString(randomString, font.FontFamily, (int)font.Style, font.Size, new Point(0, 0), StringFormat.GenericDefault);
            Matrix matrix = new Matrix();
            matrix.Rotate(15);
            path.Transform(matrix);
            graphics.DrawPath(new Pen(Color.Black), path);

            // Add some random noise to the image
            for (int i = 0; i < 1000; i++)
            {
                int x = random.Next(bitmap.Width);
                int y = random.Next(bitmap.Height);
                bitmap.SetPixel(x, y, Color.FromArgb(random.Next(180, 256), random.Next(180, 256), random.Next(190, 256)));
            }

            // Output the image to the response stream
            Response.ContentType = "image/png";
            bitmap.Save(Response.OutputStream, ImageFormat.Png);

            // Clean up resources
            graphics.Dispose();
            bitmap.Dispose();
        }
    }
}