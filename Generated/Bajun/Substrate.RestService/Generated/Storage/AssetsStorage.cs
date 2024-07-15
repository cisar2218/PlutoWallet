//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IAssetsStorage interface definition.
    /// </summary>
    public interface IAssetsStorage : IStorage
    {
        
        /// <summary>
        /// >> Asset
        ///  Details of an asset.
        /// </summary>
        Bajun.NetApi.Generated.Model.pallet_assets.types.AssetDetails GetAsset(string key);
        
        /// <summary>
        /// >> Account
        ///  The holdings of a specific account for a specific asset.
        /// </summary>
        Bajun.NetApi.Generated.Model.pallet_assets.types.AssetAccount GetAccount(string key);
        
        /// <summary>
        /// >> Approvals
        ///  Approved balance transfers. First balance is the amount approved for transfer. Second
        ///  is the amount of `T::Currency` reserved for storing this.
        ///  First key is the asset ID, second key is the owner and third key is the delegate.
        /// </summary>
        Bajun.NetApi.Generated.Model.pallet_assets.types.Approval GetApprovals(string key);
        
        /// <summary>
        /// >> Metadata
        ///  Metadata of an asset.
        /// </summary>
        Bajun.NetApi.Generated.Model.pallet_assets.types.AssetMetadata GetMetadata(string key);
    }
    
    /// <summary>
    /// AssetsStorage class definition.
    /// </summary>
    public sealed class AssetsStorage : IAssetsStorage
    {
        
        /// <summary>
        /// _assetTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetDetails> _assetTypedStorage;
        
        /// <summary>
        /// _accountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetAccount> _accountTypedStorage;
        
        /// <summary>
        /// _approvalsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.Approval> _approvalsTypedStorage;
        
        /// <summary>
        /// _metadataTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetMetadata> _metadataTypedStorage;
        
        /// <summary>
        /// AssetsStorage constructor.
        /// </summary>
        public AssetsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.AssetTypedStorage = new TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetDetails>("Assets.Asset", storageDataProvider, storageChangeDelegates);
            this.AccountTypedStorage = new TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetAccount>("Assets.Account", storageDataProvider, storageChangeDelegates);
            this.ApprovalsTypedStorage = new TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.Approval>("Assets.Approvals", storageDataProvider, storageChangeDelegates);
            this.MetadataTypedStorage = new TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetMetadata>("Assets.Metadata", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _assetTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetDetails> AssetTypedStorage
        {
            get
            {
                return _assetTypedStorage;
            }
            set
            {
                _assetTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _accountTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetAccount> AccountTypedStorage
        {
            get
            {
                return _accountTypedStorage;
            }
            set
            {
                _accountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _approvalsTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.Approval> ApprovalsTypedStorage
        {
            get
            {
                return _approvalsTypedStorage;
            }
            set
            {
                _approvalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _metadataTypedStorage property
        /// </summary>
        public TypedMapStorage<Bajun.NetApi.Generated.Model.pallet_assets.types.AssetMetadata> MetadataTypedStorage
        {
            get
            {
                return _metadataTypedStorage;
            }
            set
            {
                _metadataTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AssetTypedStorage.InitializeAsync("Assets", "Asset");
            await AccountTypedStorage.InitializeAsync("Assets", "Account");
            await ApprovalsTypedStorage.InitializeAsync("Assets", "Approvals");
            await MetadataTypedStorage.InitializeAsync("Assets", "Metadata");
        }
        
        /// <summary>
        /// Implements any storage change for Assets.Asset
        /// </summary>
        [StorageChange("Assets", "Asset")]
        public void OnUpdateAsset(string key, string data)
        {
            AssetTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Asset
        ///  Details of an asset.
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_assets.types.AssetDetails GetAsset(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AssetTypedStorage.Dictionary.TryGetValue(key, out Bajun.NetApi.Generated.Model.pallet_assets.types.AssetDetails result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Assets.Account
        /// </summary>
        [StorageChange("Assets", "Account")]
        public void OnUpdateAccount(string key, string data)
        {
            AccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Account
        ///  The holdings of a specific account for a specific asset.
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_assets.types.AssetAccount GetAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountTypedStorage.Dictionary.TryGetValue(key, out Bajun.NetApi.Generated.Model.pallet_assets.types.AssetAccount result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Assets.Approvals
        /// </summary>
        [StorageChange("Assets", "Approvals")]
        public void OnUpdateApprovals(string key, string data)
        {
            ApprovalsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Approvals
        ///  Approved balance transfers. First balance is the amount approved for transfer. Second
        ///  is the amount of `T::Currency` reserved for storing this.
        ///  First key is the asset ID, second key is the owner and third key is the delegate.
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_assets.types.Approval GetApprovals(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ApprovalsTypedStorage.Dictionary.TryGetValue(key, out Bajun.NetApi.Generated.Model.pallet_assets.types.Approval result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Assets.Metadata
        /// </summary>
        [StorageChange("Assets", "Metadata")]
        public void OnUpdateMetadata(string key, string data)
        {
            MetadataTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Metadata
        ///  Metadata of an asset.
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_assets.types.AssetMetadata GetMetadata(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MetadataTypedStorage.Dictionary.TryGetValue(key, out Bajun.NetApi.Generated.Model.pallet_assets.types.AssetMetadata result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}