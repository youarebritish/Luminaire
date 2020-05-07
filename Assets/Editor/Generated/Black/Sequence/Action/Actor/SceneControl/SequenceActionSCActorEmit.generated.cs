using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.SceneControl
{
    public partial class SequenceActionSCActorEmit : Black.Sequence.Actor.SequenceActionActorCreateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnPointPin_;
		public float momentum_;
		public float angle_;
		public string CharaEntry_;
		public int actoryType_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSCActorEmit();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorEmit", 0, Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorEmit.ObjectType, null, properties, 0, 1376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SceneControl.SequenceActionSCActorEmit", base.GetFieldProperties(), 326493764, 1519793643);
            
			
			
			return fieldProperties;
        }

		
    }
}