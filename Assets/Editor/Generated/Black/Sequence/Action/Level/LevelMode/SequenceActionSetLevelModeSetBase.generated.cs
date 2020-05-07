using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.LevelMode
{
    public partial class SequenceActionSetLevelModeSetBase : Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int eventModeLayer_;
		public uint eventId_;
		public bool pcControlFlag_;
		public bool cameraFadeFlag_;
		public bool isEnableMotionBlur_;
		public bool isNeedToShowRegalia_;
		public int preparedFadeInFrame_;
		public int fadeOutFrame_;
		public int fadeInFrame_;
		public bool isEnableSkip_;
		public int eventSkipFadeOutFrame_;
		public int eventSkipFadeInFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetLevelModeSetBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeSetBase", 0, Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeSetBase.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeSetBase", base.GetFieldProperties(), 1576425019, 1255912701);
            return fieldProperties;
        }

		
    }
}