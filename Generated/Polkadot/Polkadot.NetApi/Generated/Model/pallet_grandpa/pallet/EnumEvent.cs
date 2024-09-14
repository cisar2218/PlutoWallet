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


namespace Polkadot.NetApi.Generated.Model.pallet_grandpa.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> NewAuthorities
        /// New authority set has been applied.
        /// </summary>
        NewAuthorities = 0,
        
        /// <summary>
        /// >> Paused
        /// Current authority set has been paused.
        /// </summary>
        Paused = 1,
        
        /// <summary>
        /// >> Resumed
        /// Current authority set has been resumed.
        /// </summary>
        Resumed = 2,
    }
    
    /// <summary>
    /// >> 50 - Variant[pallet_grandpa.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Polkadot.NetApi.Generated.Model.sp_consensus_grandpa.app.Public, Substrate.NetApi.Model.Types.Primitive.U64>>>(Event.NewAuthorities);
				AddTypeDecoder<BaseVoid>(Event.Paused);
				AddTypeDecoder<BaseVoid>(Event.Resumed);
        }
    }
}
