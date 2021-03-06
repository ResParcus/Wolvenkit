using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ButtonPlaySoundView : BaseButtonView
	{
		[Ordinal(0)]  [RED("HoverSoundName")] public CName HoverSoundName { get; set; }
		[Ordinal(1)]  [RED("PressSoundName")] public CName PressSoundName { get; set; }
		[Ordinal(2)]  [RED("SoundPrefix")] public CName SoundPrefix { get; set; }

		public ButtonPlaySoundView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
