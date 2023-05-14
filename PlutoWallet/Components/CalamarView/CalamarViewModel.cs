﻿using System;
using PlutoWallet.Model;
using PlutoWallet.Constants;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PlutoWallet.Components.CalamarView
{
	public partial class CalamarViewModel : ObservableObject
	{
		[ObservableProperty]
		private string webAddress;

		public CalamarViewModel()
		{

		}

		public void Reload()
		{
			string address = KeysModel.GetPublicKey();
			Endpoint endpoint = Model.AjunaClientModel.SelectedEndpoint;

			if (endpoint.CalamarChainName == null)
			{
                // Not supported
            }

            WebAddress = "https://f4c3cf83.calamar.pages.dev/" + endpoint.CalamarChainName + "/account/" + address;
        }
	}
}
