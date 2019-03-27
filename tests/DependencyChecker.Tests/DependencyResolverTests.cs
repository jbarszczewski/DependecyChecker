using FluentAssertions;
using Xunit;

namespace DependencyChecker.Tests {
	public class DependencyResolverTests {
		readonly DependencyResolver sut = new DependencyResolver();
		
		[Fact]
		public void GetDependencies_ParameterlessConstructor_ReturnsEmpty() {
			var result = sut.GetDependencies(typeof(ClassWithParameterlessConstructor));

			result.Should().BeEmpty();
		}

		[Fact]
		public void GetDependencies_NoConstructor_ReturnsEmpty() {
			var result = sut.GetDependencies(typeof(ClassWithoutConstructor));

			result.Should().BeEmpty();
		}

		[Fact]
		public void GetDependencies_ConstructorWithParameters_ReturnsParametersTypes() {
			var result = sut.GetDependencies(typeof(ClassWithDependency));

			result.Should().BeEquivalentTo(typeof(IDependency1));
		}
	}
}
