﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonServices
{
	public interface IService<TRequest>
	{
		object Execute(TRequest request);
	}
}
