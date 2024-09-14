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


namespace Bifrost.NetApi.Generated.Model.bifrost_vesting.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> VestingUpdated
        /// The amount vested has been updated. This could indicate a change in funds available.
        /// The balance given is the amount which is left unvested (and thus locked).
        /// </summary>
        VestingUpdated = 0,
        
        /// <summary>
        /// >> VestingCompleted
        /// An \[account\] has become fully vested.
        /// </summary>
        VestingCompleted = 1,
    }
    
    /// <summary>
    /// >> 472 - Variant[bifrost_vesting.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.VestingUpdated);
				AddTypeDecoder<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Event.VestingCompleted);
        }
    }
}
