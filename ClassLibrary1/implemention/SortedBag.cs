using System.Collections;
using ClassLibrary1.interacetypes;

namespace ClassLibrary1.implemention;

public class SortedBag : IsortedBag
{
    public int Count { get; private set; } 
    
    // private set not implemented in the interface because private cant be in interface , noted it has been removed due refactoring  
    public SortedList<int , int> Items { get; private set; }

    public SortedBag()
    {
        Items = new SortedList<int, int>();
    }

    public void Add(int number)
    {

        //Count++;
        // check if the key exist in the array if not it will increment one time at each iteration 
        if (!Items.ContainsKey(number))
        {
            Items[number] = 1;
           //Items.Add(number , 1 );
        }
        else
        {
            Items[number]++;
            //  Items.Add(number ,1);
        }

        Count++;

    }

    public int Fetch()
    {
        
       throw new NotImplementedException();
    }
}