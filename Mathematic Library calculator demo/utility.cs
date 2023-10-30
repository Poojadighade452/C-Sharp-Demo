


public class Utility

{

 public int  Getotp()
  {
        Random rand = new Random();
        return rand.Next(1000, 9999);
  }


}