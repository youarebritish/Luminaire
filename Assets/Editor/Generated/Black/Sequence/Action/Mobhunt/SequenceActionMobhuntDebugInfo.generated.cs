using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionMobhuntDebugInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin addStar_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin subStar_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin addRank_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin subRank_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mobhuntStarIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mobhuntRankIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mobhuntStarOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mobhuntRankOut_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMobhuntDebugInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntDebugInfo", 0, Black.Sequence.Action.Mobhunt.SequenceActionMobhuntDebugInfo.ObjectType, null, properties, 0, 1296);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntDebugInfo", base.GetFieldProperties(), -22340490, -805899687);
            return fieldProperties;
        }

		
    }
}