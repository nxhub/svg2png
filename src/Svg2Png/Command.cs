using Svg2Png;
using McMaster.Extensions.CommandLineUtils;

internal class Command : IOptions
{
    [Option(Description = "SVG 图片目录")]
    public string SvgDir { get; set; }
    [Option(Description = "PNG 图片目录")]
    public string PngDir { get; set; }
    [Option(Description = "放大倍数")]
    public int Enlarge { get; set; }

    public void OnExecute()
    {
        Handler handler = new()
        {
            Options = this,
        };

        handler.Handle();
    }
}
