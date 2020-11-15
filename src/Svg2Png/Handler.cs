using Svg;
using System;
using System.Drawing;
using System.IO;

namespace Svg2Png
{
    internal class Handler
    {
        public IOptions Options { get; init; }

        public void Handle()
        {
            string[] files = Directory.GetFiles(
                Options.SvgDir, "*.svg", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                string relativePath = file
                    .Replace(Options.SvgDir, "")
                    .Trim('\\');

                string fullPath = Path.Combine(Options.PngDir, relativePath);

                fullPath = Path.ChangeExtension(fullPath, ".png");

                string directory = Path.GetDirectoryName(fullPath);

                try
                {
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    Image image = Convet(file);

                    image.Save(fullPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error: {ex.Message}({file}).");
                }
            }
        }

        private Image Convet(string svgPath)
        {
            SvgDocument svg = SvgDocument.Open(svgPath);

            float width = svg.ViewBox.Width;

            float height = svg.ViewBox.Height;

            if (Options.Enlarge > 0)
            {
                width *= Options.Enlarge;

                height *= Options.Enlarge;
            }

            int widthValue = (int)width;

            int heightValue = (int)height;

            Bitmap image = widthValue > 0 && heightValue > 0
                ? svg.Draw((int)width, (int)height)
                : svg.Draw();

            return image;
        }
    }
}
