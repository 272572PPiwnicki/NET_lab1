using NET_lab1;

namespace NET_1_tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Solve_AtLeastOneItemFits_ReturnAtLeastOneElement()
        {
            // arrange
            var problem = new Problem(5, 3);
            int capacity = problem.Items.Min(item => item.Weight);

            // act
            var result = problem.Solve(capacity);

            // assert
            Assert.IsTrue(result.SelectedItems.Count > 0, "Should be at least one item in backpack.");
        }

        [TestMethod]
        public void Solve_NoItemFits_ReturnEmptList()
        {
            // arrange
            var problem = new Problem(5, 3);
            int capacity = problem.Items.Min(item => item.Weight) - 1;

            // act
            var result = problem.Solve(capacity);

            // assert
            Assert.AreEqual(0, result.SelectedItems.Count, "List should be empty.");
        }

        [TestMethod]
        public void Solve_KnownInstance_ReturnCorrectResult()
        {
            // arrange
            var problem = new Problem(3, 1);
            int capacity = 10;

            int expectedTotalValue = 10;
            int expectedTotalWeight = 7;

            // act
            var result = problem.Solve(capacity);

            // assert
            Assert.AreEqual(expectedTotalValue, result.TotalValue, "Total value should be correct.");
            Assert.AreEqual(expectedTotalWeight, result.TotalWeight, "Total weight should be correct.");
        }

        [TestMethod]
        public void Solve_TotalWeight_ShouldNotExceedCapacity()
        {
            // arrange
            var problem = new Problem(5, 1);
            int capacity = 15;

            // act
            var result = problem.Solve(capacity);

            // assert
            Assert.IsTrue(result.TotalWeight <= capacity, "Total weight should not exceed capacity.");
        }

        [TestMethod]
        public void Solve_BigCapacity_AllItemsFit ()
        {
            // arrange
            var problem = new Problem(5, 1);
            int totalWeight = problem.Items.Sum(item => item.Weight);
            int capacity = totalWeight + 10;

            // act
            var result = problem.Solve(capacity);

            // assert
            Assert.AreEqual(problem.Items.Count, result.SelectedItems.Count, "All items should be selected.");
        }
    }
}
