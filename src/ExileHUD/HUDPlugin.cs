using PoeHUD.ExileBot;

namespace PoeHUD.ExileHUD
{
	public abstract class HUDPlugin
	{
		protected PathOfExile poe;
		protected OverlayRenderer overlay;
		public void Init(PathOfExile poe, OverlayRenderer overlay)
		{
			this.poe = poe;
			this.overlay = overlay;
			this.OnEnable();
		}
		public abstract void OnEnable();
		public abstract void Render(RenderingContext rc);
		public abstract void OnDisable();
	}
}
