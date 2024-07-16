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


namespace Polkadot.NetApi.Generated.Model.polkadot_primitives.v6
{
    
    
    /// <summary>
    /// >> 340 - Composite[polkadot_primitives.v6.BackedCandidate]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BackedCandidate : BaseType
    {
        
        /// <summary>
        /// >> candidate
        /// </summary>
        public Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CommittedCandidateReceipt Candidate { get; set; }
        /// <summary>
        /// >> validity_votes
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.EnumValidityAttestation> ValidityVotes { get; set; }
        /// <summary>
        /// >> validator_indices
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Polkadot.NetApi.Generated.Model.bitvec.order.Lsb0> ValidatorIndices { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "BackedCandidate";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Candidate.Encode());
            result.AddRange(ValidityVotes.Encode());
            result.AddRange(ValidatorIndices.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Candidate = new Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.CommittedCandidateReceipt();
            Candidate.Decode(byteArray, ref p);
            ValidityVotes = new Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.EnumValidityAttestation>();
            ValidityVotes.Decode(byteArray, ref p);
            ValidatorIndices = new Substrate.NetApi.Model.Types.Base.BaseBitSeq<Substrate.NetApi.Model.Types.Primitive.U8, Polkadot.NetApi.Generated.Model.bitvec.order.Lsb0>();
            ValidatorIndices.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
