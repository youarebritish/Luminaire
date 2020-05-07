using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Body
{
    public partial class SequenceActionActorChangeBodyGraph : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin loadAndChangePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin revertAndUnloadPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outLoadPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin loadFinishedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outUnloadPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public string sourcePath_;
		public int priorityType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorChangeBodyGraph();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Body.SequenceActionActorChangeBodyGraph", 0, Black.Sequence.Action.Actor.Body.SequenceActionActorChangeBodyGraph.ObjectType, null, properties, 0, 816);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Body.SequenceActionActorChangeBodyGraph", base.GetFieldProperties(), 87327808, 936599437);
            
			
			
			return fieldProperties;
        }

		
    }
}