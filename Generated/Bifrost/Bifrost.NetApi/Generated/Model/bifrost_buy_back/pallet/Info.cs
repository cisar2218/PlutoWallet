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


namespace Bifrost.NetApi.Generated.Model.bifrost_buy_back.pallet
{
    
    
    /// <summary>
    /// >> 508 - Composite[bifrost_buy_back.pallet.Info]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Info : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Value { get; set; }
        /// <summary>
        /// >> if_auto
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool IfAuto { get; set; }
        /// <summary>
        /// >> proportion
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill Proportion { get; set; }
        /// <summary>
        /// >> buyback_duration
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 BuybackDuration { get; set; }
        /// <summary>
        /// >> last_buyback
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LastBuyback { get; set; }
        /// <summary>
        /// >> add_liquidity_duration
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AddLiquidityDuration { get; set; }
        /// <summary>
        /// >> last_add_liquidity
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 LastAddLiquidity { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Info";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            result.AddRange(IfAuto.Encode());
            result.AddRange(Proportion.Encode());
            result.AddRange(BuybackDuration.Encode());
            result.AddRange(LastBuyback.Encode());
            result.AddRange(AddLiquidityDuration.Encode());
            result.AddRange(LastAddLiquidity.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Substrate.NetApi.Model.Types.Primitive.U128();
            Value.Decode(byteArray, ref p);
            IfAuto = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IfAuto.Decode(byteArray, ref p);
            Proportion = new Bifrost.NetApi.Generated.Model.sp_arithmetic.per_things.Permill();
            Proportion.Decode(byteArray, ref p);
            BuybackDuration = new Substrate.NetApi.Model.Types.Primitive.U32();
            BuybackDuration.Decode(byteArray, ref p);
            LastBuyback = new Substrate.NetApi.Model.Types.Primitive.U32();
            LastBuyback.Decode(byteArray, ref p);
            AddLiquidityDuration = new Substrate.NetApi.Model.Types.Primitive.U32();
            AddLiquidityDuration.Decode(byteArray, ref p);
            LastAddLiquidity = new Substrate.NetApi.Model.Types.Primitive.U32();
            LastAddLiquidity.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}