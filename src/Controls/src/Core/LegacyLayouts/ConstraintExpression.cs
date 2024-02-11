#nullable disable
using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;

namespace Microsoft.Maui.Controls.Compatibility
{
	public class ConstraintExpression : IMarkupExtension<Constraint>
	{
		public ConstraintExpression()
		{
			Factor = 1.0;
		}

		public double Constant { get; set; }

		public string ElementName { get; set; }

		public double Factor { get; set; }

		public string Property { get; set; }

		public ConstraintType Type { get; set; }

		object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
		{
			return (this as IMarkupExtension<Constraint>).ProvideValue(serviceProvider);
		}

		public Constraint ProvideValue(IServiceProvider serviceProvider)
		{
			MethodInfo minfo;
			switch (Type)
			{
				default:
				case ConstraintType.RelativeToParent:
					if (string.IsNullOrEmpty(Property))

/* Unmerged change from project 'Controls.Core(net8.0)'
Before:
						return null;
After:
					{
						return null;
					}
*/

/* Unmerged change from project 'Controls.Core(net8.0-ios)'
Before:
						return null;
After:
					{
						return null;
					}
*/

/* Unmerged change from project 'Controls.Core(net8.0-maccatalyst)'
Before:
						return null;
After:
					{
						return null;
					}
*/

/* Unmerged change from project 'Controls.Core(net8.0-android)'
Before:
						return null;
After:
					{
						return null;
					}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.19041)'
Before:
						return null;
After:
					{
						return null;
					}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
						return null;
After:
					{
						return null;
					}
*/
					{
						return null;
					}

					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					return Constraint.RelativeToParent(p => (double)minfo.Invoke(p, Array.Empty<object>()) * Factor + Constant);
				case ConstraintType.Constant:

/* Unmerged change from project 'Controls.Core(net8.0)'
Before:
						return null;
					if (string.IsNullOrEmpty(ElementName))
After:
					{
*/

/* Unmerged change from project 'Controls.Core(net8.0-ios)'
Before:
						return null;
					if (string.IsNullOrEmpty(ElementName))
After:
					{
*/

/* Unmerged change from project 'Controls.Core(net8.0-maccatalyst)'
Before:
						return null;
					if (string.IsNullOrEmpty(ElementName))
After:
					{
*/

/* Unmerged change from project 'Controls.Core(net8.0-android)'
Before:
						return null;
					if (string.IsNullOrEmpty(ElementName))
After:
					{
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.19041)'
Before:
						return null;
					if (string.IsNullOrEmpty(ElementName))
After:
					{
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
						return null;
					if (string.IsNullOrEmpty(ElementName))
After:
					{
*/

/* Unmerged change from project 'Controls.Core(net8.0)'
Before:
					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
						view = (View)referenceProvider.FindByName(ElementName);
					else
After:
					}

					if (string.IsNullOrEmpty(ElementName))
					{
						return null;
					}

					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
					{
						view = (View)referenceProvider.FindByName(ElementName);
					}
					else
*/

/* Unmerged change from project 'Controls.Core(net8.0-ios)'
Before:
					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
						view = (View)referenceProvider.FindByName(ElementName);
					else
After:
					}

					if (string.IsNullOrEmpty(ElementName))
					{
						return null;
					}

					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
					{
						view = (View)referenceProvider.FindByName(ElementName);
					}
					else
*/

/* Unmerged change from project 'Controls.Core(net8.0-maccatalyst)'
Before:
					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
						view = (View)referenceProvider.FindByName(ElementName);
					else
After:
					}

					if (string.IsNullOrEmpty(ElementName))
					{
						return null;
					}

					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
					{
						view = (View)referenceProvider.FindByName(ElementName);
					}
					else
*/

/* Unmerged change from project 'Controls.Core(net8.0-android)'
Before:
					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
						view = (View)referenceProvider.FindByName(ElementName);
					else
After:
					}

					if (string.IsNullOrEmpty(ElementName))
					{
						return null;
					}

					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
					{
						view = (View)referenceProvider.FindByName(ElementName);
					}
					else
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.19041)'
Before:
					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
						view = (View)referenceProvider.FindByName(ElementName);
					else
After:
					}

					if (string.IsNullOrEmpty(ElementName))
					{
						return null;
					}

					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
					{
						view = (View)referenceProvider.FindByName(ElementName);
					}
					else
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
						view = (View)referenceProvider.FindByName(ElementName);
					else
After:
					}

					if (string.IsNullOrEmpty(ElementName))
					{
						return null;
					}

					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
					{
						view = (View)referenceProvider.FindByName(ElementName);
					}
					else
*/

/* Unmerged change from project 'Controls.Core(net8.0)'
Before:
							return null;
After:
						{
							return null;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-ios)'
Before:
							return null;
After:
						{
							return null;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-maccatalyst)'
Before:
							return null;
After:
						{
							return null;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-android)'
Before:
							return null;
After:
						{
							return null;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.19041)'
Before:
							return null;
After:
						{
							return null;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
							return null;
After:
						{
							return null;
						}
*/
					return Constraint.Constant(Constant);
				case ConstraintType.RelativeToView:
					if (string.IsNullOrEmpty(Property))
					{
						return null;
					}

					if (string.IsNullOrEmpty(ElementName))
					{
						return null;
					}

					minfo = typeof(View).GetProperties().First(pi => pi.Name == Property && pi.CanRead && pi.GetMethod.IsPublic).GetMethod;
					var referenceProvider = serviceProvider.GetService<IReferenceProvider>();

					View view;
					if (referenceProvider != null)
					{
						view = (View)referenceProvider.FindByName(ElementName);
					}
					else
					{ //legacy path
						var valueProvider = serviceProvider.GetService<IProvideValueTarget>();
						if (valueProvider == null || !(valueProvider.TargetObject is INameScope))
						{
							return null;
						}

						view = ((INameScope)valueProvider.TargetObject).FindByName<View>(ElementName);
					}
					return Constraint.RelativeToView(view, delegate (RelativeLayout p, View v)
					{ return (double)minfo.Invoke(v, Array.Empty<object>()) * Factor + Constant; });
			}
		}
	}
}