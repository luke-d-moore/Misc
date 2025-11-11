namespace DrawShapes.Interfaces
{
    public interface IShape : IDraw
    {
        public string Name { get; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
    }
}
