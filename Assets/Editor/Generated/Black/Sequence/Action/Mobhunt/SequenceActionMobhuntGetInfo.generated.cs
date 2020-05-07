using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Mobhunt
{
    public partial class SequenceActionMobhuntGetInfo : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin checkRecievedCount_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueBaseMapFixId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cleared_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin recieved_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin recievedOver10_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin mobhuntTeamIdOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin wantedTeamIdOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin wantedNameIdOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin wantedGillOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin createdWantedId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionMobhuntGetInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetInfo", 0, Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetInfo.ObjectType, null, properties, 0, 1480);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Mobhunt.SequenceActionMobhuntGetInfo", base.GetFieldProperties(), -80018072, 334515683);
            return fieldProperties;
        }

		
    }
}