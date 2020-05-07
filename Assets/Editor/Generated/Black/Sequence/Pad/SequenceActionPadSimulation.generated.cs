using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Pad
{
    public partial class SequenceActionPadSimulation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin right_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin left_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin a_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin b_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin x_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin y_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin triangle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin circle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin cross_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin square_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin select_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin l1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin r1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin l2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin r2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin l3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin r3_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lt_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rt_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lx_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ly_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rx_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ry_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPadSimulation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Pad.SequenceActionPadSimulation", 0, Black.Sequence.Pad.SequenceActionPadSimulation.ObjectType, null, properties, 0, 2824);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Pad.SequenceActionPadSimulation", base.GetFieldProperties(), -190710575, 747725956);
            
			
			
			return fieldProperties;
        }

		
    }
}