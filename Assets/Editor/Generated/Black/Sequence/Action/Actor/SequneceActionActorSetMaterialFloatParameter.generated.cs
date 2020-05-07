using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequneceActionActorSetMaterialFloatParameter : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopIn_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public string materialName_;
		public string parameterName_;
		public int type_;
		public int lastType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin alpha_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin blue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin green_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin red_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin boolValue_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float r_;
		public float g_;
		public float b_;
		public float a_;
		public float fValue_;
		public int iValue_;
		public bool bValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequneceActionActorSetMaterialFloatParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequneceActionActorSetMaterialFloatParameter", 0, Black.Sequence.Action.Actor.SequneceActionActorSetMaterialFloatParameter.ObjectType, null, properties, 0, 1392);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequneceActionActorSetMaterialFloatParameter", base.GetFieldProperties(), -350090819, 195217920);
            
			
			
			return fieldProperties;
        }

		
    }
}