using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using GetIPAddress.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetIPAddress.Android.Android.DependencyServices.IPAddressManager))]

namespace GetIPAddress.Android.Android.DependencyServices
{
	class IPAddressManager : IIPAddressManager
	{
		public string GetIPAddress()
		{
			IPAddress[] adresses = Dns.GetHostAddresses(Dns.GetHostName());

			if (adresses !=null && adresses[0] != null)
			{
				return adresses[0].ToString();
			}
			else
			{
				return null;
			}
		}
	}
}