
made a new class per shape, Square, Rectangle, Circle, Ellipse and TextBox
made an interface for a shape with location details, dimensions, name
made a draw interface
shape interface implements draw because I want to draw the shape
make a shape base class which implements the shape interface 
shape base class also has validate methods for validating the shape
make the original shapes inherit from the shape base class
in the base class make the draw method abstract so I have to override it in each derived class
implement the draw methods on each of the classes 
run it to test that the output is correct at this early stage, it's correct
Make the unit test project 
make a test class for each of the shapes Square, Rectangle, Circle, Ellipse and TextBox
in each one test a valid set of arguments for the constructor as per the main method
and test a set of invalid arguments which do not meet the criteria here, these apply to all shapes
1) X Coordinate must be greater than 0
2) Y Coordinate must be greater than 0
3) Size must be greater than 0
4) Width must be greater than 0
5) Height must be greater than 0
Applies only to TextBox 
6) Text must not be null
in each of the constructors call the validate methods that apply to that shape and then if all return true then carry on constructing the object
build each of the validate methods using TDD
write the tests, I know I want the exceptions to be thrown in each of the cases mentioned above
write the validate methods to make each test pass, until all test cases pass for each shape constructor
