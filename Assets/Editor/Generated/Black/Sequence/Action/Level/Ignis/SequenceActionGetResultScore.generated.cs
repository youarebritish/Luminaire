using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Ignis
{
    public partial class SequenceActionGetResultScore : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int scene_;
		public int result_;
		public int score_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin score_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin more_than_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin less_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetResultScore();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Ignis.SequenceActionGetResultScore", 0, Black.Sequence.Action.Level.Ignis.SequenceActionGetResultScore.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Ignis.SequenceActionGetResultScore", base.GetFieldProperties(), -5773344, 1039662005);
            
			
			
			return fieldProperties;
        }

		
    }
}