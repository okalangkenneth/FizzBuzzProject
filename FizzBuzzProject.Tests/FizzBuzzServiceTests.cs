namespace FizzBuzzProject.Tests
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void Execute_ReturnsFizzForMultiplesOfThree()
        {
            // Act
            var result = _fizzBuzzService.Execute(3, 3);

            // Assert
            Assert.Equal($"Fizz{Environment.NewLine}", result);
        }

        [Fact]
        public void Execute_ReturnsBuzzForMultiplesOfFive()
        {
            // Act
            var result = _fizzBuzzService.Execute(5, 5);

            // Assert
            Assert.Equal($"Buzz{Environment.NewLine}", result);
        }

        [Fact]
        public void Execute_ReturnsFizzBuzzForMultiplesOfThreeAndFive()
        {
            // Act
            var result = _fizzBuzzService.Execute(15, 15);

            // Assert
            Assert.Equal($"FizzBuzz{Environment.NewLine}", result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void Execute_ReturnsNumberForNonMultiplesOfThreeAndFive(int number)
        {
            // Act
            var result = _fizzBuzzService.Execute(number, number);

            // Assert
            Assert.Equal($"{number}{Environment.NewLine}", result);
        }
    }
}
