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


namespace InvArch.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> TxPauseStorage
    /// </summary>
    public sealed class TxPauseStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> TxPauseStorage Constructor
        /// </summary>
        public TxPauseStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TxPause", "PausedCalls"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1>), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple)));
        }
        
        /// <summary>
        /// >> PausedCallsParams
        ///  The set of calls that are explicitly paused.
        /// </summary>
        public static string PausedCallsParams(Substrate.NetApi.Model.Types.Base.BaseTuple<InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1> key)
        {
            return RequestGenerator.GetStorage("TxPause", "PausedCalls", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PausedCallsDefault
        /// Default value as hex string
        /// </summary>
        public static string PausedCallsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PausedCalls
        ///  The set of calls that are explicitly paused.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple> PausedCalls(Substrate.NetApi.Model.Types.Base.BaseTuple<InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1> key, string blockhash, CancellationToken token)
        {
            string parameters = TxPauseStorage.PausedCallsParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> TxPauseCalls
    /// </summary>
    public sealed class TxPauseCalls
    {
        
        /// <summary>
        /// >> pause
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Pause(Substrate.NetApi.Model.Types.Base.BaseTuple<InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1> full_name)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(full_name.Encode());
            return new Method(6, "TxPause", 0, "pause", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unpause
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Unpause(Substrate.NetApi.Model.Types.Base.BaseTuple<InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1, InvArch.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT1> ident)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(ident.Encode());
            return new Method(6, "TxPause", 1, "unpause", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> TxPauseConstants
    /// </summary>
    public sealed class TxPauseConstants
    {
        
        /// <summary>
        /// >> MaxNameLen
        ///  Maximum length for pallet name and call name SCALE encoded string names.
        /// 
        ///  TOO LONG NAMES WILL BE TREATED AS PAUSED.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxNameLen()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x32000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> TxPauseErrors
    /// </summary>
    public enum TxPauseErrors
    {
        
        /// <summary>
        /// >> IsPaused
        /// The call is paused.
        /// </summary>
        IsPaused,
        
        /// <summary>
        /// >> IsUnpaused
        /// The call is unpaused.
        /// </summary>
        IsUnpaused,
        
        /// <summary>
        /// >> Unpausable
        /// The call is whitelisted and cannot be paused.
        /// </summary>
        Unpausable,
        
        /// <summary>
        /// >> NotFound
        /// </summary>
        NotFound,
    }
}