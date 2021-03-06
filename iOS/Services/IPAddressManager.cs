﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using GetIPAddress.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetIPAddress.iOSUnified.iOS.DependencyServices.IPAddressManager))]
namespace GetIPAddress.iOSUnified.iOS.DependencyServices
{
	class IPAddressManager : IIPAddressManager
	{
		public string GetIPAddress()
		{
			String ipAddress = "";

			foreach (var netInterface in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
					netInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
				{
					foreach (var addrInfo in netInterface.GetIPProperties().UnicastAddresses)
					{
						if (addrInfo.Address.AddressFamily == AddressFamily.InterNetwork)
						{
							ipAddress = addrInfo.Address.ToString();

						}
					}
				}
			}

			return ipAddress;
		}
	}
}