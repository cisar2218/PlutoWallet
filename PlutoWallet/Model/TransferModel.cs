﻿using System;
using System.Linq;
using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using Newtonsoft.Json;
using PlutoWallet.Model.AjunaExt;
using PlutoWallet.NetApiExt.Generated.Model.sp_core.crypto;
using PlutoWallet.NetApiExt.Generated.Model.sp_runtime.multiaddress;
using PlutoWallet.Types;

namespace PlutoWallet.Model
{
	public class TransferModel
	{

		public static async Task BalancesTransferAsync(string address, CompactInteger amount)
		{
            // Recognize what type of the address it is and convert it into ss58 one



            // transfer
            var accountId = new AccountId32();
            accountId.Create(Utils.GetPublicKeyFrom(address));

            var multiAddress = new EnumMultiAddress();
            multiAddress.Create(0, accountId);

            var baseComAmount = new BaseCom<U128>();
            baseComAmount.Create(amount);

            var client = Model.AjunaClientModel.Client;

            var (palletIndex, callIndex) = PalletCallModel.GetPalletAndCallIndex(client, "Balances", "transfer");

            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(multiAddress.Encode());
            byteArray.AddRange(baseComAmount.Encode());
            Method transfer = new Method(palletIndex, "Balances", callIndex, "transfer", byteArray.ToArray());

            var charge = ChargeTransactionPayment.Default();

            UnCheckedExtrinsic extrinsic = await client.GetExtrinsicParametersAsync(
                transfer,
                KeysModel.GetAccount(),
                charge,
                lifeTime: 64,
                signed: true,
                CancellationToken.None);

            await client.Author.SubmitExtrinsicAsync(Utils.Bytes2HexString(extrinsic.Encode()), CancellationToken.None);
        } 
	}
}

