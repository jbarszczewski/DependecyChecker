namespace DependencyChecker.Tests {
	public class ClassWithDependency {
		private readonly IDependency1 dependency;

		public ClassWithDependency(IDependency1 dependency) {
			this.dependency = dependency;
		}
	}
}
