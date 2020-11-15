namespace Svg2Png
{
    internal interface IOptions
    {
        public string SvgDir { get; set; }

        public string PngDir { get; set; }

        public int Enlarge { get; set; }
    }
}
