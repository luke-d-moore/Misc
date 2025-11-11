namespace DrawShapes.Shape
{
    public class TextBox : Shape
    {
        public TextBox(int x, int y, int width, int height, string text) : base(x, y, width, height, text)
        {

        }

        public override string Name => nameof(TextBox);

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) width={Width} height={Height} Text=\"{Text}\"");
        }

        protected override bool Validate()
        {
            ValidateLocation();
            ValidateDimensions();
            ValidateText();
            return true;
        }
    }
}
