//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.pallet_nomination_pools
{
    
    
    /// <summary>
    /// >> 722 - Composite[pallet_nomination_pools.PoolMember]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PoolMember : BaseType
    {
        
        /// <summary>
        /// >> pool_id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 PoolId { get; set; }
        /// <summary>
        /// >> points
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Points { get; set; }
        /// <summary>
        /// >> last_recorded_reward_counter
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 LastRecordedRewardCounter { get; set; }
        /// <summary>
        /// >> unbonding_eras
        /// </summary>
        public Polkadot.NetApi.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMapT1 UnbondingEras { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PoolMember";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PoolId.Encode());
            result.AddRange(Points.Encode());
            result.AddRange(LastRecordedRewardCounter.Encode());
            result.AddRange(UnbondingEras.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PoolId = new Substrate.NetApi.Model.Types.Primitive.U32();
            PoolId.Decode(byteArray, ref p);
            Points = new Substrate.NetApi.Model.Types.Primitive.U128();
            Points.Decode(byteArray, ref p);
            LastRecordedRewardCounter = new Polkadot.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            LastRecordedRewardCounter.Decode(byteArray, ref p);
            UnbondingEras = new Polkadot.NetApi.Generated.Model.bounded_collections.bounded_btree_map.BoundedBTreeMapT1();
            UnbondingEras.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
