namespace gradescalculater;

public class gradecal
{

   public int ToGrade(int percentage)
   {
      if (percentage >= 0 && percentage <= 7)
      {
         return -3;
      }
      else if (percentage >= 8 && percentage <= 33)
      {
         return 00;
      }
      else if (percentage >= 34 && percentage <= 41)
      {
         return 02
      }
      else if (percentage >= 42 && percentage <= 57)
      {
         return 4;
      }
      else if (percentage >= 58 && percentage <= 77)
      {
         return 7;

      }
      else if (percentage >= 78 && percentage <= 89)
      {
         return 10;
      }
      else if (percentage >= 90 && percentage <= 100)
      {
         return 12;
      }
      
   
   }
}