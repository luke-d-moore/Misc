namespace DrawShapes.Shape
{
    public class Square : Shape
    {
        public Square(int x, int y, int size) : base(x, y, size, size, string.Empty)
        {

        }

        public override string Name => nameof(Square);

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) size={Width}");
        }

        protected override bool Validate()
        {
            ValidateLocation();
            ValidateSize();
            return true;
        }
    }
}
