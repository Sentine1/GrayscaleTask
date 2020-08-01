namespace Recognizer
{
	public static class GrayscaleTask
	{
        /* 
		 * Переведите изображение в серую гамму.
		 * 
		 * original[x, y] - массив пикселей с координатами x, y. 
		 * Каждый канал R,G,B лежит в диапазоне от 0 до 255.
		 * 
		 * Получившийся массив должен иметь те же размеры, 
		 * grayscale[x, y] - яркость пикселя (x,y) в диапазоне от 0.0 до 1.0
		 *
		 * Используйте формулу:
		 * Яркость = (0.299*R + 0.587*G + 0.114*B) / 255
		 * 
		 * http://ru.wikipedia.org/wiki/Оттенки_серого
		 * Почему формула именно такая — читайте в википедии 
		 */

        public static double[,] ToGrayscale(Pixel[,] original)
        {
            int x = original.GetLength(0), y = original.GetLength(1);
            var exitArray = new double[original.GetLength(0), original.GetLength(1)];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    exitArray[i, j] = BrightnessScale(original[i, j]);

            return exitArray;
        }

        static double BrightnessScale(Pixel original)
        {
            return ((original.R * 0.299) + (original.G * 0.587) + (original.B * 0.114)) / 255;
        }
    }
}