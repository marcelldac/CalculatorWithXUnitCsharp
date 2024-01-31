using Calculator.Services;

namespace CalculatorTests
{
    public class StringValidationTests
    {
        private StringValidations _validations;
        public StringValidationTests()
        {
            _validations = new StringValidations();
        }
        [Fact]
        public void ShouldCount5CharactersInHelloAndReturn5()
        {
            string text = "Hello";
            int result = _validations.CountCharacters(text);
            Assert.Equal(5, result);
        }
    }
}