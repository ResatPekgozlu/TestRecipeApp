using System;
using FormsRecipeApp;
using FormsRecipeApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRendererAttribute(typeof(ShadedButton),typeof(ShadedButtonRenderer))]

namespace FormsRecipeApp.iOS
{
	public class ShadedButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.BackgroundColor = UIColor.Gray;
				Control.SetBackgroundImage(UIImage.FromBundle("UnChecked.png"), UIControlState.Normal);
			}

				                    
		}
	}
}
