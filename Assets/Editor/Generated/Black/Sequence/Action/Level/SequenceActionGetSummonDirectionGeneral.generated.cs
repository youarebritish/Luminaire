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
            return fieldProperties;
        }

		
    }
}