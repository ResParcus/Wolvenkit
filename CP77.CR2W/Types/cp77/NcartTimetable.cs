using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NcartTimetable : InteractiveDevice
	{
		[Ordinal(0)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(1)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public NcartTimetable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
