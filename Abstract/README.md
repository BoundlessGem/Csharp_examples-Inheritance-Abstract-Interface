Abstract

  ○ Abstract Classes 
    ○ cannot be instantiated, static, nor sealed, because it's fundamentally made to be overridden.
    ○ Abstract classes exist because abstract methods has to be within abstract classes
      □ Can contain both abstract and non-abstract methods, but neither classes nor methods 
        can be instantiated directly with (new) operator within in the abstract class
    ○ All abstract classes are made to be inherited. If derived class doesn't implement all
      of the abstract methods in the base class, then it also must be declared as abstract class
    ○ Default access modifier is "internal" and other members within are following normal rules
    
  ○ Abstract method
    ○ Abstract base method cannot have body "{}" on their own: internal abstract void Method();
      □ Cannot be made private or static, because they must be inherited (doesn't have code otherwise)
    ○ derived methods must inherit and override the base method in order to provide method a
      body "{}": internal override void Method() {body};
    
Sealed [Prevents further overriding] [enables devirtualization] ???

  ○ class 
    □ Can seal entire classes to prevent any further inheritance from  that class
  ○ method
    □ When used on method sealed modifier must be used together with override modifier to
      prevent method from being overridden
