#nullable disable
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation.Peers;
using NativeAutomationProperties = Microsoft.UI.Xaml.Automation.AutomationProperties;

namespace Microsoft.Maui.Controls.Platform
{
	public static class AccessibilityExtensions
	{
		public static void SetAutomationPropertiesAutomationId(this FrameworkElement Control, string id)
		{
			Control.SetValue(NativeAutomationProperties.AutomationIdProperty, id);
		}

		public static string SetAutomationPropertiesName(this FrameworkElement Control, Element Element, string _defaultAutomationPropertiesName = null)
		{
			if (Element == null)

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
				return _defaultAutomationPropertiesName;
After:
			{
				return _defaultAutomationPropertiesName;
			}
*/
			
/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
				_defaultAutomationPropertiesName = (string)Control.GetValue(NativeAutomationProperties.NameProperty);
After:
			{
				_defaultAutomationPropertiesName = (string)Control.GetValue(NativeAutomationProperties.NameProperty);
			}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
				Control.SetValue(NativeAutomationProperties.NameProperty, elemValue);
			else
After:
			{
				Control.SetValue(NativeAutomationProperties.NameProperty, elemValue);
			}
			else
			{
*/
{
				return _defaultAutomationPropertiesName;
			}

			if (_defaultAutomationPropertiesName == null)
			{
				_defaultAutomationPropertiesName = (string)Control.GetValue(NativeAutomationProperties.NameProperty);
			}

#pragma warning disable CS0618 // Type or member is obsolete
			var elemValue = (string)Element.GetValue(AutomationProperties.NameProperty);
#pragma warning restore CS0618 // Type or member is obsolete

			if (!string.IsNullOrWhiteSpace(elemValue))
			{
				Control.SetValue(NativeAutomationProperties.NameProperty, elemValue);
			}
			else
			{
				Control.SetValue(NativeAutomationProperties.NameProperty, _defaultAutomationPropertiesName);
			}
			}

			return _defaultAutomationPropertiesName;
		}

		public static AccessibilityView? SetAutomationPropertiesAccessibilityView(this FrameworkElement Control, Element Element, AccessibilityView? _defaultAutomationPropertiesAccessibilityView = null)
		{
			if (Element == null)
			{
			
/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
			if (!_defaultAutomationPropertiesAccessibilityView.HasValue)
				_defaultAutomationPropertiesAccessibilityView = (AccessibilityView)Control.GetValue(NativeAutomationProperties.AccessibilityViewProperty);

			var newValue = _defaultAutomationPropertiesAccessibilityView;

			var elemValue = (bool?)Element.GetValue(AutomationProperties.IsInAccessibleTreeProperty);
After:
			}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
			if (elemValue == true)
				newValue = AccessibilityView.Content;
After:
			if (!_defaultAutomationPropertiesAccessibilityView.HasValue)
			{
				_defaultAutomationPropertiesAccessibilityView = (AccessibilityView)Control.GetValue(NativeAutomationProperties.AccessibilityViewProperty);
			}

			var newValue = _defaultAutomationPropertiesAccessibilityView;

			var elemValue = (bool?)Element.GetValue(AutomationProperties.IsInAccessibleTreeProperty);

			if (elemValue == true)
			{
				newValue = AccessibilityView.Content;
			}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
				newValue = AccessibilityView.Raw;
After:
			{
				newValue = AccessibilityView.Raw;
			}
*/
{
				return _defaultAutomationPropertiesAccessibilityView;
			}

			if (!_defaultAutomationPropertiesAccessibilityView.HasValue)
			{
				_defaultAutomationPropertiesAccessibilityView = (AccessibilityView)Control.GetValue(NativeAutomationProperties.AccessibilityViewProperty);
			}

			var newValue = _defaultAutomationPropertiesAccessibilityView;

			var elemValue = (bool?)Element.GetValue(AutomationProperties.IsInAccessibleTreeProperty);

			if (elemValue == true)
			{
				newValue = AccessibilityView.Content;
			}
			else if (elemValue == false)
			{
				newValue = AccessibilityView.Raw;
			}

			Control.SetValue(NativeAutomationProperties.AccessibilityViewProperty, newValue);

			return _defaultAutomationPropertiesAccessibilityView;

		}
		public static string SetAutomationPropertiesHelpText(this FrameworkElement Control, Element Element, string _defaultAutomationPropertiesHelpText = null)
		{
			if (Element == null)

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
				return _defaultAutomationPropertiesHelpText;
After:
			{
				return _defaultAutomationPropertiesHelpText;
			}
*/
			
/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
				_defaultAutomationPropertiesHelpText = (string)Control.GetValue(NativeAutomationProperties.HelpTextProperty);
After:
			{
				_defaultAutomationPropertiesHelpText = (string)Control.GetValue(NativeAutomationProperties.HelpTextProperty);
			}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
				Control.SetValue(NativeAutomationProperties.HelpTextProperty, elemValue);
			else
After:
			{
				Control.SetValue(NativeAutomationProperties.HelpTextProperty, elemValue);
			}
			else
			{
*/
{
				return _defaultAutomationPropertiesHelpText;
			}

			if (_defaultAutomationPropertiesHelpText == null)
			{
				_defaultAutomationPropertiesHelpText = (string)Control.GetValue(NativeAutomationProperties.HelpTextProperty);
			}

#pragma warning disable CS0618 // Type or member is obsolete
			var elemValue = (string)Element.GetValue(AutomationProperties.HelpTextProperty);
#pragma warning restore CS0618 // Type or member is obsolete

			if (!string.IsNullOrWhiteSpace(elemValue))
			{
				Control.SetValue(NativeAutomationProperties.HelpTextProperty, elemValue);
			}
			else
			{
				Control.SetValue(NativeAutomationProperties.HelpTextProperty, _defaultAutomationPropertiesHelpText);
			}
			}

			return _defaultAutomationPropertiesHelpText;
		}

