using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionMobhuntGetLimitedTimeInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeeded_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mobhuntIdList_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mobhuntVerList_;
		public bool isOnlyCheckSignedIn_;
		public bool isEnabledErrorDiarog_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMobhuntGetLimitedTimeInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetLimitedTimeInfo", 0, Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetLimitedTimeInfo.ObjectType, null, properties, 0, 840);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetLimitedTimeInfo", base.GetFieldProperties(), 1063048302, -1056276618);
            return fieldProperties;
        }

		
    }
}