using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Missil {
	public static class AssemblyBuilderShorthandExtensions {
		public static AssemblyBuilder DefineDynamicAssembly(this AssemblyName name, Action<AssemblyBuilder>? buildAction = null, AssemblyBuilderAccess access = AssemblyBuilderAccess.RunAndCollect) {
			AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(name, access);
			buildAction?.Invoke(assemblyBuilder);
			return assemblyBuilder;
		}

		public static ModuleBuilder DefineDynamicModule(this AssemblyBuilder assemblyBuilder, string name, Action<ModuleBuilder>? buildAction = null) {
			ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(name);
			buildAction?.Invoke(moduleBuilder);
			return moduleBuilder;
		}

		public static TypeBuilder DefinePublicClass(this ModuleBuilder moduleBuilder, string name, Type? parent = null, params Type[] interfaces) {
			TypeBuilder typeBuilder = moduleBuilder.DefineType(
				name: name,
				attr: TypeAttributes.Public | TypeAttributes.Class | TypeAttributes.AutoClass | TypeAttributes.AnsiClass | TypeAttributes.BeforeFieldInit | TypeAttributes.AutoLayout,
				parent: null,
				interfaces: interfaces);
			return typeBuilder;
		}

		public static TypeBuilder DefineActionOverride<TInterface>(this TypeBuilder typeBuilder, string actionName, Action<ILGenerator> generateAction) {
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(actionName,
				MethodAttributes.Public |
				MethodAttributes.Virtual,
				typeof(void),
				Type.EmptyTypes);
			ILGenerator gen = methodBuilder.GetILGenerator();
			generateAction.Invoke(gen);
			typeBuilder.DefineMethodOverride(methodBuilder, typeof(TInterface).GetMethod(actionName, Type.EmptyTypes)!);
			return typeBuilder;
		}

		public static TypeBuilder DefineActionOverride<TInterface, T1>(this TypeBuilder typeBuilder, string actionName, Action<ILGenerator> generateAction) {
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(actionName,
				MethodAttributes.Public |
				MethodAttributes.Virtual,
				typeof(void),
				new Type[] { typeof(T1) });
			ILGenerator gen = methodBuilder.GetILGenerator();
			generateAction.Invoke(gen);
			typeBuilder.DefineMethodOverride(methodBuilder, typeof(TInterface).GetMethod(actionName, new Type[] { typeof(T1) })!);
			return typeBuilder;
		}

		public static TypeBuilder DefineActionOverride<TInterface, T1, T2>(this TypeBuilder typeBuilder, string actionName, Action<ILGenerator> generateAction) {
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(actionName,
				MethodAttributes.Public |
				MethodAttributes.Virtual,
				typeof(void),
				new Type[] { typeof(T1), typeof(T2) });
			ILGenerator gen = methodBuilder.GetILGenerator();
			generateAction.Invoke(gen);
			typeBuilder.DefineMethodOverride(methodBuilder, typeof(TInterface).GetMethod(actionName, new Type[] { typeof(T1), typeof(T2) })!);
			return typeBuilder;
		}

		public static TypeBuilder DefineActionOverride<TInterface, T1, T2, T3>(this TypeBuilder typeBuilder, string actionName, Action<ILGenerator> generateAction) {
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(actionName,
				MethodAttributes.Public |
				MethodAttributes.Virtual,
				typeof(void),
				new Type[] { typeof(T1), typeof(T2), typeof(T3) });
			ILGenerator gen = methodBuilder.GetILGenerator();
			generateAction.Invoke(gen);
			typeBuilder.DefineMethodOverride(methodBuilder, typeof(TInterface).GetMethod(actionName, new Type[] { typeof(T1), typeof(T2), typeof(T3) })!);
			return typeBuilder;
		}

		public static TypeBuilder DefineFuncOverride<TInterface, TReturn>(this TypeBuilder typeBuilder, string actionName, Action<ILGenerator> generateAction) {
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(actionName,
				MethodAttributes.Public |
				MethodAttributes.Virtual,
				typeof(TReturn),
				Type.EmptyTypes);
			ILGenerator gen = methodBuilder.GetILGenerator();
			generateAction.Invoke(gen);
			typeBuilder.DefineMethodOverride(methodBuilder, typeof(TInterface).GetMethod(actionName, Type.EmptyTypes)!);
			return typeBuilder;
		}

		public static TypeBuilder DefineFuncOverride<TInterface, TReturn, T1>(this TypeBuilder typeBuilder, string actionName, Action<ILGenerator> generateAction) {
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(actionName,
				MethodAttributes.Public |
				MethodAttributes.Virtual,
				typeof(TReturn),
				new Type[] { typeof(T1) });
			ILGenerator gen = methodBuilder.GetILGenerator();
			generateAction.Invoke(gen);
			typeBuilder.DefineMethodOverride(methodBuilder, typeof(TInterface).GetMethod(actionName, new Type[] { typeof(T1) })!);
			return typeBuilder;
		}

		public static TypeBuilder DefineFuncOverride<TInterface, TReturn, T1, T2>(this TypeBuilder typeBuilder, string actionName, Action<ILGenerator> generateAction) {
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(actionName,
				MethodAttributes.Public |
				MethodAttributes.Virtual,
				typeof(TReturn),
				new Type[] { typeof(T1), typeof(T2) });
			ILGenerator gen = methodBuilder.GetILGenerator();
			generateAction.Invoke(gen);
			typeBuilder.DefineMethodOverride(methodBuilder, typeof(TInterface).GetMethod(actionName, new Type[] { typeof(T1), typeof(T2) })!);
			return typeBuilder;
		}

		public static TypeBuilder DefineFuncOverride<TInterface, TReturn, T1, T2, T3>(this TypeBuilder typeBuilder, string actionName, Action<ILGenerator> generateAction) {
			MethodBuilder methodBuilder = typeBuilder.DefineMethod(actionName,
				MethodAttributes.Public |
				MethodAttributes.Virtual,
				typeof(TReturn),
				new Type[] { typeof(T1), typeof(T2), typeof(T3) });
			ILGenerator gen = methodBuilder.GetILGenerator();
			generateAction.Invoke(gen);
			typeBuilder.DefineMethodOverride(methodBuilder, typeof(TInterface).GetMethod(actionName, new Type[] { typeof(T1), typeof(T2), typeof(T3) })!);
			return typeBuilder;
		}
	}
}
