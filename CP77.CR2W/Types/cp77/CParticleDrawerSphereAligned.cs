using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerSphereAligned : IParticleDrawer
	{
		[Ordinal(0)]  [RED("isGPUBased")] public CBool IsGPUBased { get; set; }
		[Ordinal(1)]  [RED("verticalFixed")] public CBool VerticalFixed { get; set; }

		public CParticleDrawerSphereAligned(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
