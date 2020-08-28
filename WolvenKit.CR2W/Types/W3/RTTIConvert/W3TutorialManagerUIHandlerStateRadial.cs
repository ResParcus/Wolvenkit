using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateRadial : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("SELECT_ITEMS")] 		public CName SELECT_ITEMS { get; set;}

		[RED("SELECT_BOLTS")] 		public CName SELECT_BOLTS { get; set;}

		[RED("BUFFS")] 		public CName BUFFS { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateRadial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateRadial(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}