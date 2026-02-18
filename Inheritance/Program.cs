namespace Inheritance
{
    internal class Shape // base class
    {
        static void Main()
        {
            Shape newShape = new Shape();// First "Shape" in the line are Base classes / (variable type)
            Shape circle = new Circle(); // classes after new are called Derived classes /(object type)
            Shape cube = new Cube();

            newShape.Picture();
            circle.Picture();
            cube.Picture();
        }
        internal virtual void Picture() //Base method -> transformed into virtual-type and hence overridable
        { Console.WriteLine("Base method    (newShape)"); }
    }
    class Circle : Shape // derived class
    {
        internal override void Picture() // Derived method <- overridden
        { Console.WriteLine("derived method (circle)   <- overridden"); }
    }
    class Cube : Shape // derived class
    {
        internal new void Picture() // Derived method <- Not overridden (also intentionally avoiding using new)
        { Console.WriteLine("Won't print. Not overridden"); }
    }
}