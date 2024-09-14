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


namespace Hydration.NetApi.Generated.Model.pallet_duster.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Dusted
        /// Account dusted.
        /// </summary>
        Dusted = 0,
        
        /// <summary>
        /// >> Added
        /// Account added to non-dustable list.
        /// </summary>
        Added = 1,
        
        /// <summary>
        /// >> Removed
        /// Account removed from non-dustable list.
        /// </summary>
        Removed = 2,
    }
    
    /// <summary>
    /// >> 92 - Variant[pallet_duster.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.Dusted);
				AddTypeDecoder<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Event.Added);
				AddTypeDecoder<Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32>(Event.Removed);
        }
    }
}
