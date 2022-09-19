namespace ClassLibrary1.interacetypes;

public interface IsortedBag
{
    public int Count { get;}
    
    public SortedList<int , int> Items { get; }
        
    /// <summary>
    ///   Adds given number to the bag 
    /// </summary>
    /// <param name="number">
    ///  the number to add to the SortedBag
    /// </param>
    void Add(int number);
    
    /// <summary>
    ///  method returns and remove  smallest value '
    ///     from the sorted bag
    ///        if the sorted bag is empty , an invalid operation Exception is thrown 
    /// </summary>
    /// <returns> Returns smallest value in the Sorted Bag </returns>
    int Fetch();
    
    
}