		public static UIElement SetAutomationPropertiesLabeledBy(
			this FrameworkElement Control,
			Element Element,
			IMauiContext mauiContext,
			UIElement _defaultAutomationPropertiesLabeledBy = null)
		{
			if (Element == null)
			{
				return _defaultAutomationPropertiesLabeledBy;
			}

			// TODO Maui: this is a bit of a hack because Elements
			// currently don't implement IView but they should
			mauiContext ??= (Element as IView)?.Handler?.MauiContext;

			if (_defaultAutomationPropertiesLabeledBy == null)
			{
				_defaultAutomationPropertiesLabeledBy = (UIElement)Control.GetValue(NativeAutomationProperties.LabeledByProperty);
			}
#pragma warning disable CS0618 // Type or member is obsolete
			var elemValue = (VisualElement)Element.GetValue(AutomationProperties.LabeledByProperty);
#pragma warning restore CS0618 // Type or member is obsolete
			FrameworkElement nativeElement = null;

			if (mauiContext != null)
			{
				nativeElement = (elemValue as IView)?.ToHandler(mauiContext)?.PlatformView as FrameworkElement;
			}

			if (nativeElement != null)
			{
#pragma warning disable CS0618 // Type or member is obsolete
				Control.SetValue(AutomationProperties.LabeledByProperty, nativeElement);
			}
#pragma warning restore CS0618 // Type or member is obsolete
			else
			{
				Control.SetValue(NativeAutomationProperties.LabeledByProperty, _defaultAutomationPropertiesLabeledBy);
			}

			return _defaultAutomationPropertiesLabeledBy;
		}

		// TODO MAUI: This is not having any effect on anything I've tested yet. See if we need it  
		// after we test the FP and NP w/ back button explicitly enabled. 
		public static void SetBackButtonTitle(this PageControl Control, Element Element)
		{
			if (Element == null)
			{
				return;
			}

			var elemValue = ConcatenateNameAndHint(Element);

			Control.BackButtonTitle = elemValue;
		}

		static string ConcatenateNameAndHint(Element Element)
		{
			string separator;

#pragma warning disable CS0618 // Type or member is obsolete
			var name = (string)Element.GetValue(AutomationProperties.NameProperty);

			var hint = (string)Element.GetValue(AutomationProperties.HelpTextProperty);
#pragma warning restore CS0618 // Type or member is obsolete

			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(hint))
			{
				separator = "";
			}
			else
			{
				separator = ". ";
			}

			return string.Join(separator, name, hint);

		}

		public static void SetAutomationProperties(
			this FrameworkElement frameworkElement,
			Element element,
			IMauiContext mauiContext,
			string defaultName = null)
		{
			frameworkElement.SetAutomationPropertiesAutomationId(element?.AutomationId);
			frameworkElement.SetAutomationPropertiesName(element, defaultName);
			frameworkElement.SetAutomationPropertiesHelpText(element);
			frameworkElement.SetAutomationPropertiesLabeledBy(element, mauiContext);
			frameworkElement.SetAutomationPropertiesAccessibilityView(element);
		}
	}
}
