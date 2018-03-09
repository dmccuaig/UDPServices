using System;
using System.Net.Sockets;

namespace UDPClient
{
	public class Program
	{
		public static void Main()
		{
			int port = 11000;
			while (true)
			{
				Console.Write($"Port [{port}]: ");
				string portString = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(portString) == false)
				{
					if (TryGetPort(portString, out port) == false)
						return;
				}

				Console.Write("Message: ");
				string msg = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(msg))
					return;

				Send(msg, port);
			}
		}

		private static bool TryGetPort(string s, out int port)
		{
			port = -1;
			if (int.TryParse(s, out port) && (port > 0) && (port < 65536))
				return true;

			port = -1;
			return false;
		}

		// Send UDP message
		public static void Send(string msg, int port, System.Net.IPAddress server)
		{
			using (var s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
			{
				byte[] sendbuf = System.Text.Encoding.ASCII.GetBytes(msg);
				var ep = new System.Net.IPEndPoint(server, port);
				s.SendTo(sendbuf, ep);
			}
		}

		// Send to localhost
		public static void Send(string msg, int port)
		{
			Send(msg, port, System.Net.IPAddress.Loopback);
		}

	}
}
