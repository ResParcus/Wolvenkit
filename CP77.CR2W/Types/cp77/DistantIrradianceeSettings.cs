using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DistantIrradianceeSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("blendDistance")] public curveData<CFloat> BlendDistance { get; set; }
		[Ordinal(1)]  [RED("distantHeightRange")] public curveData<Vector3> DistantHeightRange { get; set; }
		[Ordinal(2)]  [RED("distantLights")] public curveData<CFloat> DistantLights { get; set; }
		[Ordinal(3)]  [RED("distantLightsRange")] public curveData<Vector2> DistantLightsRange { get; set; }
		[Ordinal(4)]  [RED("distantRange")] public curveData<Vector2> DistantRange { get; set; }

		public DistantIrradianceeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
