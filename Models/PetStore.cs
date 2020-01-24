using System.Collections.Generic;

namespace classes.Models
{
  class PetStore
  {
    public List<Cat> Cats { get; private set; } //NOTE = new List<Cat>();

    public void AddInventory(List<Cat> cats)
    {
      //NOTE this is a way to add cats to the inventory
      Cats.AddRange(cats);
    }

    //NOTE if your class has a dictionary or something to be instantiated you can either do it up top or down in the constructor
    public void AddInventory(Cat[] cats)
    {
      Cats.AddRange(cats);
    }



    public PetStore()
    {
      //NOTE this needs to be called or you will throw an error
      Cats = new List<Cat>();
    }
  }
}