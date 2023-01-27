namespace levelup
{
     public class Character{
          public static string DEFAULT_NAME = "Character";
          public string NAME { get; set; }

          public Character(){
               this.NAME = DEFAULT_NAME;
          }
          public Character(string name){
               this.NAME = name;      

          }
     
     }
  
    }
