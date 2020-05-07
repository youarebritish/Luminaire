using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionCameraStartSequence : Black.Sequence.Control.SequenceActionControlLabeled
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin owner_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin vector1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin float1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin int1Pin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraStartSequence();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionCameraStartSequence", 0, Black.Sequence.Control.SequenceActionCameraStartSequence.ObjectType, null, properties, 0, 1184);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionCameraStartSequence", base.GetFieldProperties(), -940917485, -387504180);
            
			
			
			return fieldProperties;
        }

		
    }
}