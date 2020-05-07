using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Scene
{
    public partial class SequenceActionChangeSceneLOD : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin set_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin reset_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int actorScene_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputSceneID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputSceneIDActor_;
		public float lodScale_;
		public float modelLODScale_;
		public bool applyModelLODScaleWorkingActors_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangeSceneLOD();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Scene.SequenceActionChangeSceneLOD", 0, Black.Sequence.Action.Scene.SequenceActionChangeSceneLOD.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Scene.SequenceActionChangeSceneLOD", base.GetFieldProperties(), 1732803259, -2140048158);
            
			
			
			return fieldProperties;
        }

		
    }
}