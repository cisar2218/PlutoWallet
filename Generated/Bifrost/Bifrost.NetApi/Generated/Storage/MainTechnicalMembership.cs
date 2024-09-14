//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Bifrost.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> TechnicalMembershipStorage
    /// </summary>
    public sealed class TechnicalMembershipStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> TechnicalMembershipStorage Constructor
        /// </summary>
        public TechnicalMembershipStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TechnicalMembership", "Members"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT24)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TechnicalMembership", "Prime"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public static string MembersParams()
        {
            return RequestGenerator.GetStorage("TechnicalMembership", "Members", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MembersDefault
        /// Default value as hex string
        /// </summary>
        public static string MembersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public async Task<Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT24> Members(string blockhash, CancellationToken token)
        {
            string parameters = TechnicalMembershipStorage.MembersParams();
            var result = await _client.GetStorageAsync<Bifrost.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT24>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PrimeParams
        ///  The current prime member, if one exists.
        /// </summary>
        public static string PrimeParams()
        {
            return RequestGenerator.GetStorage("TechnicalMembership", "Prime", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> PrimeDefault
        /// Default value as hex string
        /// </summary>
        public static string PrimeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        public async Task<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32> Prime(string blockhash, CancellationToken token)
        {
            string parameters = TechnicalMembershipStorage.PrimeParams();
            var result = await _client.GetStorageAsync<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> TechnicalMembershipCalls
    /// </summary>
    public sealed class TechnicalMembershipCalls
    {
        
        /// <summary>
        /// >> add_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AddMember(Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(35, "TechnicalMembership", 0, "add_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RemoveMember(Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(35, "TechnicalMembership", 1, "remove_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> swap_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SwapMember(Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress remove, Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress add)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(remove.Encode());
            byteArray.AddRange(add.Encode());
            return new Method(35, "TechnicalMembership", 2, "swap_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reset_members
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ResetMembers(Substrate.NetApi.Model.Types.Base.BaseVec<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32> members)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(members.Encode());
            return new Method(35, "TechnicalMembership", 3, "reset_members", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> change_key
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ChangeKey(Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(35, "TechnicalMembership", 4, "change_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_prime
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetPrime(Bifrost.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(35, "TechnicalMembership", 5, "set_prime", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_prime
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ClearPrime()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(35, "TechnicalMembership", 6, "clear_prime", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> TechnicalMembershipConstants
    /// </summary>
    public sealed class TechnicalMembershipConstants
    {
    }
    
    /// <summary>
    /// >> TechnicalMembershipErrors
    /// </summary>
    public enum TechnicalMembershipErrors
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> TooManyMembers
        /// Too many members.
        /// </summary>
        TooManyMembers,
    }
}
