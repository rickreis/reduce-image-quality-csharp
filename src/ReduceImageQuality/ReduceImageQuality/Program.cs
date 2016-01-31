using System;

namespace ReduceImageQuality.POC
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathBase = AppDomain.CurrentDomain.BaseDirectory;

            var fileName = String.Concat(pathBase, @"App_Data\vs-life-runs-on-code.jpg");

            var pathSource = String.Concat(pathBase, @"App_Data\vs-life-runs-on-code-reduce.jpg");

            var reduceImage = new ReduceImage();

            reduceImage.Reduce(fileName, pathSource, quality: 75);

            Console.WriteLine("Verifique o arquivo: {0}\r\n", pathSource);
        }
    }
}
