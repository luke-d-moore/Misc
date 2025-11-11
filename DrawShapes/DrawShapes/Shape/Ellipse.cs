namespace DrawShapes.Shape
{
    public class Ellipse : Shape
    {
        public Ellipse(int x, int y, int diameterH, int diameterV) : base(x, y, diameterH, diameterV, string.Empty)
        {

        }
        public override string Name => nameof(Ellipse);


        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) diameterH = {Width} diameterV = {Height}");
        }

        protected override bool Validate()
        {
            ValidateLocation();
            ValidateDimensions();
            return true;
        }
    }
}
