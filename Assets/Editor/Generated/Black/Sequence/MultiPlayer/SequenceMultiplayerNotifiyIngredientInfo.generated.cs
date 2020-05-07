using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.MultiPlayer
{
    public partial class SequenceMultiplayerNotifiyIngredientInfo : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin ingredientPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin ingredientIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin ingredientCategoryIdPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceMultiplayerNotifiyIngredientInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.MultiPlayer.SequenceMultiplayerNotifiyIngredientInfo", 0, Black.Sequence.MultiPlayer.SequenceMultiplayerNotifiyIngredientInfo.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.MultiPlayer.SequenceMultiplayerNotifiyIngredientInfo", base.GetFieldProperties(), -930225760, 597836233);
            
			fieldProperties.AddProperty(new Property("changedPin_", 3906290903, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ingredientPointPin_", 3740719376, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 280, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ingredientIdPin_", 1420189023, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 368, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("ingredientCategoryIdPin_", 815055319, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 456, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}