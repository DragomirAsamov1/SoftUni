using System;

namespace P02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {
            GraphicEditor editor = new GraphicEditor();
            IShape shape = new Square();
            editor.DrawShape(shape);
        }
    }
}
