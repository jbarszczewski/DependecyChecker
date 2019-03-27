using System;

namespace DependencyChecker.Tests
{
	public class ClassWithParameterlessConstructor {
		private DateTime currentDate;
		public ClassWithParameterlessConstructor() {
			currentDate = DateTime.Now;
		}
	}
}