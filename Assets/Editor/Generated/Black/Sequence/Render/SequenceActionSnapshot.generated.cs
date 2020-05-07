using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSnapshot : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inDebugView_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inSaveFile_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActor_;
		public bool debugView_;
		public float fNear_;
		public float fZFar_;
		public float fovY_;
		public float elevationDeg_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSnapshot();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSnapshot", 0, Black.Sequence.Render.SequenceActionSnapshot.ObjectType, null, properties, 0, 600);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSnapshot", base.GetFieldProperties(), 925472905, -628505529);
            
			
			
			return fieldProperties;
        }

		
    }
}