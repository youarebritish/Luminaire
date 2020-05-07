using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.General
{
    public partial class SequenceActionTimeLineSoundDialogTrackGeneral : Black.Sequence.Action.TimeLine.Sound.SequenceActionTimeLineSoundTrackCommon
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int voiceLanguage_;
		public bool forceDialogOff_;
		public bool isMute_;
		public bool isDialogStop_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineSoundDialogTrackGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundDialogTrackGeneral", 0, Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundDialogTrackGeneral.ObjectType, null, properties, 0, 432);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundDialogTrackGeneral", base.GetFieldProperties(), -116949843, -1362738138);
            
			fieldProperties.AddProperty(new Property("voiceLanguage_", 1015926640, "Black.Sequence.Action.TimeLine.General.SequenceActionTimeLineSoundDialogTrackGeneral.Voice_Language", 424, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceDialogOff_", 2948129458, "bool", 428, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isMute_", 438913665, "bool", 429, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isDialogStop_", 2680193298, "bool", 430, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}