﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonServices.Services
{
	public interface IServiceExecutor
	{
		object Execute(string name, IRequestContext context, object parameters);

		void RegisterHandler(string name, Func<IRequestContext, object, object> execute);
	}
}
