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


namespace Hydration.NetApi.Generated.Model.pallet_omnipool.types
{
    
    
    /// <summary>
    /// >> 495 - Composite[pallet_omnipool.types.Position]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Position : BaseType
    {
        
        /// <summary>
        /// >> asset_id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AssetId { get; set; }
        /// <summary>
        /// >> amount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount { get; set; }
        /// <summary>
        /// >> shares
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Shares { get; set; }
        /// <summary>
        /// >> price
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128> Price { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Position";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AssetId.Encode());
            result.AddRange(Amount.Encode());
            result.AddRange(Shares.Encode());
            result.AddRange(Price.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AssetId = new Substrate.NetApi.Model.Types.Primitive.U32();
            AssetId.Decode(byteArray, ref p);
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Shares = new Substrate.NetApi.Model.Types.Primitive.U128();
            Shares.Decode(byteArray, ref p);
            Price = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>();
            Price.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}