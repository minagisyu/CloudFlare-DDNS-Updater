using System.Net;

namespace CloudFlareDDNS.Classes
{
	struct InterfaceAdapter
	{
		public string Name { get; set; }
		public IPAddress Address { get; set; }

		public override string ToString() => $"{Name} [{Address}]";

		public InterfaceAdapter(string name, IPAddress address)
		{
			this.Name = name;
			this.Address = address;
		}
	}
}
