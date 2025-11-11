namespace DrawShapes.Shape
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int size) : base(x, y, size, size, string.Empty)
        {

        }
        public override string Name => nameof(Circle);

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
