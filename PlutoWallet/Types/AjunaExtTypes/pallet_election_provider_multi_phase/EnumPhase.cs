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


namespace PlutoWallet.NetApiExt.Generated.Model.pallet_election_provider_multi_phase
{
    
    
    public enum Phase
    {
        
        Off = 0,
        
        Signed = 1,
        
        Unsigned = 2,
        
        Emergency = 3,
    }
    
    /// <summary>
    /// >> 600 - Variant[pallet_election_provider_multi_phase.Phase]
    /// </summary>
    public sealed class EnumPhase : BaseEnumExt<Phase, BaseVoid, BaseVoid, Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.Bool, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseVoid>
    {
    }
}
