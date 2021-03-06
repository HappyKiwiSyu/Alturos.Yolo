﻿using Alturos.Yolo.LearningImage.Model;
using System.Drawing;

namespace Alturos.Yolo.LearningImage.Helper
{
    public static class DrawHelper
    {
        public static readonly Size ImageSize = new Size(1024, 576);

        private static readonly string[] Colors = new string[] { "#E3330E", "#48E10F", "#D40FE1", "#24ECE3", "#EC2470" };

        public static Image DrawBoxes(AnnotationImage image)
        {
            var originalBitmap = new Bitmap(image.FilePath);
            var bitmap = new Bitmap(originalBitmap, ImageSize);
            originalBitmap.Dispose();

            return bitmap;
        }

        public static Color GetColorCode(int index)
        {
            return ColorTranslator.FromHtml(Colors[index]);
        }
    }
}
