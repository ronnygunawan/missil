using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Missil {
	public static class ILGeneratorShorthandExtensions {

		/// <summary>
		/// Declares a local variable of the specified type.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator DeclareLocal(this ILGenerator ilGenerator, Type localType, out LocalBuilder local) {
			local = ilGenerator.DeclareLocal(localType);
			return ilGenerator;
		}

		/// <summary>
		/// Declares a local variable of the specified type.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator DeclareLocal<T>(this ILGenerator ilGenerator, out LocalBuilder local) {
			local = ilGenerator.DeclareLocal(typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Declares a local variable of the specified type, optionally pinning the object referred to by the variable.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator DeclareLocal(this ILGenerator ilGenerator, Type localType, out LocalBuilder local, bool pinned) {
			local = ilGenerator.DeclareLocal(localType, pinned);
			return ilGenerator;
		}

		/// <summary>
		/// Declares a local variable of the specified type, optionally pinning the object referred to by the variable.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator DeclareLocal<T>(this ILGenerator ilGenerator, out LocalBuilder local, bool pinned) {
			local = ilGenerator.DeclareLocal(typeof(T), pinned);
			return ilGenerator;
		}

		/// <summary>
		/// Marks the Microsoft intermediate language (MSIL) stream&#39;s current position with the given label.
		/// </summary>
		public static ILGenerator MarkLabel(this ILGenerator ilGenerator, out Label loc) {
			loc = ilGenerator.DefineLabel();
			ilGenerator.MarkLabel(loc);
			return ilGenerator;
		}

		/// <summary>
		/// Marks the Microsoft intermediate language (MSIL) stream&#39;s current position with the given label.
		/// </summary>
		public static ILGenerator MarkLabel(this ILGenerator ilGenerator, Label loc) {
			ilGenerator.MarkLabel(loc);
			return ilGenerator;
		}

		/// <summary>
		/// Adds two values and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Add(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Add);
			return ilGenerator;
		}

		/// <summary>
		/// Adds two integers, performs an overflow check, and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Add_Ovf(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Add_Ovf);
			return ilGenerator;
		}

		/// <summary>
		/// Adds two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Add_Ovf_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Add_Ovf_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Computes the bitwise AND of two values and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator And(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.And);
			return ilGenerator;
		}

		/// <summary>
		/// Returns an unmanaged pointer to the argument list of the current method.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Arglist(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Arglist);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if two values are equal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Beq(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Beq, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if two values are equal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Beq(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Beq, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if two values are equal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Beq_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Beq_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if two values are equal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Beq_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Beq_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is greater than or equal to the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bge(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bge, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is greater than or equal to the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bge(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bge, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bge_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bge_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is greater than or equal to the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bge_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bge_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bge_Un(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bge_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bge_Un(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bge_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bge_Un_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bge_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bge_Un_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bge_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is greater than the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bgt(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bgt, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is greater than the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bgt(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bgt, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is greater than the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bgt_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bgt_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is greater than the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bgt_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bgt_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bgt_Un(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bgt_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bgt_Un(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bgt_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bgt_Un_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bgt_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is greater than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bgt_Un_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bgt_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is less than or equal to the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ble(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Ble, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is less than or equal to the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ble(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Ble, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ble_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Ble_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is less than or equal to the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ble_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Ble_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ble_Un(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Ble_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ble_Un(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Ble_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ble_Un_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Ble_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is less than or equal to the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ble_Un_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Ble_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is less than the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Blt(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Blt, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is less than the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Blt(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Blt, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is less than the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Blt_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Blt_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is less than the second value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Blt_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Blt_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Blt_Un(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Blt_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Blt_Un(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Blt_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Blt_Un_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Blt_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if the first value is less than the second value, when comparing unsigned integer values or unordered float values.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Blt_Un_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Blt_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bne_Un(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bne_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction when two unsigned integer values or unordered float values are not equal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bne_Un(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bne_Un, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bne_Un_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Bne_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) when two unsigned integer values or unordered float values are not equal.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Bne_Un_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Bne_Un_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Converts a value type to an object reference (type O).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Box(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Box, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Converts a value type to an object reference (type O).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Box<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Box, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Unconditionally transfers control to a target instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Br(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Br, label);
			return ilGenerator;
		}

		/// <summary>
		/// Unconditionally transfers control to a target instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Br(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Br, label);
			return ilGenerator;
		}

		/// <summary>
		/// Unconditionally transfers control to a target instruction (short form).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Br_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Br_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Unconditionally transfers control to a target instruction (short form).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Br_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Br_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Signals the Common Language Infrastructure (CLI) to inform the debugger that a break point has been tripped.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Break(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Break);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if value is false, a null reference (Nothing in Visual Basic), or zero.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Brfalse(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Brfalse, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if value is false, a null reference (Nothing in Visual Basic), or zero.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Brfalse(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Brfalse, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if value is false, a null reference, or zero.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Brfalse_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Brfalse_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if value is false, a null reference, or zero.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Brfalse_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Brfalse_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if value is true, not null, or non-zero.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Brtrue(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Brtrue, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction if value is true, not null, or non-zero.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Brtrue(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Brtrue, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if value is true, not null, or non-zero.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Brtrue_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Brtrue_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control to a target instruction (short form) if value is true, not null, or non-zero.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Brtrue_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Brtrue_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Calls the method indicated by the passed method descriptor.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Call(this ILGenerator ilGenerator, MethodInfo meth) {
			ilGenerator.Emit(OpCodes.Call, meth);
			return ilGenerator;
		}

		/// <summary>
		/// Calls the method indicated by the passed method descriptor.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Call(this ILGenerator ilGenerator, MethodInfo methodInfo, params Type[] optionalParameterTypes) {
			ilGenerator.EmitCall(OpCodes.Call, methodInfo, optionalParameterTypes);
			return ilGenerator;
		}

		/// <summary>
		/// Calls the method indicated on the evaluation stack (as a pointer to an entry point) with arguments described by a calling convention.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Calli(this ILGenerator ilGenerator, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes) {
			ilGenerator.EmitCalli(OpCodes.Calli, callingConvention, returnType, parameterTypes, optionalParameterTypes);
			return ilGenerator;
		}

