using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionControlStartSequenceFixid : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopInputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin owner_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lastSceneKeepPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor2Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin vector1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin float1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin int1Pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin animationIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin animationDurationPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin commandSetPin_;
		public uint label_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionControlStartSequenceFixid();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionControlStartSequenceFixid", 0, Black.Sequence.Control.SequenceActionControlStartSequenceFixid.ObjectType, null, properties, 0, 1584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionControlStartSequenceFixid", base.GetFieldProperties(), -1766638776, 1078423038);
            
			
			
			return fieldProperties;
        }

		
    }
}