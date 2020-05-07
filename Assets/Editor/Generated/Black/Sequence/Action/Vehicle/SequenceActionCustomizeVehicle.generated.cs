using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vehicle
{
    public partial class SequenceActionCustomizeVehicle : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin levelPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public int target_;
		public uint unlockColorId_;
		public uint unlockStickerId_;
		public uint unlockSpecId_;
		public uint unlockPartsId_;
		public uint bodyColorId_;
		public uint tireColorId_;
		public uint interiorColorId_;
		public uint sticker1Id_;
		public uint sticker2Id_;
		public uint sticker3Id_;
		public uint sticker4Id_;
		public uint sticker5Id_;
		public int level_;
		public uint stickerSetId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCustomizeVehicle();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vehicle.SequenceActionCustomizeVehicle", 0, Black.Sequence.Action.Vehicle.SequenceActionCustomizeVehicle.ObjectType, null, properties, 0, 712);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vehicle.SequenceActionCustomizeVehicle", base.GetFieldProperties(), -1330023764, 2112061292);
            return fieldProperties;
        }

		
    }
}