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


namespace Bifrost.NetApi.Generated.Model.pallet_democracy.vote
{
    
    
    /// <summary>
    /// >> Voting
    /// </summary>
    public enum Voting
    {
        
        /// <summary>
        /// >> Direct
        /// </summary>
        Direct = 0,
        
        /// <summary>
        /// >> Delegating
        /// </summary>
        Delegating = 1,
    }
    
    /// <summary>
    /// >> 592 - Variant[pallet_democracy.vote.Voting]
    /// </summary>
    public sealed class EnumVoting : BaseEnumExt<Voting, BaseTuple<Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19, Bifrost.NetApi.Generated.Model.pallet_democracy.types.Delegations, Bifrost.NetApi.Generated.Model.pallet_democracy.vote.PriorLock>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Bifrost.NetApi.Generated.Model.pallet_democracy.conviction.EnumConviction, Bifrost.NetApi.Generated.Model.pallet_democracy.types.Delegations, Bifrost.NetApi.Generated.Model.pallet_democracy.vote.PriorLock>>
    {
    }
}
