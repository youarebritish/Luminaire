using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.LevelMode
{
    public partial class SequenceActionSetLevelModeNew : Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeSetBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin preparedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetLevelModeNew();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeNew", 0, Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeNew.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeNew", base.GetFieldProperties(), -121792325, 657561061);
            return fieldProperties;
        }

		
    }
}