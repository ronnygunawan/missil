using System;
using Xunit;
using Missil;
using System.Reflection;
using FluentAssertions;

namespace Tests {
	public class EmitTests {
		[Fact]
		public void EmittedMethodWorksJustFine() {
			Type tBasicTests = new AssemblyName("Missil.Tests")
				.DefineDynamicAssembly()
				.DefineDynamicModule("Missil.Tests")
				.DefinePublicClass("BasicTests", null, typeof(IBasicTests))
				.DefineFuncOverride<IBasicTests, int, int>(nameof(IBasicTests.SquareTimesTwo), ilgen => ilgen
					.Ldarg_1()
					.Dup()
					.Mul()
					.Ldc_I4_2()
					.Mul()
					.Ret()
				)
				.CreateType();

			IBasicTests basicTests = (IBasicTests)Activator.CreateInstance(tBasicTests);
			int result = basicTests.SquareTimesTwo(9);

			result.Should().Be(162);
		}

		public interface IBasicTests {
			int SquareTimesTwo(int x);
		}
	}
}
