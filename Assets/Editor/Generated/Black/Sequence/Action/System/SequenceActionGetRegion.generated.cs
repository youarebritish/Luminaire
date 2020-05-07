using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.System
{
    public partial class SequenceActionGetRegion : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin japan_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin usa_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin europe_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin asia_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin china_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin unknown_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetRegion();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.System.SequenceActionGetRegion", 0, Black.Sequence.Action.System.SequenceActionGetRegion.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.System.SequenceActionGetRegion", base.GetFieldProperties(), -265906837, -703163404);
            
			
			
			return fieldProperties;
        }

		
    }
}