using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Uskr.Attributes;
using Uskr.Core;
using Uskr.IR;

namespace Uskr.Opcodes
{
    [Handler(Code.Blt_S)]
    public class Blt_S : IOpcodeProcessor
    {
        public void Handel(IRAssembly assembly, IRMethod meth, UskrContext context, Instruction instruction)
        {
                                    context.Asm("pop eax");
                        context.Asm("pop ebx");
                        context.Asm($"cmp eax, ebx");
                        context.Asm(
                            $"jl _{Utils.MD5(meth.Namespace)}_{(instruction.Operand as Instruction).Offset}");

        }
    }
}