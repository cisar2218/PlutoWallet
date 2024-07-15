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


namespace Bifrost.NetApi.Generated.Model.zenlink_protocol.primitives
{
    
    
    /// <summary>
    /// >> 262 - Composite[zenlink_protocol.primitives.AssetId]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AssetId : BaseType
    {
        
        /// <summary>
        /// >> chain_id
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ChainId { get; set; }
        /// <summary>
        /// >> asset_type
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 AssetType { get; set; }
        /// <summary>
        /// >> asset_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 AssetIndex { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AssetId";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ChainId.Encode());
            result.AddRange(AssetType.Encode());
            result.AddRange(AssetIndex.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ChainId = new Substrate.NetApi.Model.Types.Primitive.U32();
            ChainId.Decode(byteArray, ref p);
            AssetType = new Substrate.NetApi.Model.Types.Primitive.U8();
            AssetType.Decode(byteArray, ref p);
            AssetIndex = new Substrate.NetApi.Model.Types.Primitive.U64();
            AssetIndex.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}