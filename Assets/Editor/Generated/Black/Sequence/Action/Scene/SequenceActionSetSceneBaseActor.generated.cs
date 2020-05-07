using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Scene
{
    public partial class SequenceActionSetSceneBaseActor : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int actorScene_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputSceneID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputSceneIDActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSceneBaseActor();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Scene.SequenceActionSetSceneBaseActor", 0, Black.Sequence.Action.Scene.SequenceActionSetSceneBaseActor.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Scene.SequenceActionSetSceneBaseActor", base.GetFieldProperties(), 182860144, 1330369326);
            return fieldProperties;
        }

		
    }
}