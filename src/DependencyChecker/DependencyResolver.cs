using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyChecker {
	public class DependencyResolver {
		public IEnumerable<Type> GetDependencies(Type classToCheck)
		{
			return classToCheck.GetConstructors()
				.SelectMany(constructorInfo => constructorInfo.GetParameters(),
					(constructorInfo, parameterInfo) => parameterInfo.ParameterType);
		}
	}
}
