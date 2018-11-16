using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp
{
	public class SwaggerOperationFilter : IOperationFilter
	{
		public void Apply(Operation operation, OperationFilterContext context)
		{
			var className = context.MethodInfo.DeclaringType.Name;
			if(className.Contains("Controller"))
				className = className.Replace("Controller", "");
			var methodName = context.MethodInfo.Name;
			operation.OperationId = $"{className}_{methodName}";
		}
	}
}
