//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.frame_system.extensions.check_genesis
{
    
    
    /// <summary>
    /// >> 732 - Composite[frame_system.extensions.check_genesis.CheckGenesis]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class CheckGenesis : BaseType
    {
        
        public override string TypeName()
        {
            return "CheckGenesis";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TypeSize = p - start;
        }
    }
}
