namespace LiskovDemo.Before
{
    public class Square : Rectangle
    {
        private int _width;

        public override int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _height = value;
            }
        }

        private int _height;

        public override int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }

    }
}
