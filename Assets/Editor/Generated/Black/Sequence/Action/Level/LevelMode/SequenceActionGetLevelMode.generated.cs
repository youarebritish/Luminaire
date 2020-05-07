using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.LevelMode
{
    public partial class SequenceActionGetLevelMode : Black.Sequence.Action.Level.LevelMode.SequenceActionSetLevelModeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin checkMode_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin truePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin falsePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetLevelMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.LevelMode.SequenceActionGetLevelMode", 0, Black.Sequence.Action.Level.LevelMode.SequenceActionGetLevelMode.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.LevelMode.SequenceActionGetLevelMode", base.GetFieldProperties(), -1592985995, 135165644);
            return fieldProperties;
        }

		
    }
}