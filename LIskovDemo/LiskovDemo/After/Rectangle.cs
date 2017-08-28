namespace LiskovDemo.After
{
    public class Rectangle : IShape
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int Area()
        {
            return Height * Width;
        }
    }
}
