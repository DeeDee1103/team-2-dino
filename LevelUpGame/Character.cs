namespace levelup
{
     public class Character{
          public static string DEFAULT_NAME { get; set; }
          public string NAME { get; set; }

          public Character(){
               this.NAME = DEFAULT_NAME;
          }
          public Character(string name){
               this.NAME = name;      

          }
     
     }
  
    }
