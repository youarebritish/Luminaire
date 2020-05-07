using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionMobhuntSystemGetInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inFinishValue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin recieved_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notRecieved_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin killed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin allKilled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notKilled_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin allKilledTeamIdListOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mobhuntTeamIdListOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mobhuntTeamIdOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin firstTravelOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin mobhuntClear_;
		public bool isOnce_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMobhuntSystemGetInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSystemGetInfo", 0, Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSystemGetInfo.ObjectType, null, properties, 0, 1584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntSystemGetInfo", base.GetFieldProperties(), -1065173013, 219628438);
            
			
			
			return fieldProperties;
        }

		
    }
}