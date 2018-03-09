using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UDPListener
{
	public partial class UDPListenerForm : Form
	{
		#region Static members

		private static int _listenPort = 11000;
		private const string Separator = "------------------------------------------------------------";

		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if ((args.Length > 0) && TryGetPort(args[0], out int listenPort))
				_listenPort = listenPort;

			Application.Run(new UDPListenerForm());
		}

		private static bool TryGetPort(string s, out int port)
		{
			port = -1;
			if (int.TryParse(s, out port) && (port > 0) && (port < 65536))
				return true;

			port = -1;
			return false;
		}

		#endregion

		private ListenerWorker _listener;

		private string PortText
		{
			get => _portTextBox.Text;
			set => _portTextBox.Text = value;
		}

		public UDPListenerForm()
		{
			InitializeComponent();
			PortText = _listenPort.ToString();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				components?.Dispose();
			}
			_listener.Dispose();
			base.Dispose(disposing);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			StartListening();
		}

		private bool TryGetPort(out int port)
		{
			return TryGetPort(PortText, out port);
		}

		private void StartListening()
		{
			if (TryGetPort(out int port) == false)
				return;

			_listenPort = port;
			_outputTextBox.Clear();
			if (_listener != null)
			{
				_listener.Shutdown();
				_listener.Dispose();
				_listener = null;
			}

			_listener = new ListenerWorker(_listenPort, WriteLine);
			_listener.RunWorkerAsync();
			//WriteLine($"Listening on Port {_listenPort}");
		}

		private void WriteLine(string text)
		{
			if (_outputTextBox.InvokeRequired)
			{
				Action<string> d = WriteLine;
				Invoke(d, text);
			}
			else
			{
				text = text.Trim();
				if (text == "UDPListener(ClearScreen)")
					_outputTextBox.Clear();
				else if (text == "UDPListener(Separator)")
					_outputTextBox.AppendText($"{Separator}{Environment.NewLine}");
				else
					_outputTextBox.AppendText($"{text}{Environment.NewLine}");
			}
		}

		private void OnClearClicked(object sender, EventArgs e)
		{
			_outputTextBox.Clear();
		}

		private void OnCopyClicked(object sender, EventArgs e)
		{
			Clipboard.SetText(_outputTextBox.SelectedText);
		}

		private void OnCopyAllClicked(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetText(_outputTextBox.Text);
		}

		private void OnPortTextValidating(object sender, CancelEventArgs e)
		{
			if (TryGetPort(out int port) == false)
				MessageBox.Show("Bad Port");
		}

		private void OnRestartClicked(object sender, EventArgs e)
		{
			StartListening();
		}

		private void OnCopyClearClicked(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetText(_outputTextBox.Text);
			_outputTextBox.Clear();
		}

		private void OnSeparatorClicked(object sender, EventArgs e)
		{
			WriteLine(Separator);
		}

	}
}
