using Decal.Adapter;
using Decal.Adapter.Wrappers;
using MyClasses.MetaViewWrappers;
using System;

namespace SamplePluginVVS
{
	[WireUpBaseEvents]

	[FriendlyName("SamplePlugin")]
	public class PluginCore : PluginBase
	{
		protected override void Shutdown()
		{
			try
			{
			}
			catch (Exception ex) { Util.LogError(ex); }
		}
		protected override void Startup()
		{
			try
			{
				Globals.Init("SamplePlugin", Host, Core);
			}
			catch (Exception ex) { Util.LogError(ex); }
		}

		[BaseEvent("LoginComplete", "CharacterFilter")]
		private void CharacterFilter_LoginComplete(object sender, EventArgs e)
		{
			try
			{
				Util.WriteToChat("Plugin now online. Server population: " + Core.CharacterFilter.ServerPopulation);
				Util.WriteToChat("CharacterFilter_LoginComplete");
			}
			catch (Exception ex) { Util.LogError(ex); }
		}

		[BaseEvent("Logoff", "CharacterFilter")]
		private void CharacterFilter_Logoff(object sender, Decal.Adapter.Wrappers.LogoffEventArgs e)
		{
		}
	}
}