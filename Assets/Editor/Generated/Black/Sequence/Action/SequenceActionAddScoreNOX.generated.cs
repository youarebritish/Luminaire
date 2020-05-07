using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action
{
    public partial class SequenceActionAddScoreNOX : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int scoreType_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAddScoreNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.SequenceActionAddScoreNOX", 0, Black.Sequence.Action.SequenceActionAddScoreNOX.ObjectType, null, properties, 0, 376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.SequenceActionAddScoreNOX", base.GetFieldProperties(), 1671676145, -845520115);
            
			
			
			return fieldProperties;
        }

		
    }
}