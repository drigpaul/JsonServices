﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonServices.Exceptions;
using JsonServices.Messages;
using JsonServices.Serialization;
using JsonServices.Serialization.Newtonsoft;
using JsonServices.Tests.Messages;
using JsonServices.Tests.Services;
using NUnit.Framework;

namespace JsonServices.Tests.Serialization
{
	[TestFixture]
	public class SerializerTestsNewtonsoft : SerializerTestsBase
	{
		protected override ISerializer Serializer { get; } = new Serializer();
	}
}
