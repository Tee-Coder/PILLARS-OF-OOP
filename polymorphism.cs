
using System;
namespace polymorphism
{
    class Program
    {
        class Painting
        {
            public virtual void paintingDetails()
            {
                Console.WriteLine("[This are all the details of our painting]");
            }
        }
        class PaintingName : Painting
        {
            public override void paintingDetails()
            {
                Console.WriteLine("Name is atmosphere");
            }
        }
        class PaintingArtist : Painting
        {
            public override void paintingDetails()
            {
                Console.WriteLine("Artist is Taiwo-Toyin");
            }
        }
        class PaintingMedium : Painting
        {
            public override void paintingDetails()
            {
                Console.WriteLine("Medium used in archieving painting is pencil sketch");
            }
        }
        class PaintingYear : Painting
        {
            public override void paintingDetails()
            {
                Console.WriteLine("Year is 1766");
            }
        }
        static void Main(string[] args)
        {
            Painting myPainting = new Painting();
            Painting myPaintingName = new PaintingName();
            Painting myPaintingArtist = new PaintingArtist();
            Painting myPaintingMedium = new PaintingMedium();
            Painting myPaintingYear = new PaintingYear();

            myPainting.paintingDetails();
            myPaintingName.paintingDetails();
            myPaintingArtist.paintingDetails();
            myPaintingMedium.paintingDetails();
            myPaintingYear.paintingDetails();
        }
    }
}

