using Microsoft.AspNetCore.Mvc;

namespace DependencyChecker.Tests {
	public class ControllerWithDependency : ControllerBase {
		private readonly IDependency1 dependency;

		public ControllerWithDependency(IDependency1 dependency) {
			this.dependency = dependency;
		}
	}
}
