//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Opal.NetApi.Generated.Model.frame_system
{
    
    
    /// <summary>
    /// >> Phase
    /// </summary>
    public enum Phase
    {
        
        /// <summary>
        /// >> ApplyExtrinsic
        /// </summary>
        ApplyExtrinsic = 0,
        
        /// <summary>
        /// >> Finalization
        /// </summary>
        Finalization = 1,
        
        /// <summary>
        /// >> Initialization
        /// </summary>
        Initialization = 2,
    }
    
    /// <summary>
    /// >> 388 - Variant[frame_system.Phase]
    /// </summary>
    public sealed class EnumPhase : BaseEnumRust<Phase>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumPhase()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Phase.ApplyExtrinsic);
				AddTypeDecoder<BaseVoid>(Phase.Finalization);
				AddTypeDecoder<BaseVoid>(Phase.Initialization);
        }
    }
}
