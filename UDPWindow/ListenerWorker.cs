using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPListener
{
	public class ListenerWorker : BackgroundWorker
	{
		private readonly Action<string> _onMessageRx;
		private UdpClient _listener;
		private IPEndPoint _endPoint;
		private bool _isListening;

		public ListenerWorker(int port, Action<string> onMessageRx)
		{
			_onMessageRx = onMessageRx;
			_listener = new UdpClient(port);
			_endPoint = new IPEndPoint(IPAddress.Any, port);
			_isListening = true;
			WorkerSupportsCancellation = true;
		}

		public void Shutdown()
		{
			_isListening = false;
			_listener.Close();
			CancelAsync();
		}

		protected override void OnDoWork(DoWorkEventArgs e)
		{
			base.OnDoWork(e);

			try
			{
				while (CancellationPending == false && _isListening)
				{
					try
					{
						byte[] bytes = _listener.Receive(ref _endPoint);
						string msg = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
						if (string.IsNullOrWhiteSpace(msg) == false)
							_onMessageRx(msg);
					}
					catch (ObjectDisposedException)
					{
						//_onMessageRx("Port " + _endPoint.Port + " closed abnormally");
					}
					catch (Exception exception)
					{
						_onMessageRx("UdpClient error: " + exception.Message);
					}
				}
				//_onMessageRx("Cancelling...");
			}
			catch (Exception ex)
			{
				_onMessageRx(ex.ToString());
			}
		}

		protected override void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
		{
			base.OnRunWorkerCompleted(e);
			Dispose(true);
		}

		protected override void Dispose(bool disposing)
		{
			if (_listener != null)
			{
				_isListening = false;
				_listener.Close();
				_listener.Dispose();
				_listener = null;
			}

			base.Dispose(disposing);
		}

	}
}