using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Uskr.Attributes;
using Uskr.Core;
using Uskr.IR;

namespace Uskr.Opcodes
{
    [Handler(Code.Ldnull)]
    public class Ldnull : IOpcodeProcessor
    {
        public void Handel(IRAssembly assembly, IRMethod meth, UskrContext context, Instruction instruction)
        {
                                    context.Asm($"push -1");

        }
    }
}