using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionPlayerStartBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin started_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin position_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin objectOut_;
		public bool isUseRayCheck_;
		public float UpperExtentOffset;
		public float LowerExtentOffset;
		public bool isSpecifyParty_;
		public int partySaveBankNumber1_;
		public int partySaveBankNumber2_;
		public int partySaveBankNumber3_;
		public int partySaveBankNumber4_;
		public bool isSpecifyGuestParty_;
		public int partySaveBankNumber5_;
		public bool isNeedSetUserControlActor_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayerStartBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionPlayerStartBase", 0, Black.Sequence.Actor.SequenceActionPlayerStartBase.ObjectType, null, properties, 0, 896);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionPlayerStartBase", base.GetFieldProperties(), -484673946, -1602319052);
            
			
			
			return fieldProperties;
        }

		
    }
}