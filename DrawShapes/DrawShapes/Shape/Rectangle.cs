namespace DrawShapes.Shape
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height, string.Empty)
        {

        }

        public override string Name => nameof(Rectangle);

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) width={Width} height={Height}");
        }

        protected override bool Validate()
        {
            ValidateLocation();
            ValidateDimensions();
            return true;
        }
    }
}
