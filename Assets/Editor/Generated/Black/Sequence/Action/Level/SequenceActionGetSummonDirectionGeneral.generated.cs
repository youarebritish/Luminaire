using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetSummonDirectionGeneral : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finished_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin baseActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin bestYawAnglePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin bestScorePin_;
		public IList<Black.Entity.Data.CharacterEntry.SummonDirectionShapecastParameters> parameterList_;
		public IList<Black.Entity.Data.CharacterEntry.SummonDirectionRaycastParameters> parameterRayList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin spawnPointPin_;
		public int checkAngleNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetSummonDirectionGeneral();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetSummonDirectionGeneral", 0, Black.Sequence.Action.Level.SequenceActionGetSummonDirectionGeneral.ObjectType, null, properties, 0, 1144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetSummonDirectionGeneral", base.GetFieldProperties(), 1327066909, 1648563292);
            
			fieldProperties.AddProperty(new Property("finished_", 3052293812, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 480, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("failed_", 2601209585, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 576, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("baseActorPin_", 1474720149, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 672, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bestYawAnglePin_", 3581419917, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("bestScorePin_", 620201783, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 848, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("parameterList_", 1949686437, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.SummonDirectionShapecastParameters* >", 936, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("parameterRayList_", 1561994073, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.SummonDirectionRaycastParameters* >", 952, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("spawnPointPin_", 1892548174, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 968, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("checkAngleNum_", 4155186779, "int", 1056, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}