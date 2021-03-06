using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DestroyWeakspot : AIActionHelperTask
	{
		[Ordinal(0)]  [RED("weakspotArray")] public CArray<wCHandle<gameWeakspotObject>> WeakspotArray { get; set; }
		[Ordinal(1)]  [RED("weakspotComponent")] public CHandle<gameWeakspotComponent> WeakspotComponent { get; set; }
		[Ordinal(2)]  [RED("weakspotIndex")] public CInt32 WeakspotIndex { get; set; }

		public DestroyWeakspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
