using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorGetClothID : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin clothIdPin_;
		public int playerBankNumber_;
		public uint clothId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin same_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin different_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetClothID();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetClothID", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetClothID.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetClothID", base.GetFieldProperties(), 1199287027, 1580286763);
            
			
			
			return fieldProperties;
        }

		
    }
}