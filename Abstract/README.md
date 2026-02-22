Inheritance

    ○ Fields and methods can inherited from one class to another
      [Derived : Base]
        ○ Base (parent class) = Can be inherited
        ○ Derived (child class) = Inherits the Base
    ○ Inheritance makes code reusable, which is the whole point
      of object oriented programming
        ○ Classes can also be sealed to prevent further 
          inheritance of the class
            □ Can be used on classes as it is
            □ On methods and properties, they have to be combined
              with "override"
                □ internal sealed override void Method()
    
Polymorphism [Inheritance modifiers]

    ○ Occurs when classes are related to each other through 
      inheritance 
    ○ Inherited methods allow us to perform single action in 
      multiple ways:
        ○ virtual = Makes method in base class overridable
            □ By default methods are non-virtual and hence cannot
              be overridden
            □ Used to transform base method into overridable
              virtual-type          
        ○ override = Replaces base implementation
            □ Only used for overriding base class's method, 
              property or indexer (virtual or abstract)
            □ Runtime polymorphism: Method called on object, 
              program then checks object type: class used 
              after "new" to determine the most derived class, 
              where the method is supposed to be called from
                □ Inherited method must be equally named for 
                  override to work
                □ most derived: The class called after 
                  "new" -> Base obj = new Derived(); 
                    ® Base = variable type
                    ® Derived = object type
Shadowing

    ○ At constructor "new" was operator. Here it's used as "hiding
      modifier" for shadowing
    ○ When base method and derived method share the same name and
      the "new" modifier is used on derived method, both of these
      methods are treated as individual methods regardless of the
      same name
        ○ Main usage is to indicate to compiler that hiding was
        intentional. Nothing more. Just IDE level documentation.

Explanation:

        ○ Base method "Picture" has been transformed into
          virtual-type and so, can now be overridden.
        ○ From derived classes "Circle": method "Picture":
          circle is only separated text from mine to be printed,
          because it's overridden. That’s why cube will print same
          text as in base method  

        ○ Runtime polymorphism: Method "Picture" called on object
          "circle", program then checks object type: class used
          after "new" to determine the most derived class "Circle"
          where the method "Picture" is supposed to be called from
            □ Shape circle = new Circle();
            □ circle.Picture()adas

We are shadowing Picture residing in Cube by adding new hiding
  modifier in front of the method. This way compiler understands
  that it is separated method from inherited ones and this hiding
  was intentional. It really doesn't have other functions in this
  case.