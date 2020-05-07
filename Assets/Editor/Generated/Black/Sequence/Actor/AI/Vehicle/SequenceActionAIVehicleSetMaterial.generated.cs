using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Vehicle
{
    public partial class SequenceActionAIVehicleSetMaterial : Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inVehicleActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin boolPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int target_;
		public int intValue_;
		public bool boolValue_;
		public float floatValue_;
		public uint bodyColorId_;
		public uint tireColorId_;
		public uint interiorColorId_;
		public uint sticker1Id_;
		public uint sticker2Id_;
		public uint sticker3Id_;
		public uint sticker4Id_;
		public uint sticker5Id_;
		public uint materialBaseId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIVehicleSetMaterial();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetMaterial", 0, Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetMaterial.ObjectType, null, properties, 0, 784);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Vehicle.SequenceActionAIVehicleSetMaterial", base.GetFieldProperties(), 2131785858, 2044671596);
            
			
			
			return fieldProperties;
        }

		
    }
}