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


namespace Bajun.NetApi.Generated.Model.sp_runtime
{
    
    
    /// <summary>
    /// >> MultiSignature
    /// </summary>
    public enum MultiSignature
    {
        
        /// <summary>
        /// >> Ed25519
        /// </summary>
        Ed25519 = 0,
        
        /// <summary>
        /// >> Sr25519
        /// </summary>
        Sr25519 = 1,
        
        /// <summary>
        /// >> Ecdsa
        /// </summary>
        Ecdsa = 2,
    }
    
    /// <summary>
    /// >> 322 - Variant[sp_runtime.MultiSignature]
    /// </summary>
    public sealed class EnumMultiSignature : BaseEnumRust<MultiSignature>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumMultiSignature()
        {
				AddTypeDecoder<Bajun.NetApi.Generated.Types.Base.Arr64U8>(MultiSignature.Ed25519);
				AddTypeDecoder<Bajun.NetApi.Generated.Types.Base.Arr64U8>(MultiSignature.Sr25519);
				AddTypeDecoder<Bajun.NetApi.Generated.Types.Base.Arr65U8>(MultiSignature.Ecdsa);
        }
    }
}
