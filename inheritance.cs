
using System;

namespace inheritance

{
    class Painting
    {
        public string paintingUserName = "Toyin's artistry";


    public void welcomegreetings()
    {
        Console.WriteLine("Welcome to our world of artistry");
    }
  }

  class PaintingDetails: Painting
  {
      public string PaintingName = "Smoke Artistry";
       public string PaintingArtist = "Dan Leons";
       public string PaintingMedium = "Sketches";
       public string PaintingYear = "1988";
  }
   
   class Program
   {
       static void Main(string[] args)
       {
           PaintingDetails newPaintingDetails = new PaintingDetails();
           newPaintingDetails.welcomegreetings();
           Console.WriteLine (newPaintingDetails.PaintingName + " " + "is a member of" +" "+ newPaintingDetails.paintingUserName);
           Console.WriteLine (newPaintingDetails.PaintingArtist + " " +"is a member of" + " "+ newPaintingDetails.paintingUserName);
           Console.WriteLine (newPaintingDetails.PaintingMedium + " "+ "is a member of" +" "+ newPaintingDetails.paintingUserName);
           Console.WriteLine (newPaintingDetails.PaintingYear + " " +"is a member of" +" " + newPaintingDetails.paintingUserName);

       }
   }


}
