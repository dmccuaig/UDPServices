namespace UDPSendMessage
{
	public static class Sender
	{
		public const int DefaultPort = 11000;

		// Send UDP message
		public static void Send(string msg, int port, System.Net.IPAddress server)
		{
			using (var s = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Dgram, System.Net.Sockets.ProtocolType.Udp))
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

		// Send to default port
		public static void Send(string msg)
		{
			Send(msg, DefaultPort);
		}

		public static void Send(string format, params object[] args)
		{
			Send(string.Format(format, args));
		}

		public static void SendMethodName()
		{
			Send(new System.Diagnostics.StackFrame(1).GetMethod().Name);
		}

		internal static void SendMethodName(string msg)
		{
			Send($"{new System.Diagnostics.StackFrame(1).GetMethod().Name} {msg}");
		}

		public static void SendMethodName(string fmt, params object[] args)
		{
			SendMethodName(string.Format(fmt, args));
		}

	}
}