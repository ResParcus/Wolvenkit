using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class communityCommunityEntryPhaseSpotsData : CVariable
	{
		[Ordinal(0)]  [RED("timePeriodsData")] public CArray<communityCommunityEntryPhaseTimePeriodData> TimePeriodsData { get; set; }
		[Ordinal(1)]  [RED("entryPhaseName")] public CName EntryPhaseName { get; set; }

		public communityCommunityEntryPhaseSpotsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
