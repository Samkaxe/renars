namespace ConsoleApp2
{
    public class IntCalculater
    {
        public int Result { get; private set;}

       public void add(int x)
       {
           if (x > 0 && (Result + x) < Result)
           {
               throw new ArgumentException("Add with overflow");// the problem was here because the two strings doesnot match 
               // in the unit testing , "add with overflow" 
               
           }
           Result += x;  
       
        }
    }  
}
