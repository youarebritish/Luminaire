using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorSetMaterialState : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disabled_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin depthWrite_pin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public string materialName_;
		public bool depthWrite_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetMaterialState();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorSetMaterialState", 0, Black.Sequence.Action.Actor.SequenceActionActorSetMaterialState.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorSetMaterialState", base.GetFieldProperties(), 1919698316, 1903056458);
            
			
			
			return fieldProperties;
        }

		
    }
}