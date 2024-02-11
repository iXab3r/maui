using AppKit;

namespace Microsoft.Maui.Graphics.Platform
{
	public static class ImageExtensions
	{
		public static NSImage AsNSImage(this IImage image)
		{
			if (image is PlatformImage macImage)

/* Unmerged change from project 'Graphics(net7.0-macos)'
Before:
				return macImage.NativeRepresentation;

			if (image != null)
				System.Diagnostics.Debug.WriteLine("MMImageExtensions.AsNSImage: Unable to get NSImage from Image. Expected an image of type NativeImage however an image of type {0} was received.", image.GetType());
After:
			{
				return macImage.NativeRepresentation;
			}

			if (image != null)
			{
				System.Diagnostics.Debug.WriteLine("MMImageExtensions.AsNSImage: Unable to get NSImage from Image. Expected an image of type NativeImage however an image of type {0} was received.", image.GetType());
			}
*/
			{
				return macImage.NativeRepresentation;
			}

			if (image != null)
			{
				System.Diagnostics.Debug.WriteLine("MMImageExtensions.AsNSImage: Unable to get NSImage from Image. Expected an image of type NativeImage however an image of type {0} was received.", image.GetType());
			}

			return null;
		}
	}
}
