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
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Hydration.NetApi.Generated.Model.pallet_liquidity_mining.types
{
    
    
    /// <summary>
    /// >> 574 - Composite[pallet_liquidity_mining.types.YieldFarmDataT1]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class YieldFarmDataT1 : BaseType
    {
        
        /// <summary>
        /// >> id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Id { get; set; }
        /// <summary>
        /// >> updated_at
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 UpdatedAt { get; set; }
        /// <summary>
        /// >> total_shares
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TotalShares { get; set; }
        /// <summary>
        /// >> total_valued_shares
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TotalValuedShares { get; set; }
        /// <summary>
        /// >> accumulated_rpvs
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 AccumulatedRpvs { get; set; }
        /// <summary>
        /// >> accumulated_rpz
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 AccumulatedRpz { get; set; }
        /// <summary>
        /// >> loyalty_curve
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.pallet_liquidity_mining.types.LoyaltyCurve> LoyaltyCurve { get; set; }
        /// <summary>
        /// >> multiplier
        /// </summary>
        public Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 Multiplier { get; set; }
        /// <summary>
        /// >> state
        /// </summary>
        public Hydration.NetApi.Generated.Model.pallet_liquidity_mining.types.EnumFarmState State { get; set; }
        /// <summary>
        /// >> entries_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 EntriesCount { get; set; }
        /// <summary>
        /// >> left_to_distribute
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 LeftToDistribute { get; set; }
        /// <summary>
        /// >> total_stopped
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 TotalStopped { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "YieldFarmDataT1";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(UpdatedAt.Encode());
            result.AddRange(TotalShares.Encode());
            result.AddRange(TotalValuedShares.Encode());
            result.AddRange(AccumulatedRpvs.Encode());
            result.AddRange(AccumulatedRpz.Encode());
            result.AddRange(LoyaltyCurve.Encode());
            result.AddRange(Multiplier.Encode());
            result.AddRange(State.Encode());
            result.AddRange(EntriesCount.Encode());
            result.AddRange(LeftToDistribute.Encode());
            result.AddRange(TotalStopped.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new Substrate.NetApi.Model.Types.Primitive.U32();
            Id.Decode(byteArray, ref p);
            UpdatedAt = new Substrate.NetApi.Model.Types.Primitive.U32();
            UpdatedAt.Decode(byteArray, ref p);
            TotalShares = new Substrate.NetApi.Model.Types.Primitive.U128();
            TotalShares.Decode(byteArray, ref p);
            TotalValuedShares = new Substrate.NetApi.Model.Types.Primitive.U128();
            TotalValuedShares.Decode(byteArray, ref p);
            AccumulatedRpvs = new Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            AccumulatedRpvs.Decode(byteArray, ref p);
            AccumulatedRpz = new Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            AccumulatedRpz.Decode(byteArray, ref p);
            LoyaltyCurve = new Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.pallet_liquidity_mining.types.LoyaltyCurve>();
            LoyaltyCurve.Decode(byteArray, ref p);
            Multiplier = new Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128();
            Multiplier.Decode(byteArray, ref p);
            State = new Hydration.NetApi.Generated.Model.pallet_liquidity_mining.types.EnumFarmState();
            State.Decode(byteArray, ref p);
            EntriesCount = new Substrate.NetApi.Model.Types.Primitive.U64();
            EntriesCount.Decode(byteArray, ref p);
            LeftToDistribute = new Substrate.NetApi.Model.Types.Primitive.U128();
            LeftToDistribute.Decode(byteArray, ref p);
            TotalStopped = new Substrate.NetApi.Model.Types.Primitive.U32();
            TotalStopped.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
