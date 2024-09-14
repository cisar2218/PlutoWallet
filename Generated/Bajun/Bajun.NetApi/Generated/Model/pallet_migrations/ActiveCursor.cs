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


namespace Bajun.NetApi.Generated.Model.pallet_migrations
{
    
    
    /// <summary>
    /// >> 334 - Composite[pallet_migrations.ActiveCursor]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ActiveCursor : BaseType
    {
        
        /// <summary>
        /// >> index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Index { get; set; }
        /// <summary>
        /// >> inner_cursor
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16> InnerCursor { get; set; }
        /// <summary>
        /// >> started_at
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 StartedAt { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ActiveCursor";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Index.Encode());
            result.AddRange(InnerCursor.Encode());
            result.AddRange(StartedAt.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Index = new Substrate.NetApi.Model.Types.Primitive.U32();
            Index.Decode(byteArray, ref p);
            InnerCursor = new Substrate.NetApi.Model.Types.Base.BaseOpt<Bajun.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT16>();
            InnerCursor.Decode(byteArray, ref p);
            StartedAt = new Substrate.NetApi.Model.Types.Primitive.U32();
            StartedAt.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
