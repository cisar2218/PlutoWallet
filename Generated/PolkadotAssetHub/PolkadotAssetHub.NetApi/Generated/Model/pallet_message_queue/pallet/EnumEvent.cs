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


namespace PolkadotAssetHub.NetApi.Generated.Model.pallet_message_queue.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> ProcessingFailed
        /// Message discarded due to an error in the `MessageProcessor` (usually a format error).
        /// </summary>
        ProcessingFailed = 0,
        
        /// <summary>
        /// >> Processed
        /// Message is processed.
        /// </summary>
        Processed = 1,
        
        /// <summary>
        /// >> OverweightEnqueued
        /// Message placed in overweight queue.
        /// </summary>
        OverweightEnqueued = 2,
        
        /// <summary>
        /// >> PageReaped
        /// This page was reaped.
        /// </summary>
        PageReaped = 3,
    }
    
    /// <summary>
    /// >> 118 - Variant[pallet_message_queue.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.primitive_types.H256, PolkadotAssetHub.NetApi.Generated.Model.cumulus_primitives_core.EnumAggregateMessageOrigin, PolkadotAssetHub.NetApi.Generated.Model.frame_support.traits.messages.EnumProcessMessageError>>(Event.ProcessingFailed);
				AddTypeDecoder<BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.primitive_types.H256, PolkadotAssetHub.NetApi.Generated.Model.cumulus_primitives_core.EnumAggregateMessageOrigin, PolkadotAssetHub.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.Bool>>(Event.Processed);
				AddTypeDecoder<BaseTuple<PolkadotAssetHub.NetApi.Generated.Types.Base.Arr32U8, PolkadotAssetHub.NetApi.Generated.Model.cumulus_primitives_core.EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.OverweightEnqueued);
				AddTypeDecoder<BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.cumulus_primitives_core.EnumAggregateMessageOrigin, Substrate.NetApi.Model.Types.Primitive.U32>>(Event.PageReaped);
        }
    }
}
