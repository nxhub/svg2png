# svg2png
一个 .NET 工具，提供批量将 SVG 转换为 PNG。  
[![svg2png](https://buildstats.info/nxhub/svg2png)](https://www.nuget.org/packages/svg2png/)

## 安装
```
> dotnet tool install -g svg2png
```

## 查看帮助
```
> svg2png -h
Usage: svg2png [options]

Options:
  -s|--svg-dir <SVG_DIR>  SVG 图片目录
  -p|--png-dir <PNG_DIR>  PNG 图片目录
  -e|--enlarge <ENLARGE>  放大倍数
  -?|-h|--help            Show help information
```

## 举例
```
> svg2png -s E:\svg -p E:\png -e 3
```

## 彩蛋
docs 目录中有一份精美的插图，来自 .NET 官网(dot.net)。
