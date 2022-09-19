using System.Collections;
using ClassLibrary1.implemention;
using ClassLibrary1.interacetypes;
using ConsoleApp2;
using gradescalculater;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace Xunittest
{
    public class UnitTest1
    {
        List<int> allowed

        [Fact]
        public void AddValidNumber()
        {

            // this is main steps to create test method 
            // 1- Arrange 
            int initialvalue = 123;
            int addvalue = 345;
            int expected = initialvalue + addvalue;
            IntCalculater cal = new IntCalculater();
            cal.add(initialvalue);

            //2-Act 
            cal.add(addvalue);

            //3-Assert 
            // check if the value expected match the result 
            Assert.Equal(expected, cal.Result);
        }

        [Fact]
        public void addOverflowValue()
        {
            IntCalculater cal = new IntCalculater();
            cal.add(int.MaxValue);
            //add + Assert 
            var ex = Assert.Throws<ArgumentException>(() => cal.add(1));
            Assert.Equal("Add with overflow", ex.Message);
        }

        [Fact]
        public void CreateSortedBag()
        {
            //Arrange 

            IsortedBag bag;
            //Act 
            bag = new SortedBag();
            //Assert 
            Assert.NotNull(bag);
            Assert.True(bag is SortedBag);

            Assert.Equal(0, bag.Count);

            Assert.NotNull(bag.Items);
            Assert.Empty(bag.Items);
        }

        [Fact]
        public void Adding()
        {
            //arrange 
            
            IsortedBag bag = new SortedBag();
            int number = 5;
            
            //acting
            bag.Add(number);
            
            //assert 
            Assert.Equal(1 , bag.Count);
            Assert.Contains(number, bag.Items.Keys);

        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Addingtwonumbers(int count)
        {
            //arrange 
            
            IsortedBag bag = new SortedBag();
            List<int> numbers = new List<int>() { 1, 2, 3 };
            List<int> expected = new List<int>(){1, 2, 3};
            //acting
            foreach(int number in numbers.Take(count).ToList())
                bag.Add(number);
            
            //assert 
            Assert.Equal(count , bag.Count);
           
            List<int> actual = SortedBagNumber(bag.Items);
          
            for (int i = 0; i < count; i++)
            {
                Assert.Equal(expected[i] , actual[i]);
            }
        }

        private List<int> SortedBagNumber(SortedList<int, int> items)
        {
            List<int> tmp = new();

            foreach (KeyValuePair<int,int > kv in items)
                for (int i = 0; i < kv.Value; i++)
                    tmp.Add(kv.Key);

            return tmp;

        }



        [Fact]
        public void insertstringvlaue()
        {
            gradecal cal = new gradecal();
            List<int> number = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                number.Add(i);     
            }
            
            
            
        }

    }
}

