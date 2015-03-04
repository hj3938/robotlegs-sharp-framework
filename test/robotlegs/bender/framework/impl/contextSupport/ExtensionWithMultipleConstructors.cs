﻿using System;
using robotlegs.bender.framework.api;

namespace robotlegs.bender.framework.impl.contextSupport
{
	public class ExtensionWithMultipleConstructors : IExtension
	{
		public static Action<ExtensionWithMultipleConstructors> staticCallback;

		public int value1 = -1;
		public string value2 = "classValue";
		public int value3 = -1;
		public float value4 = -1;
		public string value5 = "classValue";

		public int constructorArguments = -1;

		public ExtensionWithMultipleConstructors (int value1 = 1, string value2 = "arg", int value3 = 5)
		{
			this.constructorArguments = 3;
			this.value1 = value1;
			this.value2 = value2;
			this.value3 = value3;
		}

		public ExtensionWithMultipleConstructors (int value1 = 1, string value2 = "arg")
		{
			constructorArguments = 2;
			this.value1 = value1;
			this.value2 = value2;
		}

		public ExtensionWithMultipleConstructors (int value1 = 1, string value2 = "arg", int value3 = 5, float value4 = 10f, string value5 = "anotherarg")
		{
			constructorArguments = 5;
			this.value1 = value1;
			this.value2 = value2;
			this.value3 = value3;
			this.value4 = value4;
			this.value5 = value5;
		}

		public ExtensionWithMultipleConstructors (int value1 = 1, string value2 = "arg", int value3 = 5, float value4 = 10f)
		{
			constructorArguments = 4;
			this.value1 = value1;
			this.value2 = value2;
			this.value3 = value3;
			this.value4 = value4;
		}

		public void Extend (IContext context)
		{
			if (staticCallback != null)
				staticCallback (this);
		}
	}
}