#if !NETSTANDARD2_0
		/// <summary>
		/// Calls the method indicated on the evaluation stack (as a pointer to an entry point) with arguments described by a calling convention.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Calli(this ILGenerator ilGenerator, CallingConvention unmanagedCallConv, Type returnType, params Type[] parameterTypes) {
			ilGenerator.EmitCalli(OpCodes.Calli, unmanagedCallConv, returnType, parameterTypes);
			return ilGenerator;
		}
#endif

		/// <summary>
		/// Calls a late-bound method on an object, pushing the return value onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Callvirt(this ILGenerator ilGenerator, MethodInfo meth) {
			ilGenerator.Emit(OpCodes.Callvirt, meth);
			return ilGenerator;
		}

		/// <summary>
		/// Calls a late-bound method on an object, pushing the return value onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Callvirt(this ILGenerator ilGenerator, MethodInfo methodInfo, params Type[] optionalParameterTypes) {
			ilGenerator.EmitCall(OpCodes.Callvirt, methodInfo, optionalParameterTypes);
			return ilGenerator;
		}

		/// <summary>
		/// Attempts to cast an object passed by reference to the specified class.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Castclass(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Castclass, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Attempts to cast an object passed by reference to the specified class.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Castclass<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Castclass, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Compares two values. If they are equal, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ceq(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ceq);
			return ilGenerator;
		}

		/// <summary>
		/// Compares two values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Cgt(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Cgt);
			return ilGenerator;
		}

		/// <summary>
		/// Compares two unsigned or unordered values. If the first value is greater than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Cgt_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Cgt_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Throws ArithmeticException if value is not a finite number.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ckfinite(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ckfinite);
			return ilGenerator;
		}

		/// <summary>
		/// Compares two values. If the first value is less than the second, the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Clt(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Clt);
			return ilGenerator;
		}

		/// <summary>
		/// Compares the unsigned or unordered values value1 and value2. If value1 is less than value2, then the integer value 1 (int32) is pushed onto the evaluation stack; otherwise 0 (int32) is pushed onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Clt_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Clt_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Constrains the type on which a virtual method call is made.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Constrained(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Constrained, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Constrains the type on which a virtual method call is made.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Constrained<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Constrained, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to native int.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_I(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_I);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to int8, then extends (pads) it to int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_I1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_I1);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to int16, then extends (pads) it to int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_I2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_I2);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_I4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_I4);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to int64.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_I8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_I8);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to signed native int, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I1);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to signed int8 and extends it to int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I1_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I1_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to signed int16 and extending it to int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I2);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to signed int16 and extends it to int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I2_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I2_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I4);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to signed int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I4_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I4_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I8);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to signed int64, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_I8_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_I8_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to unsigned native int, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U1);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to unsigned int8 and extends it to int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U1_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U1_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U2);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to unsigned int16 and extends it to int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U2_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U2_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U4);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to unsigned int32, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U4_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U4_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the signed value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U8);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned value on top of the evaluation stack to unsigned int64, throwing OverflowException on overflow.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_Ovf_U8_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_Ovf_U8_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the unsigned integer value on top of the evaluation stack to float32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_R_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_R_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to float32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_R4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_R4);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to float64.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_R8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_R8);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to unsigned native int, and extends it to native int.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_U(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_U);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to unsigned native int, and extends it to native int.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_U1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_U1);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to unsigned int16, and extends it to int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_U2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_U2);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to unsigned int32, and extends it to int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_U4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_U4);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the value on top of the evaluation stack to unsigned int64, and extends it to int64.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Conv_U8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Conv_U8);
			return ilGenerator;
		}

		/// <summary>
		/// Copies a specified number bytes from a source address to a destination address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Cpblk(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Cpblk);
			return ilGenerator;
		}

		/// <summary>
		/// Copies the value type located at the address of an object (type &, or native int) to the address of the destination object (type &, or native int).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Cpobj(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Cpobj, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Copies the value type located at the address of an object (type &, or native int) to the address of the destination object (type &, or native int).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Cpobj<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Cpobj, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Divides two values and pushes the result as a floating-point (type F) or quotient (type int32) onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Div(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Div);
			return ilGenerator;
		}

		/// <summary>
		/// Divides two unsigned integer values and pushes the result (int32) onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Div_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Div_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Copies the current topmost value on the evaluation stack, and then pushes the copy onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Dup(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Dup);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control from the filter clause of an exception back to the Common Language Infrastructure (CLI) exception handler.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Endfilter(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Endfilter);
			return ilGenerator;
		}

		/// <summary>
		/// Transfers control from the fault or finally clause of an exception block back to the Common Language Infrastructure (CLI) exception handler.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Endfinally(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Endfinally);
			return ilGenerator;
		}

		/// <summary>
		/// Initializes a specified block of memory at a specific address to a given size and initial value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Initblk(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Initblk);
			return ilGenerator;
		}

		/// <summary>
		/// Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Initobj(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Initobj, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Initializes each field of the value type at a specified address to a null reference or a 0 of the appropriate primitive type.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Initobj<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Initobj, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Tests whether an object reference (type O) is an instance of a particular class.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Isinst(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Isinst, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Tests whether an object reference (type O) is an instance of a particular class.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Isinst<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Isinst, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Exits current method and jumps to specified method.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Jmp(this ILGenerator ilGenerator, MethodInfo meth) {
			ilGenerator.Emit(OpCodes.Jmp, meth);
			return ilGenerator;
		}

		/// <summary>
		/// Loads an argument (referenced by a specified index value) onto the stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarg(this ILGenerator ilGenerator, short arg) {
			ilGenerator.Emit(OpCodes.Ldarg, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Loads an argument (referenced by a specified index value) onto the stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarg_X(this ILGenerator ilGenerator, short arg) {
			switch (arg) {
				case 0: ilGenerator.Emit(OpCodes.Ldarg_0); break;
				case 1: ilGenerator.Emit(OpCodes.Ldarg_1); break;
				case 2: ilGenerator.Emit(OpCodes.Ldarg_2); break;
				case 3: ilGenerator.Emit(OpCodes.Ldarg_3); break;
				default: ilGenerator.Emit(OpCodes.Ldarg, arg); break;
			}
			return ilGenerator;
		}

		/// <summary>
		/// Loads the argument at index 0 onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarg_0(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldarg_0);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the argument at index 1 onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarg_1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldarg_1);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the argument at index 2 onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarg_2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldarg_2);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the argument at index 3 onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarg_3(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldarg_3);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the argument (referenced by a specified short form index) onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarg_S(this ILGenerator ilGenerator, byte arg) {
			ilGenerator.Emit(OpCodes.Ldarg_S, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Load an argument address onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarga(this ILGenerator ilGenerator, short arg) {
			ilGenerator.Emit(OpCodes.Ldarga, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Load an argument address, in short form, onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldarga_S(this ILGenerator ilGenerator, byte arg) {
			ilGenerator.Emit(OpCodes.Ldarga_S, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a supplied value of type int32 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4(this ILGenerator ilGenerator, int arg) {
			ilGenerator.Emit(OpCodes.Ldc_I4, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a supplied value of type int32 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_X(this ILGenerator ilGenerator, int arg) {
			switch (arg) {
				case 0: ilGenerator.Emit(OpCodes.Ldc_I4_0); break;
				case 1: ilGenerator.Emit(OpCodes.Ldc_I4_1); break;
				case 2: ilGenerator.Emit(OpCodes.Ldc_I4_2); break;
				case 3: ilGenerator.Emit(OpCodes.Ldc_I4_3); break;
				case 4: ilGenerator.Emit(OpCodes.Ldc_I4_4); break;
				case 5: ilGenerator.Emit(OpCodes.Ldc_I4_5); break;
				case 6: ilGenerator.Emit(OpCodes.Ldc_I4_6); break;
				case 7: ilGenerator.Emit(OpCodes.Ldc_I4_7); break;
				case 8: ilGenerator.Emit(OpCodes.Ldc_I4_8); break;
				case -1: ilGenerator.Emit(OpCodes.Ldc_I4_M1); break;
				default: ilGenerator.Emit(OpCodes.Ldc_I4, arg); break;
			}
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 0 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_0(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_0);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 1 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_1);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 2 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_2);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 3 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_3(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_3);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 4 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_4);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 5 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_5(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_5);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 6 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_6(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_6);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 7 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_7(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_7);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of 8 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_8);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the integer value of -1 onto the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_M1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldc_I4_M1);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the supplied int8 value onto the evaluation stack as an int32, short form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I4_S(this ILGenerator ilGenerator, byte arg) {
			ilGenerator.Emit(OpCodes.Ldc_I4_S, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a supplied value of type int64 onto the evaluation stack as an int64.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_I8(this ILGenerator ilGenerator, long arg) {
			ilGenerator.Emit(OpCodes.Ldc_I8, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a supplied value of type float32 onto the evaluation stack as type F (float).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_R4(this ILGenerator ilGenerator, float arg) {
			ilGenerator.Emit(OpCodes.Ldc_R4, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a supplied value of type float64 onto the evaluation stack as type F (float).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldc_R8(this ILGenerator ilGenerator, double arg) {
			ilGenerator.Emit(OpCodes.Ldc_R8, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Ldelem, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element at a specified array index onto the top of the evaluation stack as the type specified in the instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type native int at a specified array index onto the top of the evaluation stack as a native int.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_I(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_I);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type int8 at a specified array index onto the top of the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_I1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_I1);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type int16 at a specified array index onto the top of the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_I2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_I2);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type int32 at a specified array index onto the top of the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_I4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_I4);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type int64 at a specified array index onto the top of the evaluation stack as an int64.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_I8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_I8);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type float32 at a specified array index onto the top of the evaluation stack as type F (float).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_R4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_R4);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type float64 at a specified array index onto the top of the evaluation stack as type F (float).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_R8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_R8);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element containing an object reference at a specified array index onto the top of the evaluation stack as type O (object reference).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_Ref(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_Ref);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type unsigned int8 at a specified array index onto the top of the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_U1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_U1);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type unsigned int16 at a specified array index onto the top of the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_U2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_U2);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the element with type unsigned int32 at a specified array index onto the top of the evaluation stack as an int32.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelem_U4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelem_U4);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the address of the array element at a specified array index onto the top of the evaluation stack as type & (managed pointer).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelema(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Ldelema, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the address of the array element at a specified array index onto the top of the evaluation stack as type & (managed pointer).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldelema<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldelema, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Finds the value of a field in the object whose reference is currently on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldfld(this ILGenerator ilGenerator, FieldInfo field) {
			ilGenerator.Emit(OpCodes.Ldfld, field);
			return ilGenerator;
		}

		/// <summary>
		/// Finds the address of a field in the object whose reference is currently on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldflda(this ILGenerator ilGenerator, FieldInfo field) {
			ilGenerator.Emit(OpCodes.Ldflda, field);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes an unmanaged pointer (type native int) to the native code implementing a specific method onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldftn(this ILGenerator ilGenerator, MethodInfo meth) {
			ilGenerator.Emit(OpCodes.Ldftn, meth);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type native int as a native int onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_I(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_I);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type int8 as an int32 onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_I1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_I1);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type int16 as an int32 onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_I2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_I2);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type int32 as an int32 onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_I4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_I4);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type int64 as an int64 onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_I8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_I8);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type float32 as a type F (float) onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_R4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_R4);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type float64 as a type F (float) onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_R8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_R8);
			return ilGenerator;
		}

		/// <summary>
		/// Loads an object reference as a type O (object reference) onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_Ref(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_Ref);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type unsigned int8 as an int32 onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_U1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_U1);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type unsigned int16 as an int32 onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_U2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_U2);
			return ilGenerator;
		}

		/// <summary>
		/// Loads a value of type unsigned int32 as an int32 onto the evaluation stack indirectly.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldind_U4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldind_U4);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the number of elements of a zero-based, one-dimensional array onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldlen(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldlen);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at a specific index onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc(this ILGenerator ilGenerator, LocalBuilder local) {
			ilGenerator.Emit(OpCodes.Ldloc, local);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at a specific index onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc(this ILGenerator ilGenerator, short arg) {
			ilGenerator.Emit(OpCodes.Ldloc, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at a specific index onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc_X(this ILGenerator ilGenerator, short arg) {
			switch (arg) {
				case 0: ilGenerator.Emit(OpCodes.Ldloc_0); break;
				case 1: ilGenerator.Emit(OpCodes.Ldloc_1); break;
				case 2: ilGenerator.Emit(OpCodes.Ldloc_2); break;
				case 3: ilGenerator.Emit(OpCodes.Ldloc_3); break;
				default: ilGenerator.Emit(OpCodes.Ldloc, arg); break;
			}
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at index 0 onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc_0(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldloc_0);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at index 1 onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc_1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldloc_1);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at index 2 onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc_2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldloc_2);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at index 3 onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc_3(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldloc_3);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at a specific index onto the evaluation stack, short form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc_S(this ILGenerator ilGenerator, LocalBuilder local) {
			ilGenerator.Emit(OpCodes.Ldloc_S, local);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the local variable at a specific index onto the evaluation stack, short form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloc_S(this ILGenerator ilGenerator, byte arg) {
			ilGenerator.Emit(OpCodes.Ldloc_S, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the address of the local variable at a specific index onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloca(this ILGenerator ilGenerator, short arg) {
			ilGenerator.Emit(OpCodes.Ldloca, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Loads the address of the local variable at a specific index onto the evaluation stack, short form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldloca_S(this ILGenerator ilGenerator, byte arg) {
			ilGenerator.Emit(OpCodes.Ldloca_S, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a null reference (type O) onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldnull(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldnull);
			return ilGenerator;
		}

		/// <summary>
		/// Copies the value type object pointed to by an address to the top of the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldobj(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Ldobj, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Copies the value type object pointed to by an address to the top of the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldobj<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldobj, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the value of a static field onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldsfld(this ILGenerator ilGenerator, FieldInfo field) {
			ilGenerator.Emit(OpCodes.Ldsfld, field);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the address of a static field onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldsflda(this ILGenerator ilGenerator, FieldInfo field) {
			ilGenerator.Emit(OpCodes.Ldsflda, field);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a new object reference to a string literal stored in the metadata.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldstr(this ILGenerator ilGenerator, string str) {
			ilGenerator.Emit(OpCodes.Ldstr, str);
			return ilGenerator;
		}

		/// <summary>
		/// Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldtoken(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Ldtoken, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldtoken<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ldtoken, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldtoken(this ILGenerator ilGenerator, MethodInfo meth) {
			ilGenerator.Emit(OpCodes.Ldtoken, meth);
			return ilGenerator;
		}

		/// <summary>
		/// Converts a metadata token to its runtime representation, pushing it onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldtoken(this ILGenerator ilGenerator, FieldInfo field) {
			ilGenerator.Emit(OpCodes.Ldtoken, field);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes an unmanaged pointer (type native int) to the native code implementing a particular virtual method associated with a specified object onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ldvirtftn(this ILGenerator ilGenerator, MethodInfo meth) {
			ilGenerator.Emit(OpCodes.Ldvirtftn, meth);
			return ilGenerator;
		}

		/// <summary>
		/// Exits a protected region of code, unconditionally transferring control to a specific target instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Leave(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Leave, label);
			return ilGenerator;
		}

		/// <summary>
		/// Exits a protected region of code, unconditionally transferring control to a specific target instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Leave(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Leave, label);
			return ilGenerator;
		}

		/// <summary>
		/// Exits a protected region of code, unconditionally transferring control to a target instruction (short form).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Leave_S(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Leave_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Exits a protected region of code, unconditionally transferring control to a target instruction (short form).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Leave_S(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Leave_S, label);
			return ilGenerator;
		}

		/// <summary>
		/// Allocates a certain number of bytes from the local dynamic memory pool and pushes the address (a transient pointer, type *) of the first allocated byte onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Localloc(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Localloc);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a typed reference to an instance of a specific type onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Mkrefany(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Mkrefany, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes a typed reference to an instance of a specific type onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Mkrefany<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Mkrefany, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Multiplies two values and pushes the result on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Mul(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Mul);
			return ilGenerator;
		}

		/// <summary>
		/// Multiplies two integer values, performs an overflow check, and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Mul_Ovf(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Mul_Ovf);
			return ilGenerator;
		}

		/// <summary>
		/// Multiplies two unsigned integer values, performs an overflow check, and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Mul_Ovf_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Mul_Ovf_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Negates a value and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Neg(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Neg);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Newarr(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Newarr, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes an object reference to a new zero-based, one-dimensional array whose elements are of a specific type onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Newarr<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Newarr, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Creates a new object or a new instance of a value type, pushing an object reference (type O) onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Newobj(this ILGenerator ilGenerator, ConstructorInfo con) {
			ilGenerator.Emit(OpCodes.Newobj, con);
			return ilGenerator;
		}

		/// <summary>
		/// Fills space if opcodes are patched. No meaningful operation is performed although a processing cycle can be consumed.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Nop(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Nop);
			return ilGenerator;
		}

		/// <summary>
		/// Computes the bitwise complement of the integer value on top of the stack and pushes the result onto the evaluation stack as the same type.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Not(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Not);
			return ilGenerator;
		}

		/// <summary>
		/// Compute the bitwise complement of the two integer values on top of the stack and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Or(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Or);
			return ilGenerator;
		}

		/// <summary>
		/// Removes the value currently on top of the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Pop(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Pop);
			return ilGenerator;
		}

		/// <summary>
		/// Retrieves the type token embedded in a typed reference.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Refanytype(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Refanytype);
			return ilGenerator;
		}

		/// <summary>
		/// Retrieves the address (type &) embedded in a typed reference.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Refanyval(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Refanyval, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Retrieves the address (type &) embedded in a typed reference.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Refanyval<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Refanyval, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Divides two values and pushes the remainder onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Rem(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Rem);
			return ilGenerator;
		}

		/// <summary>
		/// Divides two unsigned values and pushes the remainder onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Rem_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Rem_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the caller's evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Ret(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Ret);
			return ilGenerator;
		}

		/// <summary>
		/// Rethrows the current exception.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Rethrow(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Rethrow);
			return ilGenerator;
		}

		/// <summary>
		/// Shifts an integer value to the left (in zeroes) by a specified number of bits, pushing the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Shl(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Shl);
			return ilGenerator;
		}

		/// <summary>
		/// Shifts an integer value (in sign) to the right by a specified number of bits, pushing the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Shr(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Shr);
			return ilGenerator;
		}

		/// <summary>
		/// Shifts an unsigned integer value (in zeroes) to the right by a specified number of bits, pushing the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Shr_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Shr_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the size, in bytes, of a supplied value type onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Sizeof(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Sizeof, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Pushes the size, in bytes, of a supplied value type onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Sizeof<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Sizeof, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Stores the value on top of the evaluation stack in the argument slot at a specified index.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Starg(this ILGenerator ilGenerator, short arg) {
			ilGenerator.Emit(OpCodes.Starg, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Stores the value on top of the evaluation stack in the argument slot at a specified index, short form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Starg_S(this ILGenerator ilGenerator, byte arg) {
			ilGenerator.Emit(OpCodes.Starg_S, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Stelem, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the value on the evaluation stack, whose type is specified in the instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the native int value on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem_I(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem_I);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the int8 value on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem_I1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem_I1);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the int16 value on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem_I2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem_I2);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the int32 value on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem_I4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem_I4);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the int64 value on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem_I8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem_I8);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the float32 value on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem_R4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem_R4);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the float64 value on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem_R8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem_R8);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the array element at a given index with the object ref value (type O) on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stelem_Ref(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stelem_Ref);
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the value stored in the field of an object reference or pointer with a new value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stfld(this ILGenerator ilGenerator, FieldInfo field) {
			ilGenerator.Emit(OpCodes.Stfld, field);
			return ilGenerator;
		}

		/// <summary>
		/// Stores a value of type native int at a supplied address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stind_I(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stind_I);
			return ilGenerator;
		}

		/// <summary>
		/// Stores a value of type int8 at a supplied address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stind_I1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stind_I1);
			return ilGenerator;
		}

		/// <summary>
		/// Stores a value of type int16 at a supplied address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stind_I2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stind_I2);
			return ilGenerator;
		}

		/// <summary>
		/// Stores a value of type int32 at a supplied address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stind_I4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stind_I4);
			return ilGenerator;
		}

		/// <summary>
		/// Stores a value of type int64 at a supplied address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stind_I8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stind_I8);
			return ilGenerator;
		}

		/// <summary>
		/// Stores a value of type float32 at a supplied address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stind_R4(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stind_R4);
			return ilGenerator;
		}

		/// <summary>
		/// Stores a value of type float64 at a supplied address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stind_R8(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stind_R8);
			return ilGenerator;
		}

		/// <summary>
		/// Stores a object reference value at a supplied address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stind_Ref(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stind_Ref);
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc(this ILGenerator ilGenerator, LocalBuilder local) {
			ilGenerator.Emit(OpCodes.Stloc, local);
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc(this ILGenerator ilGenerator, short arg) {
			ilGenerator.Emit(OpCodes.Stloc, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at a specified index.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc_X(this ILGenerator ilGenerator, short arg) {
			switch (arg) {
				case 0: ilGenerator.Emit(OpCodes.Stloc_0); break;
				case 1: ilGenerator.Emit(OpCodes.Stloc_1); break;
				case 2: ilGenerator.Emit(OpCodes.Stloc_2); break;
				case 3: ilGenerator.Emit(OpCodes.Stloc_3); break;
				default: ilGenerator.Emit(OpCodes.Stloc, arg); break;
			}
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 0.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc_0(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stloc_0);
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 1.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc_1(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stloc_1);
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 2.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc_2(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stloc_2);
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index 3.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc_3(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stloc_3);
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc_S(this ILGenerator ilGenerator, LocalBuilder local) {
			ilGenerator.Emit(OpCodes.Stloc_S, local);
			return ilGenerator;
		}

		/// <summary>
		/// Pops the current value from the top of the evaluation stack and stores it in a the local variable list at index (short form).
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stloc_S(this ILGenerator ilGenerator, byte arg) {
			ilGenerator.Emit(OpCodes.Stloc_S, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Copies a value of a specified type from the evaluation stack into a supplied memory address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stobj(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Stobj, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Copies a value of a specified type from the evaluation stack into a supplied memory address.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stobj<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Stobj, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Replaces the value of a static field with a value from the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Stsfld(this ILGenerator ilGenerator, FieldInfo field) {
			ilGenerator.Emit(OpCodes.Stsfld, field);
			return ilGenerator;
		}

		/// <summary>
		/// Subtracts one value from another and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Sub(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Sub);
			return ilGenerator;
		}

		/// <summary>
		/// Subtracts one integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Sub_Ovf(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Sub_Ovf);
			return ilGenerator;
		}

		/// <summary>
		/// Subtracts one unsigned integer value from another, performs an overflow check, and pushes the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Sub_Ovf_Un(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Sub_Ovf_Un);
			return ilGenerator;
		}

		/// <summary>
		/// Implements a jump table.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Switch(this ILGenerator ilGenerator, params Label[] labels) {
			ilGenerator.Emit(OpCodes.Switch, labels);
			return ilGenerator;
		}

		/// <summary>
		/// Implements a jump table.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Switch(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Switch, label);
			return ilGenerator;
		}

		/// <summary>
		/// Implements a jump table.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Switch(this ILGenerator ilGenerator, out Label label1, out Label label2) {
			Label[] labels = {
				label1 = ilGenerator.DefineLabel(),
				label2 = ilGenerator.DefineLabel()
			};
			ilGenerator.Emit(OpCodes.Switch, labels);
			return ilGenerator;
		}

		/// <summary>
		/// Implements a jump table.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Switch(this ILGenerator ilGenerator, out Label label1, out Label label2, out Label label3) {
			Label[] labels = {
				label1 = ilGenerator.DefineLabel(),
				label2 = ilGenerator.DefineLabel(),
				label3 = ilGenerator.DefineLabel()
			};
			ilGenerator.Emit(OpCodes.Switch, labels);
			return ilGenerator;
		}

		/// <summary>
		/// Implements a jump table.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Switch(this ILGenerator ilGenerator, out Label label1, out Label label2, out Label label3, out Label label4) {
			Label[] labels = {
				label1 = ilGenerator.DefineLabel(),
				label2 = ilGenerator.DefineLabel(),
				label3 = ilGenerator.DefineLabel(),
				label4 = ilGenerator.DefineLabel()
			};
			ilGenerator.Emit(OpCodes.Switch, labels);
			return ilGenerator;
		}

		/// <summary>
		/// Implements a jump table.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Switch(this ILGenerator ilGenerator, out Label label1, out Label label2, out Label label3, out Label label4, out Label label5) {
			Label[] labels = {
				label1 = ilGenerator.DefineLabel(),
				label2 = ilGenerator.DefineLabel(),
				label3 = ilGenerator.DefineLabel(),
				label4 = ilGenerator.DefineLabel(),
				label5 = ilGenerator.DefineLabel()
			};
			ilGenerator.Emit(OpCodes.Switch, labels);
			return ilGenerator;
		}

		/// <summary>
		/// Implements a jump table.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Switch(this ILGenerator ilGenerator, out Label label1, out Label label2, out Label label3, out Label label4, out Label label5, out Label label6) {
			Label[] labels = {
				label1 = ilGenerator.DefineLabel(),
				label2 = ilGenerator.DefineLabel(),
				label3 = ilGenerator.DefineLabel(),
				label4 = ilGenerator.DefineLabel(),
				label5 = ilGenerator.DefineLabel(),
				label6 = ilGenerator.DefineLabel()
			};
			ilGenerator.Emit(OpCodes.Switch, labels);
			return ilGenerator;
		}

		/// <summary>
		/// Performs a postfixed method call instruction such that the current method's stack frame is removed before the actual call instruction is executed.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Tailcall(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Tailcall);
			return ilGenerator;
		}

		/// <summary>
		/// Throws the exception object currently on the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Throw(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Throw);
			return ilGenerator;
		}

		/// <summary>
		/// Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Unaligned(this ILGenerator ilGenerator, Label label) {
			ilGenerator.Emit(OpCodes.Unaligned, label);
			return ilGenerator;
		}

		/// <summary>
		/// Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Unaligned(this ILGenerator ilGenerator, out Label label) {
			label = ilGenerator.DefineLabel();
			ilGenerator.Emit(OpCodes.Unaligned, label);
			return ilGenerator;
		}

		/// <summary>
		/// Indicates that an address currently atop the evaluation stack might not be aligned to the natural size of the immediately following ldind, stind, ldfld, stfld, ldobj, stobj, initblk, or cpblk instruction.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Unaligned(this ILGenerator ilGenerator, byte arg) {
			ilGenerator.Emit(OpCodes.Unaligned, arg);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the boxed representation of a value type to its unboxed form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Unbox(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Unbox, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the boxed representation of a value type to its unboxed form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Unbox<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Unbox, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Converts the boxed representation of a type specified in the instruction to its unboxed form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Unbox_Any(this ILGenerator ilGenerator, Type cls) {
			ilGenerator.Emit(OpCodes.Unbox_Any, cls);
			return ilGenerator;
		}

		/// <summary>
		/// Converts the boxed representation of a type specified in the instruction to its unboxed form.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Unbox_Any<T>(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Unbox_Any, typeof(T));
			return ilGenerator;
		}

		/// <summary>
		/// Specifies that an address currently atop the evaluation stack might be volatile, and the results of reading that location cannot be cached or that multiple stores to that location cannot be suppressed.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Volatile(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Volatile);
			return ilGenerator;
		}

		/// <summary>
		/// Computes the bitwise XOR of the top two values on the evaluation stack, pushing the result onto the evaluation stack.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ILGenerator Xor(this ILGenerator ilGenerator) {
			ilGenerator.Emit(OpCodes.Xor);
			return ilGenerator;
		}
	}
}
