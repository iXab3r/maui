using System;
using WindowsDispatcher = System.Windows.Threading.Dispatcher;

namespace Microsoft.AspNetCore.Components.WebView.Wpf;

/// <summary>
/// 
/// </summary>
public sealed class WpfDispatcherUnhandlerExceptionEventArgs : EventArgs
{
	/// <summary>
	/// 
	/// </summary>
	public Exception Exception { get; }

	/// <summary>
	///     The <see cref="Dispatcher"/> associated with this event.
	/// </summary>
	/// <ExternalAPI/> 
	public WindowsDispatcher Dispatcher { get; }

	/// <summary>
	/// 
	/// </summary>
	public bool Handled { get; set; }

	/// <summary>
	/// 
	/// </summary>
	/// <param name="dispatcher"></param>
	/// <param name="exception"></param>
	public WpfDispatcherUnhandlerExceptionEventArgs(WindowsDispatcher dispatcher, Exception exception)
	{
		Exception = exception;
		Dispatcher = dispatcher;
	}

}