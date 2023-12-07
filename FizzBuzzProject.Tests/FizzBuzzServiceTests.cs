using FizzBuzzProject;
using System.Threading.Tasks;
using Xunit;

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
        public async Task Execute_ReturnsFizzForMultiplesOfThree()
        {
            // Act
            var result = await _fizzBuzzService.ExecuteAsync(3, 3);

            // Assert
            Assert.Equal($"Fizz{Environment.NewLine}", result);
        }

        [Fact]
        public async Task Execute_ReturnsBuzzForMultiplesOfFive()
        {
            // Act
            var result = await _fizzBuzzService.ExecuteAsync(5, 5);

            // Assert
            Assert.Equal($"Buzz{Environment.NewLine}", result);
        }

        [Fact]
        public async Task Execute_ReturnsFizzBuzzForMultiplesOfThreeAndFive()
        {
            // Act
            var result = await _fizzBuzzService.ExecuteAsync(15, 15);

            // Assert
            Assert.Equal($"FizzBuzz{Environment.NewLine}", result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public async Task Execute_ReturnsNumberForNonMultiplesOfThreeAndFive(int number)
        {
            // Act
            var result = await _fizzBuzzService.ExecuteAsync(number, number);

            // Assert
            Assert.Equal($"{number}{Environment.NewLine}", result);
        }
    }
}
