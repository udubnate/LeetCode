using NUnit.Framework;
using csharp_leetcode;

namespace csharp_leetcode.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Concantenation_of_array_test()
        {
            Concatenation_of_array coa = new Concatenation_of_array();
            int[] test1 = coa.GetConcatenation(new int[] { 1, 2, 1 });
            Assert.That(test1, Is.EqualTo(new int[] { 1, 2, 1, 1, 2, 1}));
            
            int[] test2 = coa.GetConcatenation(new int[] { 1, 3, 2, 1 });
            Assert.That(test2, Is.EqualTo(new int[] { 1, 3, 2, 1, 1, 3, 2, 1 }));
        }

        [Test]
        public void Remove_Duplicates_from_Sorted_Array_test()
        {
            Remove_Duplicates_from_Sorted_Array remdup = new Remove_Duplicates_from_Sorted_Array();
          
            var test1 = remdup.RemoveDuplicates(new int[] { 1, 1, 2 });
            Assert.That(test1, Is.EqualTo(2));

            var test2 = remdup.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Assert.That(test2, Is.EqualTo(5));
        }

        [Test]
        public void climbing_stairs_test()
        {
            climbing_stairs obj = new climbing_stairs();

            var test1 = obj.ClimbStairs(5);
            Assert.That(test1, Is.EqualTo(8));

            var test2 = obj.ClimbStairs(3);
            Assert.That(test2, Is.EqualTo(3));
        }

        [Test]
        public void baseball_game_test()
        {
            baseball_game obj = new baseball_game();

            var test1 = obj.CalPoints(new string[] { "5", "2", "C", "D", "+" });
            Assert.That(test1, Is.EqualTo(30));

            var test2 = obj.CalPoints(new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" });
            Assert.That(test2, Is.EqualTo(27));
        }
    }
}