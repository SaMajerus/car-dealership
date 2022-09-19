using System; 

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public int Customizable { get; set; }
    public int OffRoadAbility { get; set; }

    // public string MakeModel
    //   {
    //   get
    //   {
    //     return "That's a big secret. You'll have to visit Lonny's to find out about our special deals!";
    //   }
    //   set
    //   {
    //     _makeModel = value;
    //   }
    // }

    
    public Car(string makeModel, int price, int miles, int customizable, int offRoadAbility)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Customizable = customizable;
      OffRoadAbility = offRoadAbility;
    }
    
    // public void SetPrice(int newPrice)
    // {
    //   Price = newPrice;
    // }

    public int LowerPrice()
    {
      double newPrice = Price * 0.2;
      int percentOff = (int)newPrice; 
      Price = Price - percentOff;
      return Price;
      // int newPrice = Price * 20 / 100;
      // Price = Price - newPrice;
      // return Price;
    }

    public string SuccessInDakarRally()
    {
      if (Customizable + OffRoadAbility < 5 )
      {
        return "This car will do bad at the Dakar Rally";
      }
      else if (Customizable + OffRoadAbility > 5 && Customizable + OffRoadAbility < 12)
      {
        return "This car will do ok at the Dakar Rally";
      }
      else
      {
        return "This car will do great at the Rally!";
      }
    }

    public string ResaleValue(){
      if(Price < 500){
        Price = Price -100; 
        return "The resale price of this vehicle is:  $" + Price;
      } else if ((Price >= 500) && (Price < 1000)){
        Price = Price - 200; 
        return "The resale price of this vehicle is:  $" + Price;
      } else {
        Price = Price - 500; 
        return "The resale price of this vehicle is:  $" + Price;
      }
    }
    
    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    public bool WorthBuying(int MaxPrice)
    {
      return (Price <= MaxPrice);
    }
  }
}