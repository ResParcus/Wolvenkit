using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Target : IScriptable
	{
		[Ordinal(0)]  [RED("isInteresting")] public CBool IsInteresting { get; set; }
		[Ordinal(1)]  [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(2)]  [RED("target")] public wCHandle<gameObject> _Target { get; set; }

		public Target(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
