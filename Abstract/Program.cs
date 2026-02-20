namespace Abstract
{
    internal class Program
    {
        static void Main()
        {
            Shape cubeObj = new Cube();
            cubeObj.Picture();
            cubeObj.Modelling();

            Shape sphereobj = new Sphere();
            sphereobj.Picture();
        }
    }
    abstract class Shape()
    {
        internal abstract void Picture(); // abstract members cannot be private
        internal abstract void Modelling();
    } // Also they cannot have body "{}" on their own

    class Cube : Shape //inherited from Base class Shape
    {
        internal override void Picture()
        { Console.WriteLine("Cube: This \"Picture\" is inherited from the base abstract class \"Shape\""); }
        sealed internal override void Modelling()
        // Sealed: further calls from new derived methods are blocked
        {
            Console.WriteLine("      \"Modelling\" is sealed and so only iteration within the whole code");
            Console.WriteLine("       Sealed modifier prevents any further overriding on this method\n");
        }
    }

    class Sphere : Cube //inherited from Derived class Cube
    {
        internal override void Picture()
        { Console.WriteLine("Sphere: This \"Picture\" is inherited from the derived class \"Cube\""); }
    }
}
// internal override void Modelling() { }// Cannot be overridden, because "Modelling" in Cube is sealed