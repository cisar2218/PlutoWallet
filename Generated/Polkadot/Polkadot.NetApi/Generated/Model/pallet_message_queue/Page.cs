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


namespace Polkadot.NetApi.Generated.Model.pallet_message_queue
{
    
    
    /// <summary>
    /// >> 850 - Composite[pallet_message_queue.Page]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Page : BaseType
    {
        
        /// <summary>
        /// >> remaining
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Remaining { get; set; }
        /// <summary>
        /// >> remaining_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 RemainingSize { get; set; }
        /// <summary>
        /// >> first_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 FirstIndex { get; set; }
        /// <summary>
        /// >> first
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 First { get; set; }
        /// <summary>
        /// >> last
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Last { get; set; }
        /// <summary>
        /// >> heap
        /// </summary>
        public Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT44 Heap { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Page";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Remaining.Encode());
            result.AddRange(RemainingSize.Encode());
            result.AddRange(FirstIndex.Encode());
            result.AddRange(First.Encode());
            result.AddRange(Last.Encode());
            result.AddRange(Heap.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Remaining = new Substrate.NetApi.Model.Types.Primitive.U32();
            Remaining.Decode(byteArray, ref p);
            RemainingSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            RemainingSize.Decode(byteArray, ref p);
            FirstIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            FirstIndex.Decode(byteArray, ref p);
            First = new Substrate.NetApi.Model.Types.Primitive.U32();
            First.Decode(byteArray, ref p);
            Last = new Substrate.NetApi.Model.Types.Primitive.U32();
            Last.Decode(byteArray, ref p);
            Heap = new Polkadot.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT44();
            Heap.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
