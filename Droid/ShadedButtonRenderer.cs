using System;
using FormsRecipeApp;
using FormsRecipeApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRendererAttribute(typeof(ShadedButton), typeof(ShadedButtonRenderer))]

namespace FormsRecipeApp.Droid
{
	public class ShadedButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.SetBackgroundResource(Resource.Drawable.UnChecked);
			}

		}
	}
}
