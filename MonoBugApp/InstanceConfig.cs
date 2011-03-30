using System.Collections.Generic;
using System.Xml.Serialization;

namespace MonoBugApp
{
	[XmlRoot("Instances")]
	public class InstanceConfig : InstanceConfigBase<InstanceConfig, Constants.MapId>
	{
		public static InstanceConfig Instance;

		public static void LoadSettings()
		{
			Instance = LoadSettings("Instances.xml");
		}

		protected override void InitSetting(InstanceSetting<Constants.MapId> setting)
		{
		}

		public override IEnumerable<Constants.MapId> SortedIds
		{
			get { return new List<Constants.MapId>(); }
		}
	}
}