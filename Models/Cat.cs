namespace classes.Models

{
  class Cat

  {
    private string _name;

    //NOTE public name can access the private string of name
    //NOTE value is what is passed

    // public string Name { get { return _name; } set {value = value.ToLower(); _name = value; } }


    //NOTE 9/10 times we will use the props
    //NOTE public anyone can retrieve the name, but private will not allow you to change it without some sort of function or method
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public string FullName
    {
      get
      {
        return FirstName + " " + LastName;
      }
    }

    //NOTE fields do not have a getter setter, properties have a getter and setter, and we control how the data is controlled or used
    //NOTE doesnt matter where the constructor goes, either top or bottom

    //NOTE only way to change it is building a method inside of it
    public int Lives { get; private set; } = 9; //NOTE can also set a default value up here 


    //NOTE private needs to have the underscore
    private int _lives;

    private bool Happy { get; set; }

    public int Pets { get; set; }
    private int Tolerance { get; set; }

    //NOTE METHODS: if you want to make it pettable outside of the class, make it private
    //NOTE void means nothing, indicates that this method doesnt return anything. You cannot return anything
    public string Pet()
    {
      Pets++;
      if (Happy)
      {
        return "meow";
      }
      //NOTE closest you are going to get returning two different types
      return "Hiss";
    }

    //NOTE reset the amount / another medthod
    public void Catnip()
    {
      Pets = 0;
    }


    //NOTE Feed Method / Method overloading
    public void Feed()
    {
      Happy = true;
      System.Console.WriteLine("mmmmmmmmm");
    }

    //NOTE method loading, is writing the same method, if you give it different arguments you can run it again and it will treat it as another method

    public void Feed(string food)
    {
      if (food == "catfood")
      {
        System.Console.WriteLine("mmmmmmmmm");
        return;
      }
      System.Console.WriteLine("BARF");
    }

    //NOTE method overloading needs to have the same name, return type, but different parameters



    //NOTE if the method is public and the method name is the same of the class it is your constructor
    //NOTE ctor is the hotkey for the constructor
    //NOTE will be within the class / never has a return type. The return type is the object itself
    //NOTE always public and the method name is the same as the class
    //NOTE default is parameter-less constructor
    //NOTE everything in C-Sharp you have to declare
    //NOTE you have to determine what is the tyoe and the parameter name you give it.
    public Cat(string firstName, string lastName, int tolerance)
    {
      FirstName = firstName;
      LastName = lastName;
      Tolerance = tolerance;
      // Lives = 9;
      Happy = false;
    }

    //NOTE overloading a constructor
    //NOTE as long as its the same return type it is ok to use.
    public Cat(string FullName, int tolerance)
    {
      string[] names = FullName.Split(' ');
      FirstName = names[0];
      Tolerance = tolerance;
      LastName = "";
      if (names.Length > 1)
      {
        LastName = names[1];
      }
    }
  }
  //NOTE take a look at the code from Mark that gives the passing parameters of the different way to method overload 
  //NOTE with FPV
}