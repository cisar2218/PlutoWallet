//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace PlutoWallet.NetApiExt.Generated.Model.sp_runtime
{
    
    
    public enum MultiSigner
    {
        
        Ed25519 = 0,
        
        Sr25519 = 1,
        
        Ecdsa = 2,
    }
    
    /// <summary>
    /// >> 417 - Variant[sp_runtime.MultiSigner]
    /// </summary>
    public sealed class EnumMultiSigner : BaseEnumExt<MultiSigner, PlutoWallet.NetApiExt.Generated.Model.sp_core.ed25519.Public, PlutoWallet.NetApiExt.Generated.Model.sp_core.sr25519.Public, PlutoWallet.NetApiExt.Generated.Model.sp_core.ecdsa.Public>
    {
    }
}
