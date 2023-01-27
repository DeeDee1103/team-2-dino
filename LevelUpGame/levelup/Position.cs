using System.Drawing; 

namespace levelup
{
    public class Position
    {
         public Point coordinates {get; set;}

          public Position(int X,int Y){
               this.coordinates = new Point(X, Y);
          }
    }

     

}