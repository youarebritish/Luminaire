using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Mission.Titan
{
    public partial class SequenceActionRideSpearParry : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin guardCancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin guardStart_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin guardEnd_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin guardSuccess_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin damage_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin error_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin parried_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionRideSpearParry();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Mission.Titan.SequenceActionRideSpearParry", 0, Black.Sequence.Action.Level.Mission.Titan.SequenceActionRideSpearParry.ObjectType, null, properties, 0, 1128);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Mission.Titan.SequenceActionRideSpearParry", base.GetFieldProperties(), -1207211838, 1719116248);
            
			
			
			return fieldProperties;
        }

		
    }
}