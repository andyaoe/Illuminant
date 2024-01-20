using Emgu.CV.Structure;
using Emgu.CV;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Image<Gray, Byte> img1 = new Image<Gray, Byte>("gray.png");
Console.Write("Width={0} Height={1}", img1.Size.Width, img1.Size.Height);

