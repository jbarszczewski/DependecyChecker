using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace DependencyChecker {
	public class DependencyResolver {
		public IEnumerable<Type> GetDependencies(Type classToCheck) {
			return classToCheck.GetConstructors()
				.SelectMany(constructorInfo => constructorInfo.GetParameters(),
					(constructorInfo, parameterInfo) => parameterInfo.ParameterType);
		}

		public IEnumerable<Type> GetAssemblyControllers(Assembly assembly)
		{
			return assembly.ExportedTypes.Where(t => t.IsSubclassOf(typeof(ControllerBase))).ToList();
		}
	}
}
