using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Uskr.Attributes;
using Uskr.Core;
using Uskr.IR;

namespace Uskr.Opcodes
{
    [Handler(Code.Stind_R8)]
    public class Stind_R8 : IOpcodeProcessor
    {
        public void Handel(IRAssembly assembly, IRMethod meth, UskrContext context, Instruction instruction)
        {
                                    context.Asm("pop eax"); //value
                        context.Asm("pop ebx"); //adress
                        context.Asm("mov [ebx],  eax");

        }
    }
}